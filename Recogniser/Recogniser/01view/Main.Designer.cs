namespace Recogniser
{
    partial class Main
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pgbProcess = new System.Windows.Forms.ProgressBar();
            this.lvLog = new System.Windows.Forms.ListView();
            this.loadImage = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblTrainerCount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblModeSelected = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLoad);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnRun);
            this.flowLayoutPanel1.Controls.Add(this.btnSettings);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(323, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(405, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 43);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 33);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(221, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(103, 33);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(330, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(60, 33);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Ajustes";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pgbProcess
            // 
            this.pgbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbProcess.Location = new System.Drawing.Point(5, 49);
            this.pgbProcess.MarqueeAnimationSpeed = 10;
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Size = new System.Drawing.Size(720, 23);
            this.pgbProcess.Step = 20;
            this.pgbProcess.TabIndex = 12;
            // 
            // lvLog
            // 
            this.lvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLog.FullRowSelect = true;
            this.lvLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLog.Location = new System.Drawing.Point(5, 2);
            this.lvLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvLog.Name = "lvLog";
            this.lvLog.ShowGroups = false;
            this.lvLog.Size = new System.Drawing.Size(709, 369);
            this.lvLog.TabIndex = 14;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.List;
            // 
            // loadImage
            // 
            this.loadImage.FileName = "imageToLoad";
            this.loadImage.Title = "Load img";
            this.loadImage.FileOk += new System.ComponentModel.CancelEventHandler(this.loadImage_FileOk);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lvLog);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 448);
            this.panel1.TabIndex = 16;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgPreview_MouseClick);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lblTrainerCount);
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Controls.Add(this.lblModeSelected);
            this.grpStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpStatus.Location = new System.Drawing.Point(0, 0);
            this.grpStatus.MaximumSize = new System.Drawing.Size(316, 43);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(316, 43);
            this.grpStatus.TabIndex = 17;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // lblTrainerCount
            // 
            this.lblTrainerCount.AutoSize = true;
            this.lblTrainerCount.Location = new System.Drawing.Point(217, 19);
            this.lblTrainerCount.Name = "lblTrainerCount";
            this.lblTrainerCount.Size = new System.Drawing.Size(57, 15);
            this.lblTrainerCount.TabIndex = 18;
            this.lblTrainerCount.Text = "Trained: 0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(117, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 15);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "No loaded";
            // 
            // lblModeSelected
            // 
            this.lblModeSelected.AutoSize = true;
            this.lblModeSelected.Location = new System.Drawing.Point(6, 19);
            this.lblModeSelected.Name = "lblModeSelected";
            this.lblModeSelected.Size = new System.Drawing.Size(73, 15);
            this.lblModeSelected.TabIndex = 16;
            this.lblModeSelected.Text = "Mode: None";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.pgbProcess);
            this.pnlFooter.Controls.Add(this.grpStatus);
            this.pnlFooter.Controls.Add(this.flowLayoutPanel1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 377);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(728, 78);
            this.pnlFooter.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 455);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(744, 494);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLoad;
        private Button btnClear;
        private Button btnSettings;
        private ProgressBar pgbProcess;
        private ListView lvLog;
        private OpenFileDialog loadImage;
        private Button btnRun;
        private Panel panel1;
        private Label lblModeSelected;
        private GroupBox grpStatus;
        private Label lblTrainerCount;
        private Label lblStatus;
        private Panel pnlFooter;
    }
}