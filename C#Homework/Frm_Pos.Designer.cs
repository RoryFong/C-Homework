namespace C_Homework
{
    partial class Frm_Pos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbarleytea = new System.Windows.Forms.Button();
            this.btnblacktea = new System.Windows.Forms.Button();
            this.btnmilktea = new System.Windows.Forms.Button();
            this.btngreentea = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncreditcard = new System.Windows.Forms.Button();
            this.btncash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labList = new System.Windows.Forms.Label();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbarleytea);
            this.groupBox1.Controls.Add(this.btnblacktea);
            this.groupBox1.Controls.Add(this.btnmilktea);
            this.groupBox1.Controls.Add(this.btngreentea);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(68, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 651);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單menu";
            // 
            // btnbarleytea
            // 
            this.btnbarleytea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbarleytea.Location = new System.Drawing.Point(236, 362);
            this.btnbarleytea.Name = "btnbarleytea";
            this.btnbarleytea.Size = new System.Drawing.Size(170, 216);
            this.btnbarleytea.TabIndex = 3;
            this.btnbarleytea.Text = "Barley tea\r\n NT$25";
            this.btnbarleytea.UseVisualStyleBackColor = true;
            this.btnbarleytea.Click += new System.EventHandler(this.btnbarleytea_Click);
            // 
            // btnblacktea
            // 
            this.btnblacktea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnblacktea.Location = new System.Drawing.Point(36, 360);
            this.btnblacktea.Name = "btnblacktea";
            this.btnblacktea.Size = new System.Drawing.Size(170, 216);
            this.btnblacktea.TabIndex = 2;
            this.btnblacktea.Text = "Black tea\r\nNT$35";
            this.btnblacktea.UseVisualStyleBackColor = true;
            this.btnblacktea.Click += new System.EventHandler(this.btnblacktea_Click);
            // 
            // btnmilktea
            // 
            this.btnmilktea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmilktea.Location = new System.Drawing.Point(236, 87);
            this.btnmilktea.Name = "btnmilktea";
            this.btnmilktea.Size = new System.Drawing.Size(170, 216);
            this.btnmilktea.TabIndex = 1;
            this.btnmilktea.Text = "Milk tea  \r\nNT$60";
            this.btnmilktea.UseVisualStyleBackColor = true;
            this.btnmilktea.Click += new System.EventHandler(this.btnmilktea_Click);
            // 
            // btngreentea
            // 
            this.btngreentea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btngreentea.Location = new System.Drawing.Point(36, 87);
            this.btngreentea.Name = "btngreentea";
            this.btngreentea.Size = new System.Drawing.Size(170, 216);
            this.btngreentea.TabIndex = 0;
            this.btngreentea.Text = "Green tea\r\nNT$30";
            this.btngreentea.UseVisualStyleBackColor = true;
            this.btngreentea.Click += new System.EventHandler(this.btngreentea_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(535, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額Total Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Black;
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(50, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(267, 57);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Text = "NT$0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncreditcard);
            this.groupBox3.Controls.Add(this.btncash);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(535, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // btncreditcard
            // 
            this.btncreditcard.Location = new System.Drawing.Point(181, 94);
            this.btncreditcard.Name = "btncreditcard";
            this.btncreditcard.Size = new System.Drawing.Size(148, 148);
            this.btncreditcard.TabIndex = 5;
            this.btncreditcard.Text = "信用卡";
            this.btncreditcard.UseVisualStyleBackColor = true;
            this.btncreditcard.Click += new System.EventHandler(this.btncreditcard_Click);
            // 
            // btncash
            // 
            this.btncash.Location = new System.Drawing.Point(16, 92);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(148, 148);
            this.btncash.TabIndex = 4;
            this.btncash.Text = "現金";
            this.btncash.UseVisualStyleBackColor = true;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labList);
            this.groupBox4.Controls.Add(this.Listbox);
            this.groupBox4.Controls.Add(this.btnclear);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(922, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(525, 651);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單List";
            // 
            // labList
            // 
            this.labList.AutoSize = true;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(57, 73);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(145, 40);
            this.labList.TabIndex = 8;
            this.labList.Text = "尚未點餐";
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 47;
            this.Listbox.Location = new System.Drawing.Point(28, 56);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(477, 427);
            this.Listbox.TabIndex = 7;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(148, 504);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(271, 110);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(664, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "信用卡享九折";
            // 
            // Frm_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 889);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Pos";
            this.Text = "Bar Pos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbarleytea;
        private System.Windows.Forms.Button btnblacktea;
        private System.Windows.Forms.Button btnmilktea;
        private System.Windows.Forms.Button btngreentea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncreditcard;
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.Label labList;
    }
}