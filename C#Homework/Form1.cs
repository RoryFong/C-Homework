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
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;  
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Frm_Loan frm = new Frm_Loan();
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            Frm_Pos frm = new Frm_Pos();
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnStudent_StructForm_Click(object sender, EventArgs e)
        {
            Frm_Student_StructForm frm = new Frm_Student_StructForm();
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnStudentsGrade_Click(object sender, EventArgs e)
        {
            StudentsGrade frm = new StudentsGrade();
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }


        private void btnMyClac_Click(object sender, EventArgs e)
        {
            MyClac frm = new MyClac();
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Notepad frm = new Notepad();
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess frm =new Guess();
            frm.TopLevel = false;
            frm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

    }
}
