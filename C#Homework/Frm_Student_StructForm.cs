using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class Frm_Student_StructForm : Form
    {
        public Frm_Student_StructForm()
        {
            InitializeComponent();
        }
        public class student
        {
            public string name;
            public int chinese;
            public int english;
            public int math;
        }
        string maxresult(int chinese,int english,int math)
        {
            string result = "";
            if (chinese > english)
            {
                if (chinese > math)
                {
                    result = $"國文:{chinese}分";
                    return result;
                }
                else
                {
                    result = $"數學:{math}分";
                    return result;
                }
            }
            else
            {
                if (english > math)
                {
                    result = $"英文:{english}分";
                    return result;
                }
                else
                {
                    result = $"數學:{math}分";
                    return result;
                }
            }
        }
        string minresult(int chinese, int english, int math)
        {
            string result = "";
            if (chinese < english)
            {
                if (chinese < math)
                {
                    result = $"國文:{chinese}分";
                    return result;
                }
                else
                {
                    result = $"數學:{math}分";
                    return result;
                }
            }
            else
            {
                if (english < math)
                {
                    result = $"英文:{english}分";
                    return result;
                }
                else
                {
                    result = $"數學:{math}分";
                    return result;
                }
            }
        }
        string studentgrade = "";
        string maxmin = "";
        private void btnsave_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.name = txtname.Text;
            st.chinese=int.Parse(txtchinese.Text);
            st.english=int.Parse(txtenglish.Text);
            st.math=int.Parse(txtmath.Text);
            studentgrade = $"姓名:{st.name}\r\n國文:{st.chinese}\r\n英文:"+
                $"{st.english}\r\n數學:{st.math}";
            string maxgrade = maxresult(st.chinese, st.english, st.math);
            string mingrade = minresult(st.chinese, st.english, st.math);
            maxmin = $"最高分科目為:{maxgrade}\n最低分科目為:{mingrade}";
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            txtgrade.Text = studentgrade;
        }

        private void btnmaxmin_Click(object sender, EventArgs e)
        {
            txtmaxmin.Text = maxmin;
        }
    }
}
