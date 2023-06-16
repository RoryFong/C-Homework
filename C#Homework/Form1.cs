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
    public partial class CsharpHomework : Form
    {
        public CsharpHomework()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Frm_Hello frm = new Frm_Hello();
            frm.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Frm_Loan frm = new Frm_Loan();
            frm.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            Frm_Pos frm = new Frm_Pos();
            frm.Show();
        }

        private void btnStudent_StructForm_Click(object sender, EventArgs e)
        {
            Frm_Student_StructForm frm = new Frm_Student_StructForm();
            frm.Show();
        }

        private void btnStudentsGrade_Click(object sender, EventArgs e)
        {
            StudentsGrade frm = new StudentsGrade();
            frm.Show();
        }


        private void btnMethod_Click(object sender, EventArgs e)
        {
            Method frm = new Method();
            frm.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            MyClac frm = new MyClac();
            frm.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            ForDo_While frm =new ForDo_While();
            frm.Show();
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            XOGame frm = new XOGame();
            frm.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            Screen_Saver frm = new Screen_Saver();
            frm.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Notepad frm = new Notepad();
            frm.Show();
        }

        private void btn小畫家_Click(object sender, EventArgs e)
        {
            小畫家 frm =new 小畫家();
            frm.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            Picture_Viewer frm = new Picture_Viewer();
            frm.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess frm =new Guess();
            frm.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Alarm frm =new Alarm();
            frm.Show();
        }

    }
}
