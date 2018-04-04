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
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string operation = "";
        double memory = 0;
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }
        int u = 0;
        private void numbers(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            u++;
            if (u == 1)
            {
                display.Text = btn.Text;
                label1.Text = btn.Text;
            }
            else
            {
                display.Text += btn.Text;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            double a = double.Parse(display.Text);

            if (operation != "") 
            {
                if (operation == "x")
                {
                    firstNumber = firstNumber * a;
                }
                if (operation == "÷")
                {
                    firstNumber = firstNumber / a;
                }
                if (operation == "+")
                {
                    firstNumber = firstNumber + a;
                }
                if (operation == "-")
                {
                    firstNumber = firstNumber - a;
                }
            }
            if (operation == "")
            {
                firstNumber = a;
                label1.Text = firstNumber.ToString();
            }
            if (btn.Text == "y√x" || btn.Text == "x^y")
            {
                if (btn.Text == "y√x")
                    label1.Text += " yroot ";
                if (btn.Text == "x^y")
                    label1.Text += " ^ ";
            }
            else
            label1.Text = firstNumber.ToString() + btn.Text;
            operation = btn.Text;
            display.Text = 0 + "";
            u = 0;
        }

        private void result_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(display.Text);
            if (operation == "x")
            {
                result = firstNumber * secondNumber;
            }
            if (operation == "÷")
            {
                result = firstNumber / secondNumber;
            }
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            if (operation == "mod")
            {
                double s = firstNumber / secondNumber;
                double t = firstNumber - (Convert.ToInt32(s)) * secondNumber;
                if (t >= 0)
                {
                    result = firstNumber - (Convert.ToInt32(s)) * secondNumber;
                }
                else
                {
                    result = secondNumber + firstNumber - (Convert.ToInt32(s)) * secondNumber;
                }
            }

            if (operation == "x^y")
            {
                double t = 1;
                for (int i = 0; i < secondNumber; i++)
                {
                    t = t * firstNumber;
                }
                result = t;
            }
            if (operation == "y√x")
            {
                result = Math.Pow(firstNumber, 1 / secondNumber);
            }

            if (operation == "%")
            {
                result = firstNumber * secondNumber / 100;
            }
            display.Text = result.ToString();
            label1.Text = "";
            u = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = 0 + "";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
            label1.Text = "";
            u = 0;
        }
        private void CE_click(object sender, EventArgs e)
        {
            if (secondNumber != 0)
            {
                secondNumber = 0;
            }
            u = 0;
            string t = "";
            string s = secondNumber + "";
            for (int i = 0; i < label1.Text.Length - s.Length; i++)
            {
                t = t + label1.Text[i];
            }
            label1.Text = t;
            display.Text = 0 + "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains("sin") && !label1.Text.Contains("cos") && !label1.Text.Contains("tan") && !label1.Text.Contains("fact") && !label1.Text.Contains("mod") && !label1.Text.Contains("sqr"))
            {

                string s = "";
                for (int i = 0; i < display.Text.Length - 1; i++)
                {
                    s = s + display.Text[i];
                }
                if (s != "")
                {
                    display.Text = s;
                    label1.Text = s;
                }
                else
                {
                    display.Text = 0 + "";
                    label1.Text = "";
                }
                u = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = Math.E.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = Math.PI.ToString();
        }

        private void Form1_Load_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR!!!");
        }

        private void Ms_Click(object sender, EventArgs e)
        {
            memory = double.Parse(display.Text);
            display.Text = 0 + "";
        }

        private void memory_read(object sender, EventArgs e)
        {
            display.Text = memory.ToString();
        }

        private void memory_clear(object sender, EventArgs e)
        {
            memory = 0;
        }
        private void memory_plus(object sender, EventArgs e)
        {
            memory = memory + double.Parse(display.Text);
        }

        private void memory_minus(object sender, EventArgs e)
        {
            memory = memory - double.Parse(display.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operation_without_Click(object sender, EventArgs e)
        {
            Button btnn = sender as Button;
            operation = btnn.Text;
            firstNumber = double.Parse(display.Text);
            if (operation == "e^x")
            {
                double t = 1;
                for (int i = 0; i < firstNumber; i++)
                {
                    t = t * Math.E;
                }
                label1.Text = "(e)^" + firstNumber.ToString();
                result = t;
            }
            if (operation == "√")
            {
                result = Math.Sqrt(firstNumber);
                label1.Text = "sqr(" + firstNumber.ToString() + ")";
            }
            if (operation == "+/-")
            {
                if (firstNumber > 0)
                {
                    label1.Text = "-" + firstNumber.ToString();
                }
                if (firstNumber == 0)
                {

                }
                else
                {
                    label1.Text = ((-1)*firstNumber).ToString();
                }
                firstNumber =  (-1)*firstNumber;
                result = firstNumber;
            }
            if (operation == "x!")
            {
                double c = firstNumber;
                double t = 1;
                while (c != 0)
                {
                    t = t * c;
                    c--;
                }
                label1.Text = "fact(" + firstNumber.ToString() + ")";
                result = t;
            }
            if (operation == "1/x")
            {
                label1.Text = "1/" + firstNumber.ToString();
                result = 1 / firstNumber;
            }
            if (operation == "sin")
            {
                label1.Text = "sin(" + firstNumber.ToString() + ")";
                result = Math.Sin(firstNumber * Math.PI / 180);
            }
            if (operation == "cos")
            {
                label1.Text = "cos(" + firstNumber.ToString() + ")";
                result = Math.Cos(firstNumber * Math.PI / 180);
            }
            if (operation == "tan")
            {
                label1.Text = "tan(" + firstNumber.ToString() + ")";
                result = Math.Tan(firstNumber * Math.PI / 180);
            }
            if (operation == "x^2")
            {
                label1.Text = "(" + firstNumber.ToString() + ")^2";
                result = firstNumber * firstNumber;
            }
            if (operation == "3^x")
            {
                double t = 1;
                for (int i = 0; i < firstNumber; i++)
                {
                    t = t * 3;
                }
                label1.Text = "(3)^" + "(" + firstNumber.ToString() + ")";
                result = t;
            }
            if (operation == "2^x")
            {
                double t = 1;
                for (int i = 0; i < firstNumber; i++)
                {
                    t = t * 2;
                }
                label1.Text = "(2)^" + "(" + firstNumber.ToString() + ")";
                result = t;
            }
            if (operation == "10^x")
            {
                double t = 1;
                for (int i = 0; i < firstNumber; i++)
                {
                    t = t * 10;
                }
                label1.Text = "(10)^" + "(" + firstNumber.ToString() + ")";
                result = t;
            }
            display.Text = result + "";
        }

        private void point(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            if (!display.Text.Contains(","))
            {
                display.Text += ",";
            }
        }
    }
}
