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
    public partial class T5Q2 : Form
    {
        public T5Q2()
        {
            InitializeComponent();
        }

        private void T5Q2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void COM_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name" + textBox1.Text + " " + " form " + textBox2.Text + "" + "IS A" + textBox3.Text);
        }
    }
}
