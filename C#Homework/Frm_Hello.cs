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
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string  EnglishName = txtEnglishName.Text;
            string Sex = txtSex.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show("Hello,我是" + Name + Environment.NewLine
                + "英文名字是" + EnglishName + Environment.NewLine +
                "性別是" + Sex + Environment.NewLine + "星座是" + Constellation +
                Environment.NewLine + "很高興認識你。");

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Sex = txtSex.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show("Hi,我是" + Name + Environment.NewLine
                + "英文名字是" + EnglishName + Environment.NewLine +
                "性別是" + Sex + Environment.NewLine + "星座是" + Constellation +
                Environment.NewLine + "很高興認識你。");

        }
    }
}
