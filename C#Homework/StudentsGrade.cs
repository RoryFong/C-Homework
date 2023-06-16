using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class StudentsGrade : Form
    {
        public StudentsGrade()
        {
            InitializeComponent();
        }

        public void showgrade()
        {
            label5.Text = "姓名";
            label6.Text = "國文";
            label7.Text = "英文";
            label8.Text = "數學";
            label9.Text = "總分";
            label10.Text = "平均";
            label11.Text = "最高";
            label12.Text = "最低";
            for (int i = 0; i <lsgrade.Count; i++)
            {
                label5.Text += $"\n{lsgrade[i].name}";
                label6.Text += $"\n{lsgrade[i].chinese}"; 
                label7.Text += $"\n{lsgrade[i].english}";
                label8.Text += $"\n {lsgrade[i].math}";
                label9.Text += $"\n{lsgrade[i].sum}";
                label10.Text += $"\n{lsgrade[i].avg}";
                label11.Text += $"\n{lsgrade[i].max}";
                label12.Text += $"\n{lsgrade[i].min}";
            }
        }
        List<grade> lsgrade = new List<grade>();
        private void btnadd_Click(object sender, EventArgs e)
        {
            grade grade;
            grade.name=txtname.Text;
            grade.chinese=int.Parse(txtchinese.Text);
            grade.english=int.Parse(txtenglish.Text);
            grade.math=int.Parse(txtmath.Text);
            grade.sum=grade.chinese+grade.english+grade.math;
            grade.avg = Math.Round((double)grade.sum / 3);
            grade.max=Math.Max(grade.math,Math.Max(grade.chinese,grade.english));
            grade.min = Math.Min(grade.math, Math.Min(grade.chinese, grade.english));
            lsgrade.Add(grade);
            showgrade();
        }
        int countname=1;
        private void button2_Click(object sender, EventArgs e)
        {
            grade grade;
            grade.name = countname.ToString();
            Random myobject = new Random();
            grade.chinese = myobject.Next(0,100);
            grade.english = myobject.Next(0, 100);
            grade.math = myobject.Next(0, 100);
            grade.sum = grade.chinese + grade.english + grade.math;
            grade.avg = Math.Round((double)grade.sum / 3);
            grade.max = Math.Max(grade.math, Math.Max(grade.chinese, grade.english));
            grade.min = Math.Min(grade.math, Math.Min(grade.chinese, grade.english));
            lsgrade.Add(grade);
            countname++;
            showgrade();
        }

        private void btn20add_Click(object sender, EventArgs e)
        {
            grade grade;
            Random myobject = new Random();
           for(int i = 0; i < 20; i++)
            {
            grade.name = countname.ToString();
            grade.chinese = myobject.Next(0, 100);
            grade.english = myobject.Next(0, 100);
            grade.math = myobject.Next(0, 100);
            grade.sum = grade.chinese + grade.english + grade.math;
            grade.avg = Math.Round((double)grade.sum / 3);
            grade.max = Math.Max(grade.math, Math.Max(grade.chinese, grade.english));
            grade.min = Math.Min(grade.math, Math.Min(grade.chinese, grade.english));
            lsgrade.Add(grade);
            countname++;
            }
            showgrade();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            decimal c_total = 0;
            double c_avg = 0;
            int c_max = lsgrade[0].chinese, c_min = lsgrade[0].chinese;
            for(int i = 0; i < lsgrade.Count; i++)
            {
                c_total += lsgrade[i].chinese;
                if (i < lsgrade.Count - 1)
                {
                        c_max = Math.Max(c_max, lsgrade[i + 1].chinese);
                        c_min = Math.Min(c_min, lsgrade[i + 1].chinese);
                    }
            }
            c_avg=Math.Round((double)c_total/lsgrade.Count);

            decimal e_total = 0;
            double e_avg = 0;
            int e_max = lsgrade[0].english, e_min = lsgrade[0].english;
            for (int i = 0; i < lsgrade.Count; i++)
            {
                e_total += lsgrade[i].english;
                if (i < lsgrade.Count - 1)
                {
                    e_max = Math.Max(e_max, lsgrade[i + 1].english);
                    e_min = Math.Min(e_min, lsgrade[i + 1].english);
                }
            }
            e_avg = Math.Round((double)e_total / lsgrade.Count);

            decimal m_total = 0;
            double m_avg = 0;
            int m_max = lsgrade[0].math, m_min = lsgrade[0].math;
            for (int i = 0; i < lsgrade.Count; i++)
            {
                m_total += lsgrade[i].math;
                if (i < lsgrade.Count - 1)
                {
                    m_max = Math.Max(m_max, lsgrade[i + 1].math);
                    m_min = Math.Min(m_min, lsgrade[i + 1].math);
                }
            }
            m_avg = Math.Round((double)m_total / lsgrade.Count);
            label21.Text = $"總分       {c_total}     {e_total}     {m_total}";
            label22.Text = $"平均         {c_avg}     {e_avg}     {m_avg}";
            label23.Text = $"最高分     {c_max}     {e_max}     {m_max}";
            label24.Text = $"最低分     {c_min}     {e_min}     {m_min}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lsgrade.Clear();
            showgrade();
            label21.Text = "總分";
            label22.Text = "平均";
            label23.Text = "最高分";
            label24.Text = "最低分";
        }
    }
}
