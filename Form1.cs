using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calculator_Trial
{
    public partial class Form1 : Form
    {
        double Value = 0 ;
        string operation = "" ;
        bool operation_pressed = false ;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button_Click(object sender, EventArgs e)
        {
            if((result.Text == "0" || operation_pressed ))
            {
                result.Clear();
            }
           Button b = (Button)sender;
           result.Text = result.Text + b.Text;
             

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            Value = Double.Parse(result.Text);
            operation_pressed = true;
            Previous_Operation.Text = Value.ToString();
        }

        private void Result_Event(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (Value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (Value - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (Value / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (Value * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
            Previous_Operation.Text = "0";

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            Value = 0;

        }
    }
}
