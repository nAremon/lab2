using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "14,26";
            textBox2.Text = "-1,22";
            textBox3.Text = "0,035";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + " X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + " Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + " Z = " + z.ToString();
            double a = 2 * Math.Cos(x - Math.PI / 6);
            double b = 0.5 + Math.Sin(y) * Math.Sin(y);
            double c = 3 - (z * z / 5);
            double t = (a / b) * (1 + (z * z / c));
            textBox4.Text += Environment.NewLine + " Результат t = " + t.ToString();
        }

    }
}
