using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recogniser._01view
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Settings m = new Settings();
            m.Show();
        }
    }
}
