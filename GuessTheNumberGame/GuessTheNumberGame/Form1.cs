using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumberGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int compNum, cnt;

        private void button2_Click(object sender, EventArgs e)
        {
            int myNum = int.Parse(textBox1.Text);
            cnt++;
            textBox3.Text = cnt.ToString();
            textBox1.Focus();
            textBox1.SelectAll();
            if (myNum<compNum)
            {
                textBox2.Text = "up";
            }
            if (myNum>compNum)
            {
                textBox2.Text = "down";
            }
            if (myNum == compNum)
            {
                textBox2.Text = "you guessed";
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            compNum = r.Next(1, 101);
            button2.Enabled = true;
            button1.Enabled = false;
            cnt = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
