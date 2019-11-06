using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_3._0
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                if (textBox1.Text.Contains("*"))
                {
                    i = textBox1.Text.IndexOf("*");
                }
                else
                    if (textBox1.Text.Contains("/"))
                {
                    i = textBox1.Text.IndexOf("/");
                }
                else
                    if (textBox1.Text.Contains("+"))
                {
                    i = textBox1.Text.IndexOf("+");
                }
                else
                    if (textBox1.Text.Contains("-"))
                {
                    i = textBox1.Text.IndexOf("-");
                }
                else
                    if(textBox1.Text.Contains("^"))
                {
                    i = textBox1.Text.IndexOf("^");
                }

                string a = textBox1.Text.Substring(i, 1);

                double a1 = Convert.ToDouble(textBox1.Text.Substring(0, i));
                double a2 = Convert.ToDouble(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));

                if (a == "*") 
                {
                    listBox1.Items.Add(textBox1.Text + "=" +" "+ (a1 * a2));
                    textBox1.Text = (a1 * a2).ToString();
                }
                else
                    if (a == "/")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + " " + (a1 / a2));
                    textBox1.Text = (a1 / a2).ToString();
                }
                else
                    if (a == "+")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + " " + (a1 + a2));
                    textBox1.Text = (a1 + a2).ToString();
                }
                else
                    if (a == "-")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + " " + (a1 - a2));
                    textBox1.Text = (a1 - a2).ToString();
                }
                else

                if (a == "^")
                {
                    double result = Math.Pow(a1, a2);
                    listBox1.Items.Add(textBox1.Text + "=" + " " + result);
                    textBox1.Text = result.ToString();
                }

                textBox1.Clear();

            }
            catch
            {
                textBox1.Clear();


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double x = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            listBox1.Items.Add("\u221A" + textBox1.Text + "=" + " " + x);
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            textBox1.Text += "^";
        }
    }
}
