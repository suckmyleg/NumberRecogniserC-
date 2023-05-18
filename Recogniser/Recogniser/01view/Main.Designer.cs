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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lvLog = new System.Windows.Forms.ListView();
            this.loadImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlToDraw = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLoad);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(313, 492);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 52);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 4);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 44);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(251, 4);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 44);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // imgPreview
            // 
            this.imgPreview.Enabled = false;
            this.imgPreview.Location = new System.Drawing.Point(14, 16);
            this.imgPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(626, 464);
            this.imgPreview.TabIndex = 10;
            this.imgPreview.TabStop = false;
            this.imgPreview.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(832, 492);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(69, 44);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Ajustes";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 553);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(887, 31);
            this.progressBar1.TabIndex = 12;
            // 
            // lvLog
            // 
            this.lvLog.FullRowSelect = true;
            this.lvLog.Location = new System.Drawing.Point(662, 16);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(240, 468);
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
            // pnlToDraw
            // 
            this.pnlToDraw.BackColor = System.Drawing.Color.Transparent;
            this.pnlToDraw.Location = new System.Drawing.Point(14, 16);
            this.pnlToDraw.Name = "pnlToDraw";
            this.pnlToDraw.Size = new System.Drawing.Size(642, 468);
            this.pnlToDraw.TabIndex = 15;
            this.pnlToDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlToDraw_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pnlToDraw);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLoad;
        private Button btnSave;
        private Button btnClear;
        private PictureBox imgPreview;
        private Button btnSettings;
        private ProgressBar progressBar1;
        private ListView lvLog;
        private OpenFileDialog loadImage;
        private Panel pnlToDraw;
        private Button button1;
    }
}