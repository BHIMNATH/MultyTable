using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Multy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            if (num.Text != "")
            {
                result.Show();
                te.Clear();
                int i, sum;
                int s = int.Parse(num.Text);
                tab.Text = "";
                for (i = 1; i <= 10; i++)
                {
                    sum = i * s;
                    te.Text = te.Text + (i + "\tX\t" + s + "\t=\t" + sum + "\n");// ;
                }
            }
            else num.Focus();

        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void num_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
