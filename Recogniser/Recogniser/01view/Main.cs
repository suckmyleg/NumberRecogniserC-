using Recogniser._02logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            AI ai = new AI();

        }
         
        public void ShowLogs() {
            lvLog.Items.Clear();
            Logger.GetLogs().ForEach((x)=>lvLog.Items.Add(x.ToString()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadImage.ShowDialog(this);
        }

        private void loadImage_FileOk(object sender, CancelEventArgs e)
        {
            //imgPreview.Load(loadImage.FileName);
            Bitmap myBitmap = new Bitmap(loadImage.FileName);
            g = Graphics.FromImage(myBitmap);
        }

        private void pnlToDraw_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.Black), Cursor.Position.X, Cursor.Position.X + 1,
                Cursor.Position.Y, Cursor.Position.Y + 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
