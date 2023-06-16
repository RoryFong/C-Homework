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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }

        double Loan, Dealine, Interestrate, downpayment;
        int Totalpay, Monthpay;
        public void pay()
        {
            Loan = double.Parse(txtLoan.Text);   //貸款金額
            Dealine = double.Parse(txtDeadline.Text);
            Interestrate = double.Parse(txtInterestrate.Text);
            downpayment = double.Parse(txtdownpayment.Text);
            Totalpay = (int)((Loan - downpayment) * Math.Pow((1 + (Interestrate / 1200)), Dealine * 12));
            Monthpay = (int)(Totalpay / (Dealine*12));
        }
        private void btnPMT_Click(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("月付額:" + Monthpay.ToString() + "元");

        }

        private void btnTotalPayment_Click(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("總付款:" + Totalpay.ToString()+ "元");

        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            Loan_Report loan = new Loan_Report(Loan,Dealine,Interestrate,
            Totalpay,Monthpay);
            loan.Show();
        }


    }
}
