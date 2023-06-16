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
    public partial class Frm_Pos : Form
    {
        public Frm_Pos()
        {
            InitializeComponent();
        }
        decimal totalprice = 0,milktea=0,greentea=0,blacktea=0,barleytea=0;
        decimal milkcount=0,greencount=0,blackcount=0,barleycount=0;

        private void btncash_Click(object sender, EventArgs e)
        {
            if (totalprice > 0)
            {
                MessageBox.Show("總金額:NT" + totalprice, "確認付款", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK);
            }
        }

        private void btncreditcard_Click(object sender, EventArgs e)
        {
            if (totalprice > 0)
            {
                MessageBox.Show("總金額:NT$" + totalprice+"\n折扣後金額:NT$"+(int)totalprice*0.9,
                    "確認付款", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK);
            }
        }

        string result = "";

        public void showList()
        {
            result = " ";
            if (milkcount >= 1)
            {
                result += $"奶茶 x{milkcount},共NT${milktea}元\n";
            }
            if (greencount >= 1)
            {
                result += $"青茶 x{greencount},共NT${greentea}元\n";
            }
            if (blackcount >= 1)
            {
                result += $"紅茶 x{blackcount},共NT${blacktea}元\n";
            }
            if (barleycount >= 1)
            {
                result += $"麥茶 x{barleycount},共NT${barleytea}元\n";
            }
            labList.Text = result ;

        }
        
        private void btnclear_Click(object sender, EventArgs e)
        {
            totalprice = 0;
            milktea = 0;
            greentea = 0;
            blacktea = 0;
            barleytea = 0;
            milkcount = 0;
            greencount = 0;
            blackcount = 0;
            barleycount = 0;
            txtPrice.Text = $"NT${totalprice}";
            result = "尚未點餐";
            labList.Text = result;
        }


        private void btnmilktea_Click(object sender, EventArgs e)
        {
            totalprice += 60;
            milktea += 60;
            milkcount += 1;
            txtPrice.Text = $"NT${totalprice}";
            showList();
        }

        private void btngreentea_Click(object sender, EventArgs e)
        {
            totalprice += 30;
            greentea += 30;
            greencount += 1;
            txtPrice.Text = $"NT${totalprice}";
            showList();
        }

        private void btnblacktea_Click(object sender, EventArgs e)
        {
            totalprice += 35;
            blacktea += 35;
            blackcount += 1;
            txtPrice.Text = $"NT${totalprice}";
            showList();
        }

        private void btnbarleytea_Click(object sender, EventArgs e)
        {
            totalprice += 25;
            barleytea += 25;
            barleycount += 1;
            txtPrice.Text = $"NT${totalprice}";
            showList();
        }
    }
}
