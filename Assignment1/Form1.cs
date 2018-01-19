using System;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text, button1.Text, MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text, button2.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox3.Text, button3.Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
    }
}
