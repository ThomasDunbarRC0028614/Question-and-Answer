using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_and_Answer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome. Question: 17-2*8=1, yes or no?");
        }
    }
}
