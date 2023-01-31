using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_calculation
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        String CallTotal;
        int number1;
        int number2;
        string option;
        int result;

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text= textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text=textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text!= null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text=textBox1.Text+"4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text!=null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text=textBox1.Text+"5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text!=null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0"&& textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text= textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text=textBox1.Text + "0";
            }
        }
        private void bdot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        } 
        private void bad_Click(object sender, EventArgs e)
        {
            option = "+";
            number1=int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            option = "-";
            number1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            option = "/";
            number1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

       
        private void bequal_Click(object sender, EventArgs e)
        {
            number2=Int32.Parse(textBox1.Text);
            if (option.Equals ("+"))
                result = number1 + number2;
            if(option.Equals("-"))
                result = number1 - number2;
            if(option.Equals("*"))
                result = number1 * number2;
            if(option.Equals("/"))
               result = number1 / number2;
            textBox1.Text = result + "";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            number1 = (0);
            number2 = (0);
        }
    }
}
