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
    public partial class Loan_Report : Form
    {
        public Loan_Report(double Loan,double Dealine,double Interestrate,
            int Totalpay,int Monthpay)
        {
            InitializeComponent();
            Frm_Loan loan = new Frm_Loan();
            labLoan.Text = Loan.ToString();
            labDealine.Text = Dealine.ToString();
            labInterestrate.Text = Interestrate.ToString();
            labMonthPay.Text = Monthpay.ToString();
            labTotalpay.Text = Totalpay.ToString();
        }


    }
}
