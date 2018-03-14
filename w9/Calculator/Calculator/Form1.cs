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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numbers(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            operation = btn.Text;
            display.Text = "";

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
            display.Text = result.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
        }
    }
}
