using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class T5Q1 : Form
    {
        public T5Q1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Welcome to first application";
            //Welcome to first application
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
