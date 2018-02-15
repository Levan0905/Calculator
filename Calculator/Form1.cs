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
        CalcActions calc = new CalcActions();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
        
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += (sender as Button).Text;     
        }

        private void Null_Click(object sender, EventArgs e)
        {

            if (label1.Text != "0")
            {
                label1.Text += "0";
            }

        }

        private void Dot_Click(object sender, EventArgs e)
        {

            if (label1.Text.IndexOf(",")==-1)
            {
                label1.Text = label1.Text + ",";
            };
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label1.Text = "0";
            label2.Text = null;
            label3.Text = null;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
            if  (label1.Text.Length==0)
            {
                label1.Text = null;
                label1.Text = "0";
            }

        }

      
        

        private void Plus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label2.Text) && label1.Text == "0")
            {
                label2.Text = "0";
                label3.Text = "+";
                label1.Text = "0";
            }

            if (label1.Text == "0" && label2.Text=="0")
            {               
                label3.Text = "+";              
            }

            if (label1.Text != "0")
            {
                label2.Text = label1.Text;
                label3.Text = "+";
                label1.Text = "0";
            }

            else if (label1.Text == "0" && label2.Text != "0" && label3.Text != "0")
            {
                label2.Text = label2.Text;
                label3.Text = "+";
            }

            else
            {
                if (label2.Text != "0" && label3.Text != "+" && label1.Text != "0")
                {
                    label2.Text += label3.Text + label1.Text;
                    label3.Text = "+";
                    label1.Text = calc.actions(label2.Text, label1.Text, label3.Text);
                }
            }
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label2.Text) && label1.Text == "0")
            {
                label2.Text = "0";
                label3.Text = "-";
                label1.Text = "0";
            }

            if (label1.Text == "0" && label2.Text == "0")
            {
                label3.Text = "-";
            }

            if (label1.Text != "0")
            { 
                label2.Text = label1.Text;
                label3.Text = "-";               
                label1.Text = "0";
            }

            else if (label2.Text != "0" && label3.Text != "0")
            {
                label2.Text = label2.Text;
                label3.Text = "-";
            }
        }

        private void Multipl_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label2.Text) && label1.Text == "0")
            {
                label2.Text = "0";
                label3.Text = "*";
                label1.Text = "0";
            }

            if (label1.Text == "0" && label2.Text == "0")
            {
                label3.Text = "*";
            }

            if (label1.Text != "0")
            { 
                label2.Text = label1.Text;
                label3.Text = "*";
                label1.Text = "0";
            }

            else if (label2.Text != "0" && label3.Text != "0")
            {
                label2.Text = label2.Text;
                label3.Text = "*";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label2.Text) && label1.Text == "0")
            {
                label2.Text = "0";
                label3.Text = "/";
                label1.Text = "0";
            }

            if (label1.Text == "0" && label2.Text == "0")
            {
                label3.Text = "/";
            }

            if (label1.Text != "0")
            { 
                label2.Text = label1.Text;
                label3.Text = "/";
                label1.Text = "0";
            }

        
            else if (label2.Text != "0" && label3.Text != "0")
            {
                label2.Text = label2.Text;
                label3.Text = "/";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            label1.Text = calc.actions(label2.Text,label1.Text, label3.Text);
            label2.Text = null;
            label3.Text = null;
        }
    }
}
