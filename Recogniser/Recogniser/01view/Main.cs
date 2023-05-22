using Microsoft.VisualBasic.Logging;
using Recogniser._02logic.Settings;
using System.ComponentModel;

namespace Recogniser
{
    public partial class Main : Form
    {
        Graphics g;
        public Main()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings m = new Settings();
            m.Show();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Modes.AddMode(new Mode("Fast", 28 * 28, 2, 10, 10, 0.1, 100, false));
            Modes.AddMode(new Mode("Accurate", 28 * 28, 2, 15, 10, 0.01, 10000, false));
            Modes.AddMode(new Mode("Nasa", 28 * 28, 3, 10, 10, 0.01, 100000, false));
            Modes.AddMode(new Mode("Custom", 28 * 28, 2, 10, 10, 0.1, 100, true));
            Modes.SetMode("Fast");
            ShowNeuralInfo();
        }

        public void ShowNeuralInfo()
        {
            lblModeSelected.Text = "Mode: " + Modes.SelectedMode;
            lblTrainerCount.Text = "Trained: " + ImageRecogniser.GetTotalTrained();

            lblStatus.Text = new string[] { "BAD", "No Neural", "No trained", "Training", "OK", "Thinking" }[ImageRecogniser.GetStatus()+1];
            lblStatus.ForeColor = new Color[] { Color.Red, Color.Red, Color.Orange, Color.Gray, Color.Green, Color.Gray}[ImageRecogniser.GetStatus()+1];
            pgbProcess.ForeColor = new Color[] { Color.Red, Color.Red, Color.Orange, Color.Gray, Color.Green, Color.Gray }[ImageRecogniser.GetStatus() + 1];

        }

        public void ReloadLogs() {
            try
            {
                ShowLogs();
                ShowNeuralInfo();
                ReloadProgressBar();
            }
            catch { }
        }

        public void ShowLogs() {
            if (Logger.HasRemoved())
            {
                lvLog.Clear();
                Logger.GetNewLogs();
                Logger.GetReloadedLogs();
                Logger.GetLogs().ForEach((x) => lvLog.Items.Add(x.ToString()));
            }
            else{ 
                Logger.GetNewLogs().ForEach((x) => lvLog.Items.Add(x.ToString()));
                Logger.GetReloadedLogs().ForEach((x) => lvLog.Items[x.GetIndex()] = new(x.ToString()));
            }
        }

        public void ReloadProgressBar() {
            ProgressLog p;
            int value = 0;
            int count = 0;
            foreach (Log l in Logger.GetLogs()) {
                if (l.GetType() == typeof(ProgressLog)) {
                    p = (ProgressLog)l;

                    if (!p.HasFinished())
                    {
                        count++;
                        value += (int)(100 * p.Status());
                    }

                }
            }
            pgbProcess.Value = (count==0?100:value/count);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadImage.ShowDialog(this);
        }

        private void loadImage_FileOk(object sender, CancelEventArgs e)
        {
            using (Bitmap myBitmap = new(loadImage.FileName))
            {
                g = Graphics.FromImage(myBitmap);

                if (ImageRecogniser.HasNeural()) ImageRecogniser.RecogniseBitmap(myBitmap);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (ImageRecogniser.HasNeural()) ImageRecogniser.Test();
            else Logger.NewLine("No Neural Network created");
        }

        private void imgPreview_MouseClick(object sender, MouseEventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.Black), Cursor.Position.X-Program.main.Location.X, Cursor.Position.Y - Program.main.Location.Y,
                Cursor.Position.X - Program.main.Location.X+1, Cursor.Position.Y - Program.main.Location.Y+1);

        }
    }
}
