using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class Guessnumber : Form
    {
        public Guessnumber()
        {
            InitializeComponent();
            Answer = answer.ToString();
        }
        static Random myobject = new Random();
        public int answer = myobject.Next(1, 100);
        int a1 = 100, a2 = 0;
        string result = "";
        public string Answer
        {
            set
            {
                result= answer.ToString();
            }
            get
            {
                return result;
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                if (result != "答對了")
                {
                    checkguess(int.Parse(txtguess.Text));

                    Guess guess = (Guess)this.Owner;
                    guess.Controls["labguess"].Text = result;
                }
                break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void checkguess(int guess)
        {
            if (a1 < int.Parse(txtguess.Text) || a2 > int.Parse(txtguess.Text))
            {
                MessageBox.Show("請輸入區域內的值");
                txtguess.Clear();
                txtguess.Focus();
            }
            else
            {
                if (answer > Int32.Parse(txtguess.Text))
                {
                    a2 = int.Parse(txtguess.Text);
                    result = $"太小了，介於{a2}和{a1}之間";
                    txtguess.Clear();
                    txtguess.Focus();
                }
                else if (answer < int.Parse(txtguess.Text))
                {
                    a1 = int.Parse(txtguess.Text);
                    result = $"太大了，介於{a2}和{a1}之間";
                    txtguess.Clear();
                    txtguess.Focus();
                }
                else
                {
                    result = $"答對了";
                    MessageBox.Show("答對了!!!");
                }
            }
        }
    }
}
