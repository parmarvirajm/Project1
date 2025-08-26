using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Green;
        }

        private void RED_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Blue;

        }

        private void CYAM_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Cyan;

        }

        private void PINK_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Pink;
        }

        private void BLACK_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }
    }
}
