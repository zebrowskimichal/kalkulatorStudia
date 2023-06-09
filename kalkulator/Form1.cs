﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
            display.Text = "";
        }


        private void numberButton(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;
            if (display.Text == "0" && display.Text != null)
            {
                display.Text += " " + clickedValue;
            }
            else
            {
                display.Text = display.Text + " " + clickedValue;
            }
        }
        private void operatorButton(object sender, EventArgs e)
        {
            var clickedOperator = (sender as Button).Text;
            FirstNumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = clickedOperator;
        }

        private void cButton(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void equalButton(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(display.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    display.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    display.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
