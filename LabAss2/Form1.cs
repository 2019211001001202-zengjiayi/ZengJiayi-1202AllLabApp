using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textNumber1.Text);
            double n2 = Convert.ToDouble(textNumber2.Text);
            double result = n1 + n2;
            MessageBox.Show(n1 + "+" + n2 + " = " + result);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textNumber1.Text);
            double n2 = Convert.ToDouble(textNumber2.Text);
            double result = n1 - n2;
            MessageBox.Show(n1 + "-" + n2 + " = " + result);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        { 
        double n1 = Convert.ToDouble(textNumber1.Text);
        double n2 = Convert.ToDouble(textNumber2.Text);
        double result = n1 / n2;
        MessageBox.Show(n1 + "/" + n2 + " = " + result);
            }
        private void textBox9_TextChanged(object sender, EventArgs e)
        { 
            double n1 = Convert.ToDouble(textNumber1.Text);
            double n2 = Convert.ToDouble(textNumber2.Text);
            double result = n1 * n2;
            MessageBox.Show(n1 + "*" + n2 + " = " + result);
        }
    }
}
