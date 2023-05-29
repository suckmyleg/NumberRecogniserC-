using Microsoft.VisualBasic.Devices;
using Recogniser._02logic.Settings;
using System.Security.Policy;
using System.Windows.Forms;

namespace Recogniser
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Modes.SelectedMode != null) ApplyMode(Modes.GetModes()[Modes.SelectedMode]);
            WriteModes();
            AvailableOptions();
        }

        private void TrainNeural() {
            int trainOutput = ImageRecogniser.Train((double)valTrainCount.Value);

            Program.main.ShowNeuralInfo();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(TrainNeural));
            thread.Start();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ProgressLog l = new("Creating Neural Network...", 1);

            int[] layers = new int[2 + (int)valHidden.Value];

            layers[0] = (int)valInputs.Value;
            layers[1 + (int)valHidden.Value] = (int)valOutput.Value;

            for (int i = 1; i < 1 + (int)valHidden.Value; i++) layers[i] = (int)valNeurons.Value;

            ImageRecogniser.CreateNeural(layers, (double)valLearningRate.Value);

            Program.main.ShowNeuralInfo();

            l.Finish("Created Neural Network!");

            AvailableOptions();
        }

        private void btnResetBasis_Click(object sender, EventArgs e)
        {
            if (ImageRecogniser.HasNeural()) ImageRecogniser.ResetBasis();
        }

        private void btnResetWeights_Click(object sender, EventArgs e)
        {
            if (ImageRecogniser.HasNeural()) ImageRecogniser.ResetWeights();
        }

        private void WriteModes() {
            inpMode.Items.Clear();
            foreach (KeyValuePair<String, Mode> k in Modes.GetModes()) inpMode.Items.Add(k.Value.Name);
        }

        private void AvailableOptions(){
            btnResetBasis.Enabled = ImageRecogniser.HasNeural();
            btnResetAll.Enabled = ImageRecogniser.HasNeural();
            btnResetWeights.Enabled = ImageRecogniser.HasNeural();
            btnTrain.Enabled = ImageRecogniser.HasNeural();
        }

    private void SetEnableModeInputs(Boolean v) {
            valInputs.Enabled = v;
            valHidden.Enabled = v; 
            valNeurons.Enabled = v;
            valOutput.Enabled = v;
            valLearningRate.Enabled = v;
            btnSaveMode.Enabled = v;
        }

        private void ApplyMode(Mode m) {
            valInputs.Value = (decimal)m.InputLayers;
            valHidden.Value = (decimal)m.HiddenLayers;
            valNeurons.Value = (decimal)m.NeuronsCount;
            valOutput.Value = (decimal)m.OutputValues;
            valLearningRate.Value = (decimal)m.LearningRate;
            valTrainCount.Value = (decimal)m.TrainCount;
            inpMode.Text = m.Name;

            SetEnableModeInputs(m.Editable);

            Modes.SetMode(m.Name);
        }

        private void inpMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode mode = Modes.GetModes()[inpMode.Text];
            if (mode != null) { ApplyMode(mode); }
        }

        private void btnSaveMode_Click(object sender, EventArgs e)
        {
            if (valInputs.Enabled)
            {
                Modes.AddMode(new Mode(inpMode.Text, (double)valInputs.Value, (double)valHidden.Value,
                    (double)valNeurons.Value, (double)valOutput.Value, (double)valLearningRate.Value,
                    (double)valTrainCount.Value, true));

                Mode mode = Modes.GetModes()[inpMode.Text];
                if (mode != null) { ApplyMode(mode); }

                WriteModes();
            }
        }

        private void CreateNeuralAndTrain() {

            Log neuralCreation = new Log("Creating Neural Network...");
            int[] layers = new int[2 + (int)valHidden.Value];

            layers[0] = (int)valInputs.Value;
            layers[1 + (int)valHidden.Value] = (int)valOutput.Value;

            for (int i = 1; i < 1 + (int)valHidden.Value; i++)
                layers[i] = (int)valNeurons.Value;

            int createOutput = ImageRecogniser.CreateNeural(layers, (double)valLearningRate.Value);

            //If the Neural Network has been created then train the model
            if (createOutput == 0)
            {
                int trainOutput = ImageRecogniser.Train((double)valTrainCount.Value);

                if (trainOutput == 0)
                {
                    neuralCreation.Reload("Created Neural Network!");
                }
                else
                {
                    //If success training then display Created, but 
                    neuralCreation.Remove();
                }

            }
            else
            {
                neuralCreation.Reload("Error creating Neural Network");
            }

            Program.main.ShowNeuralInfo();

            AvailableOptions();
        }

        private void btnApplyTrain_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(CreateNeuralAndTrain));
            thread.Start();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            if (ImageRecogniser.HasNeural()) {
                ImageRecogniser.ResetBasis();
                ImageRecogniser.ResetWeights();
            }
        }


        private void inpMode_KeyPress(object sender, KeyPressEventArgs e){
        
        }

        private void inpMode_TextUpdate(object sender, EventArgs e)
        {
            Mode m = Modes.Get(inpMode.Text);

            SetEnableModeInputs((m==null||m.Editable));
        }

        private void valLearningRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkPrintMode_CheckedChanged(object sender, EventArgs e)
        {
            ImageRecogniser.SetPrintMode(chkPrintMode.Checked ? 0 : 1);
        }
    }
}
