using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_app
{
    public partial class Form1 : Form
    {
        int finalResult;
        int num1;
        int num2;
        string operation;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textDisplay.Text += button0.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if(textDisplay.Text != null)
                {
                    num1 = int.Parse(textDisplay.Text);
                    operation = "+";
                    textDisplay.Text += operation;
                }
            }

            catch (Exception exp)
            {
                textDisplay.Text += "";
                Console.WriteLine(exp);
                textDisplay.Clear();
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                if(textDisplay.Text != null)
                {
                    num1 = int.Parse(textDisplay.Text);
                    operation = "-";
                    textDisplay.Text += operation;
                }
            }

            catch (Exception exp)
            {
                textDisplay.Text += "";
                Console.WriteLine(exp);
                textDisplay.Clear();
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try { 
                if(textDisplay.Text != null)
                {
                    num1 = int.Parse(textDisplay.Text);
                    textDisplay.Text += buttonMultiply.Text;
                    operation = "x";
                }
            }

            catch (Exception exp)
            {
                textDisplay.Text += "";
                Console.WriteLine(exp);
                textDisplay.Clear();
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                if (textDisplay.Text != null)
                {
                    num1 = int.Parse(textDisplay.Text);
                    textDisplay.Text += buttonDivide.Text;
                    operation = "/";
                }
            }
            catch(Exception exp)
            {
                textDisplay.Text += "";
                Console.WriteLine(exp);
                textDisplay.Clear();
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if(num1 != 0)
                {
                    num2 = int.Parse(textDisplay.Text.Substring(textDisplay.Text.IndexOf(operation) + 1));
                    switch (operation)
                    {
                        case "+":
                            finalResult = num1 + num2;
                            break;
                        case "-":
                            finalResult = num1 - num2;
                            break;
                        case "x":
                            finalResult = num1 * num2;
                            break;
                        case "/":
                            finalResult = num1 / num2;
                            break;
                    }

                    if(num1 == 0 && operation == "/")
                    {
                        Console.WriteLine("Called");
                        textDisplay.Text = "Invalid";
                    }

                    else {
                        textDisplay.Clear();
                        textDisplay.Text = finalResult + "";
                        operation = "";
                    }
                    
                }
            }

            catch (Exception exp)
            {
                textDisplay.Text += "";
                Console.WriteLine(exp);
                textDisplay.Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            num1 =(0);
            num2 = (0);
            finalResult = (0);
            operation = "";
            textDisplay.Clear();
        }
    }
}
