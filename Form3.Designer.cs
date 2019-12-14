namespace WinFormDBProject2
{
    partial class Form3
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
       #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form3_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Form3_stu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.form3_insert = new System.Windows.Forms.Button();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Form3_class);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Form3_stu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 228);
            this.panel1.TabIndex = 0;
            // 
            // Form3_class
            // 
            this.Form3_class.Location = new System.Drawing.Point(99, 111);
            this.Form3_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_class.Name = "Form3_class";
            this.Form3_class.Size = new System.Drawing.Size(159, 25);
            this.Form3_class.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "강 의 번 호";
            // 
            // Form3_stu
            // 
            this.Form3_stu.Location = new System.Drawing.Point(99, 80);
            this.Form3_stu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_stu.Name = "Form3_stu";
            this.Form3_stu.Size = new System.Drawing.Size(159, 25);
            this.Form3_stu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "학 생 번 호";
            // 
            // form3_insert
            // 
            this.form3_insert.Font = new System.Drawing.Font("굴림", 30F);
            this.form3_insert.Location = new System.Drawing.Point(370, 49);
            this.form3_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form3_insert.Name = "form3_insert";
            this.form3_insert.Size = new System.Drawing.Size(280, 114);
            this.form3_insert.TabIndex = 2;
            this.form3_insert.Text = "수강신청";
            this.form3_insert.UseVisualStyleBackColor = true;
            this.form3_insert.Click += new System.EventHandler(this.form3_insert_Click);
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Font = new System.Drawing.Font("굴림", 40F);
            this.Clear_Btn.Location = new System.Drawing.Point(370, 168);
            this.Clear_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(280, 114);
            this.Clear_Btn.TabIndex = 6;
            this.Clear_Btn.Text = "초기화";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(280, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "수강 신청";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.form3_insert);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Form3_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Form3_stu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button form3_insert;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.Label label6;

        #endregion
    }
}