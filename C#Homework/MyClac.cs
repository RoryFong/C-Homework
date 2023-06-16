using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            double num1=0, num2=0;
            if(double.TryParse(txtnum1.Text,out num1))
            {
                if (double.TryParse(txtnum2.Text, out num2))
                {
                    labanswer.Text = (num1 + num2).ToString();
                }
                else
                {
                    MessageBox.Show("請輸入數值");
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;
            if (double.TryParse(txtnum1.Text, out num1))
            {
                if (double.TryParse(txtnum2.Text, out num2))
                {
                    labanswer.Text = (num1 - num2).ToString();
                }
                else
                {
                    MessageBox.Show("請輸入數值");
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }

        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;
            if (double.TryParse(txtnum1.Text, out num1))
            {
                if (double.TryParse(txtnum2.Text, out num2))
                {
                    labanswer.Text = (num1 * num2).ToString();
                }
                else
                {
                    MessageBox.Show("請輸入數值");
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }

        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;
            if (double.TryParse(txtnum1.Text, out num1))
            {
                if (double.TryParse(txtnum2.Text, out num2))
                {
                    if (num2 != 0)
                    {
                    labanswer.Text = Math.Round(num1 / num2,2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("分母不能為零");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入數值");
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
}
