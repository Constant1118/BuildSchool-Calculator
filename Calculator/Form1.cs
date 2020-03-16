using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btc(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            var _click = (Button)sender;
            textBox1.Text = textBox1.Text + _click.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            textBox1.Text = textBox1.Text + ".";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button24.Enabled = true;
            textBox1.Text = "0";
        }
    }
}
