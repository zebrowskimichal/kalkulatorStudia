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
        public Form1()
        {
            InitializeComponent();
        }

        private void numberButton(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;
            if(display.Text == "0")
                display.Text = string.Empty;
            display.Text += clickedValue;
        }

        private void operatorButton(object sender, EventArgs e)
        {

        }

        private void sumButton(object sender, EventArgs e)
        {

        }
    }
}
