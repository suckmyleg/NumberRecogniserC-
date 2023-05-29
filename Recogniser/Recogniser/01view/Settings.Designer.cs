namespace Recogniser
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveMode = new System.Windows.Forms.Button();
            this.DataGroup = new System.Windows.Forms.GroupBox();
            this.lblTrain = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.valTrainCount = new System.Windows.Forms.NumericUpDown();
            this.lblAll = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.lblDataBasis = new System.Windows.Forms.Label();
            this.btnResetBasis = new System.Windows.Forms.Button();
            this.lblDataWeights = new System.Windows.Forms.Label();
            this.btnResetWeights = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.inpMode = new System.Windows.Forms.ComboBox();
            this.chkPrintMode = new System.Windows.Forms.CheckBox();
            this.NeuralGroup = new System.Windows.Forms.GroupBox();
            this.btnApplyTrain = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.valLearningRate = new System.Windows.Forms.NumericUpDown();
            this.NeuralNetworkLayersGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valInputs = new System.Windows.Forms.NumericUpDown();
            this.valNeurons = new System.Windows.Forms.NumericUpDown();
            this.valHidden = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valOutput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.DataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valTrainCount)).BeginInit();
            this.NeuralGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valLearningRate)).BeginInit();
            this.NeuralNetworkLayersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveMode);
            this.groupBox1.Controls.Add(this.DataGroup);
            this.groupBox1.Controls.Add(this.lblProfile);
            this.groupBox1.Controls.Add(this.inpMode);
            this.groupBox1.Controls.Add(this.chkPrintMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recognition";
            // 
            // btnSaveMode
            // 
            this.btnSaveMode.Location = new System.Drawing.Point(9, 51);
            this.btnSaveMode.Name = "btnSaveMode";
            this.btnSaveMode.Size = new System.Drawing.Size(137, 23);
            this.btnSaveMode.TabIndex = 7;
            this.btnSaveMode.Text = "Save Mode";
            this.btnSaveMode.UseVisualStyleBackColor = true;
            this.btnSaveMode.Click += new System.EventHandler(this.btnSaveMode_Click);
            // 
            // DataGroup
            // 
            this.DataGroup.Controls.Add(this.lblTrain);
            this.DataGroup.Controls.Add(this.btnTrain);
            this.DataGroup.Controls.Add(this.valTrainCount);
            this.DataGroup.Controls.Add(this.lblAll);
            this.DataGroup.Controls.Add(this.btnResetAll);
            this.DataGroup.Controls.Add(this.lblDataBasis);
            this.DataGroup.Controls.Add(this.btnResetBasis);
            this.DataGroup.Controls.Add(this.lblDataWeights);
            this.DataGroup.Controls.Add(this.btnResetWeights);
            this.DataGroup.Location = new System.Drawing.Point(163, 13);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.Size = new System.Drawing.Size(252, 147);
            this.DataGroup.TabIndex = 6;
            this.DataGroup.TabStop = false;
            this.DataGroup.Text = "Data";
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.Location = new System.Drawing.Point(6, 107);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(35, 15);
            this.lblTrain.TabIndex = 11;
            this.lblTrain.Text = "Train:";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(177, 105);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 10;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // valTrainCount
            // 
            this.valTrainCount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.valTrainCount.Location = new System.Drawing.Point(65, 105);
            this.valTrainCount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.valTrainCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valTrainCount.Name = "valTrainCount";
            this.valTrainCount.Size = new System.Drawing.Size(106, 23);
            this.valTrainCount.TabIndex = 10;
            this.valTrainCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(6, 77);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(24, 15);
            this.lblAll.TabIndex = 8;
            this.lblAll.Text = "All:";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(65, 73);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 9;
            this.btnResetAll.Text = "Reset";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // lblDataBasis
            // 
            this.lblDataBasis.AutoSize = true;
            this.lblDataBasis.Location = new System.Drawing.Point(6, 48);
            this.lblDataBasis.Name = "lblDataBasis";
            this.lblDataBasis.Size = new System.Drawing.Size(36, 15);
            this.lblDataBasis.TabIndex = 6;
            this.lblDataBasis.Text = "Basis:";
            // 
            // btnResetBasis
            // 
            this.btnResetBasis.Location = new System.Drawing.Point(65, 44);
            this.btnResetBasis.Name = "btnResetBasis";
            this.btnResetBasis.Size = new System.Drawing.Size(75, 23);
            this.btnResetBasis.TabIndex = 7;
            this.btnResetBasis.Text = "Reset";
            this.btnResetBasis.UseVisualStyleBackColor = true;
            this.btnResetBasis.Click += new System.EventHandler(this.btnResetBasis_Click);
            // 
            // lblDataWeights
            // 
            this.lblDataWeights.AutoSize = true;
            this.lblDataWeights.Location = new System.Drawing.Point(6, 19);
            this.lblDataWeights.Name = "lblDataWeights";
            this.lblDataWeights.Size = new System.Drawing.Size(53, 15);
            this.lblDataWeights.TabIndex = 4;
            this.lblDataWeights.Text = "Weights:";
            // 
            // btnResetWeights
            // 
            this.btnResetWeights.Location = new System.Drawing.Point(65, 15);
            this.btnResetWeights.Name = "btnResetWeights";
            this.btnResetWeights.Size = new System.Drawing.Size(75, 23);
            this.btnResetWeights.TabIndex = 5;
            this.btnResetWeights.Text = "Reset";
            this.btnResetWeights.UseVisualStyleBackColor = true;
            this.btnResetWeights.Click += new System.EventHandler(this.btnResetWeights_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(9, 25);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(41, 15);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = "Mode:";
            // 
            // inpMode
            // 
            this.inpMode.FormattingEnabled = true;
            this.inpMode.Location = new System.Drawing.Point(67, 22);
            this.inpMode.Name = "inpMode";
            this.inpMode.Size = new System.Drawing.Size(79, 23);
            this.inpMode.TabIndex = 2;
            this.inpMode.Text = "Accurate";
            this.inpMode.SelectedIndexChanged += new System.EventHandler(this.inpMode_SelectedIndexChanged);
            this.inpMode.TextUpdate += new System.EventHandler(this.inpMode_TextUpdate);
            this.inpMode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inpMode_KeyPress);
            // 
            // chkPrintMode
            // 
            this.chkPrintMode.AutoSize = true;
            this.chkPrintMode.Checked = true;
            this.chkPrintMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintMode.Location = new System.Drawing.Point(9, 139);
            this.chkPrintMode.Name = "chkPrintMode";
            this.chkPrintMode.Size = new System.Drawing.Size(135, 19);
            this.chkPrintMode.TabIndex = 0;
            this.chkPrintMode.Text = "Show most probable";
            this.chkPrintMode.UseVisualStyleBackColor = true;
            this.chkPrintMode.CheckedChanged += new System.EventHandler(this.chkPrintMode_CheckedChanged);
            // 
            // NeuralGroup
            // 
            this.NeuralGroup.Controls.Add(this.btnApplyTrain);
            this.NeuralGroup.Controls.Add(this.btnApply);
            this.NeuralGroup.Controls.Add(this.label6);
            this.NeuralGroup.Controls.Add(this.valLearningRate);
            this.NeuralGroup.Controls.Add(this.NeuralNetworkLayersGroup);
            this.NeuralGroup.Location = new System.Drawing.Point(12, 184);
            this.NeuralGroup.Name = "NeuralGroup";
            this.NeuralGroup.Size = new System.Drawing.Size(421, 229);
            this.NeuralGroup.TabIndex = 2;
            this.NeuralGroup.TabStop = false;
            this.NeuralGroup.Text = "NeuralNetwork";
            // 
            // btnApplyTrain
            // 
            this.btnApplyTrain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyTrain.Location = new System.Drawing.Point(0, 201);
            this.btnApplyTrain.Name = "btnApplyTrain";
            this.btnApplyTrain.Size = new System.Drawing.Size(415, 23);
            this.btnApplyTrain.TabIndex = 12;
            this.btnApplyTrain.Text = "Create Neural Network and Train";
            this.btnApplyTrain.UseVisualStyleBackColor = true;
            this.btnApplyTrain.Click += new System.EventHandler(this.btnApplyTrain_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(0, 175);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(415, 23);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Create Neural Network";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "LearningRate:";
            // 
            // valLearningRate
            // 
            this.valLearningRate.DecimalPlaces = 3;
            this.valLearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.valLearningRate.Location = new System.Drawing.Point(290, 22);
            this.valLearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valLearningRate.Name = "valLearningRate";
            this.valLearningRate.Size = new System.Drawing.Size(55, 23);
            this.valLearningRate.TabIndex = 10;
            this.valLearningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.valLearningRate.ValueChanged += new System.EventHandler(this.valLearningRate_ValueChanged);
            // 
            // NeuralNetworkLayersGroup
            // 
            this.NeuralNetworkLayersGroup.Controls.Add(this.label2);
            this.NeuralNetworkLayersGroup.Controls.Add(this.label5);
            this.NeuralNetworkLayersGroup.Controls.Add(this.valInputs);
            this.NeuralNetworkLayersGroup.Controls.Add(this.valNeurons);
            this.NeuralNetworkLayersGroup.Controls.Add(this.valHidden);
            this.NeuralNetworkLayersGroup.Controls.Add(this.label4);
            this.NeuralNetworkLayersGroup.Controls.Add(this.label3);
            this.NeuralNetworkLayersGroup.Controls.Add(this.valOutput);
            this.NeuralNetworkLayersGroup.Location = new System.Drawing.Point(6, 13);
            this.NeuralNetworkLayersGroup.Name = "NeuralNetworkLayersGroup";
            this.NeuralNetworkLayersGroup.Size = new System.Drawing.Size(174, 156);
            this.NeuralNetworkLayersGroup.TabIndex = 10;
            this.NeuralNetworkLayersGroup.TabStop = false;
            this.NeuralNetworkLayersGroup.Text = "Layers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inputs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Neuron/Hidden:";
            // 
            // valInputs
            // 
            this.valInputs.Location = new System.Drawing.Point(109, 25);
            this.valInputs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.valInputs.Name = "valInputs";
            this.valInputs.Size = new System.Drawing.Size(55, 23);
            this.valInputs.TabIndex = 2;
            this.valInputs.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // valNeurons
            // 
            this.valNeurons.Location = new System.Drawing.Point(109, 89);
            this.valNeurons.Name = "valNeurons";
            this.valNeurons.Size = new System.Drawing.Size(55, 23);
            this.valNeurons.TabIndex = 8;
            this.valNeurons.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // valHidden
            // 
            this.valHidden.Location = new System.Drawing.Point(109, 58);
            this.valHidden.Name = "valHidden";
            this.valHidden.Size = new System.Drawing.Size(55, 23);
            this.valHidden.TabIndex = 4;
            this.valHidden.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Outputs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hidden:";
            // 
            // valOutput
            // 
            this.valOutput.Location = new System.Drawing.Point(109, 127);
            this.valOutput.Name = "valOutput";
            this.valOutput.Size = new System.Drawing.Size(55, 23);
            this.valOutput.TabIndex = 6;
            this.valOutput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 417);
            this.Controls.Add(this.NeuralGroup);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DataGroup.ResumeLayout(false);
            this.DataGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valTrainCount)).EndInit();
            this.NeuralGroup.ResumeLayout(false);
            this.NeuralGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valLearningRate)).EndInit();
            this.NeuralNetworkLayersGroup.ResumeLayout(false);
            this.NeuralNetworkLayersGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valNeurons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkPrintMode;
        private Label lblProfile;
        private ComboBox inpMode;
        private Label lblDataWeights;
        private GroupBox DataGroup;
        private Label lblDataBasis;
        private Button btnResetBasis;
        private Button btnResetWeights;
        private Button btnTrain;
        private Label lblAll;
        private Button btnResetAll;
        private GroupBox NeuralGroup;
        private Label label6;
        private NumericUpDown valLearningRate;
        private GroupBox NeuralNetworkLayersGroup;
        private Label label2;
        private Label label5;
        private NumericUpDown valInputs;
        private NumericUpDown valNeurons;
        private NumericUpDown valHidden;
        private Label label4;
        private Label label3;
        private NumericUpDown valOutput;
        private Button btnApply;
        private Label lblTrain;
        private NumericUpDown valTrainCount;
        private Button btnSaveMode;
        private Button btnApplyTrain;
    }
}