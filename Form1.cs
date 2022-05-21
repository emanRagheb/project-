using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operation = "";
        bool check = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
            resultvalue = 0;
            labelcurrentoperation.Text = "calc";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txt_result.Text == "0") || (check))
            {
                txt_result.Clear();
            }
            check = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if(!txt_result.Text.Contains("."))
                    txt_result.Text = txt_result.Text + b.Text;
            }
            else
            {
                txt_result.Text = txt_result.Text + b.Text;
            }        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(resultvalue != 0)
            {
                button18.PerformClick();
                operation = b.Text;
                labelcurrentoperation.Text = resultvalue + " " + operation;
                check = true;
            }
            else
            {                
                operation = b.Text;
                resultvalue = Double.Parse(txt_result.Text);
                labelcurrentoperation.Text = resultvalue + " " + operation;
                check = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txt_result.Text = (resultvalue + Double.Parse(txt_result.Text)).ToString();
                    break;
                case "-":
                    txt_result.Text = (resultvalue - Double.Parse(txt_result.Text)).ToString();
                    break;
                case "*":
                    txt_result.Text = (resultvalue * Double.Parse(txt_result.Text)).ToString();
                    break;
                case "/":
                    txt_result.Text = (resultvalue / Double.Parse(txt_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultvalue = Double.Parse(txt_result.Text);
            labelcurrentoperation.Text ="calc";
        }

        
    }
}
