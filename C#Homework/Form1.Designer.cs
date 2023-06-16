namespace C_Homework
{
    partial class CsharpHomework
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CsharpHomework));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnMyClac = new System.Windows.Forms.Button();
            this.btnStudentsGrade = new System.Windows.Forms.Button();
            this.btnStudent_StructForm = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(795, 475);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnNotepad);
            this.splitContainer2.Panel1.Controls.Add(this.btnMyClac);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentsGrade);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudent_StructForm);
            this.splitContainer2.Panel1.Controls.Add(this.btnPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer2.Size = new System.Drawing.Size(795, 411);
            this.splitContainer2.SplitterDistance = 190;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(20, 322);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(161, 40);
            this.btnGuess.TabIndex = 14;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Location = new System.Drawing.Point(20, 278);
            this.btnNotepad.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(161, 40);
            this.btnNotepad.TabIndex = 11;
            this.btnNotepad.Text = "Notepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnMyClac
            // 
            this.btnMyClac.Location = new System.Drawing.Point(20, 234);
            this.btnMyClac.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnMyClac.Name = "btnMyClac";
            this.btnMyClac.Size = new System.Drawing.Size(161, 40);
            this.btnMyClac.TabIndex = 7;
            this.btnMyClac.Text = "MyClac";
            this.btnMyClac.UseVisualStyleBackColor = true;
            this.btnMyClac.Click += new System.EventHandler(this.btnMyClac_Click);
            // 
            // btnStudentsGrade
            // 
            this.btnStudentsGrade.Location = new System.Drawing.Point(20, 190);
            this.btnStudentsGrade.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStudentsGrade.Name = "btnStudentsGrade";
            this.btnStudentsGrade.Size = new System.Drawing.Size(161, 40);
            this.btnStudentsGrade.TabIndex = 4;
            this.btnStudentsGrade.Text = "StudentsGrade";
            this.btnStudentsGrade.UseVisualStyleBackColor = true;
            this.btnStudentsGrade.Click += new System.EventHandler(this.btnStudentsGrade_Click);
            // 
            // btnStudent_StructForm
            // 
            this.btnStudent_StructForm.Location = new System.Drawing.Point(20, 146);
            this.btnStudent_StructForm.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStudent_StructForm.Name = "btnStudent_StructForm";
            this.btnStudent_StructForm.Size = new System.Drawing.Size(161, 40);
            this.btnStudent_StructForm.TabIndex = 3;
            this.btnStudent_StructForm.Text = "Student_StructForm";
            this.btnStudent_StructForm.UseVisualStyleBackColor = true;
            this.btnStudent_StructForm.Click += new System.EventHandler(this.btnStudent_StructForm_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(20, 102);
            this.btnPos.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(161, 40);
            this.btnPos.TabIndex = 2;
            this.btnPos.Text = "Pos";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(20, 58);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(161, 40);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(20, 14);
            this.btnHello.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(161, 40);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // CsharpHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 475);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "CsharpHomework";
            this.Text = "C#作業";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnMyClac;
        private System.Windows.Forms.Button btnStudentsGrade;
        private System.Windows.Forms.Button btnStudent_StructForm;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnHello;
    }
}

