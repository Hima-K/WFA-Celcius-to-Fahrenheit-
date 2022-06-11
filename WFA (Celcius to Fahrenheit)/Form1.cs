using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFS__Celcius_to_Fahrenheit_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the value that the user entered in the Celsius Text Box
            double celsiusValue = Double.Parse(textBox2.Text);
            // Apply the calculation
            double result = (celsiusValue * 9 / 5) + 32;
            // Store the result in the Fahrenheit Textbox
            textBox1.Text = result.ToString();
        }
    }
}
