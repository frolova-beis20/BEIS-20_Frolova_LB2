using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);
            float c;
            c = a / b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Деление";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);
            float c;
            c = a + b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Сложение";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);
            float c;
            c = a - b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Вычитание";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);
            float c;
            c = a * b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Умножение";           

        }
    }
}
