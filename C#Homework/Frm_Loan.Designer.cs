namespace C_Homework
{
    partial class Frm_Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPMT = new System.Windows.Forms.Button();
            this.labDealine = new System.Windows.Forms.Label();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.txtInterestrate = new System.Windows.Forms.TextBox();
            this.labInterestrate = new System.Windows.Forms.Label();
            this.txtdownpayment = new System.Windows.Forms.TextBox();
            this.labdownpayment = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.labLoan = new System.Windows.Forms.Label();
            this.btnTotalPayment = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPMT
            // 
            this.btnPMT.Location = new System.Drawing.Point(42, 324);
            this.btnPMT.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(135, 66);
            this.btnPMT.TabIndex = 0;
            this.btnPMT.Text = "PMT(月付)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // labDealine
            // 
            this.labDealine.AutoSize = true;
            this.labDealine.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDealine.Location = new System.Drawing.Point(87, 109);
            this.labDealine.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labDealine.Name = "labDealine";
            this.labDealine.Size = new System.Drawing.Size(133, 40);
            this.labDealine.TabIndex = 1;
            this.labDealine.Text = "期限(年)";
            // 
            // txtDeadline
            // 
            this.txtDeadline.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDeadline.Location = new System.Drawing.Point(278, 108);
            this.txtDeadline.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(256, 50);
            this.txtDeadline.TabIndex = 2;
            this.txtDeadline.Text = "2";
            // 
            // txtInterestrate
            // 
            this.txtInterestrate.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestrate.Location = new System.Drawing.Point(278, 170);
            this.txtInterestrate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtInterestrate.Name = "txtInterestrate";
            this.txtInterestrate.Size = new System.Drawing.Size(256, 50);
            this.txtInterestrate.TabIndex = 4;
            this.txtInterestrate.Text = "10";
            // 
            // labInterestrate
            // 
            this.labInterestrate.AutoSize = true;
            this.labInterestrate.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterestrate.Location = new System.Drawing.Point(87, 171);
            this.labInterestrate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labInterestrate.Name = "labInterestrate";
            this.labInterestrate.Size = new System.Drawing.Size(161, 40);
            this.labInterestrate.TabIndex = 3;
            this.labInterestrate.Text = "年利率(%)";
            // 
            // txtdownpayment
            // 
            this.txtdownpayment.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtdownpayment.Location = new System.Drawing.Point(278, 230);
            this.txtdownpayment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtdownpayment.Name = "txtdownpayment";
            this.txtdownpayment.Size = new System.Drawing.Size(256, 50);
            this.txtdownpayment.TabIndex = 6;
            this.txtdownpayment.Text = "0";
            // 
            // labdownpayment
            // 
            this.labdownpayment.AutoSize = true;
            this.labdownpayment.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labdownpayment.Location = new System.Drawing.Point(87, 232);
            this.labdownpayment.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labdownpayment.Name = "labdownpayment";
            this.labdownpayment.Size = new System.Drawing.Size(113, 40);
            this.labdownpayment.TabIndex = 5;
            this.labdownpayment.Text = "頭期款";
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.Location = new System.Drawing.Point(278, 48);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(256, 50);
            this.txtLoan.TabIndex = 8;
            this.txtLoan.Text = "100000";
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(87, 50);
            this.labLoan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(145, 40);
            this.labLoan.TabIndex = 7;
            this.labLoan.Text = "貸款金額";
            // 
            // btnTotalPayment
            // 
            this.btnTotalPayment.Location = new System.Drawing.Point(244, 324);
            this.btnTotalPayment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTotalPayment.Name = "btnTotalPayment";
            this.btnTotalPayment.Size = new System.Drawing.Size(135, 66);
            this.btnTotalPayment.TabIndex = 9;
            this.btnTotalPayment.Text = "總付款";
            this.btnTotalPayment.UseVisualStyleBackColor = true;
            this.btnTotalPayment.Click += new System.EventHandler(this.btnTotalPayment_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(492, 324);
            this.btnReport.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(135, 66);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 440);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPayment);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.txtdownpayment);
            this.Controls.Add(this.labdownpayment);
            this.Controls.Add(this.txtInterestrate);
            this.Controls.Add(this.labInterestrate);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.labDealine);
            this.Controls.Add(this.btnPMT);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Label labDealine;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.TextBox txtInterestrate;
        private System.Windows.Forms.Label labInterestrate;
        private System.Windows.Forms.TextBox txtdownpayment;
        private System.Windows.Forms.Label labdownpayment;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Button btnTotalPayment;
        private System.Windows.Forms.Button btnReport;
    }
}