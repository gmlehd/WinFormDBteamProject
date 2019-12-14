namespace WinFormDBProject2
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.form2_woman = new System.Windows.Forms.RadioButton();
            this.form2_man = new System.Windows.Forms.RadioButton();
            this.Form2_Dept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Form2_Grade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Form2_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Form2_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.form2_woman);
            this.panel1.Controls.Add(this.form2_man);
            this.panel1.Controls.Add(this.Form2_Dept);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Form2_Grade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Form2_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Form2_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 228);
            this.panel1.TabIndex = 0;
            // 
            // form2_woman
            // 
            this.form2_woman.AutoSize = true;
            this.form2_woman.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.form2_woman.Location = new System.Drawing.Point(214, 128);
            this.form2_woman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form2_woman.Name = "form2_woman";
            this.form2_woman.Size = new System.Drawing.Size(49, 23);
            this.form2_woman.TabIndex = 21;
            this.form2_woman.TabStop = true;
            this.form2_woman.Text = "여";
            this.form2_woman.UseVisualStyleBackColor = true;
            // 
            // form2_man
            // 
            this.form2_man.AutoSize = true;
            this.form2_man.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.form2_man.Location = new System.Drawing.Point(99, 128);
            this.form2_man.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form2_man.Name = "form2_man";
            this.form2_man.Size = new System.Drawing.Size(49, 23);
            this.form2_man.TabIndex = 20;
            this.form2_man.TabStop = true;
            this.form2_man.Text = "남";
            this.form2_man.UseVisualStyleBackColor = true;
            // 
            // Form2_Dept
            // 
            this.Form2_Dept.Location = new System.Drawing.Point(99, 158);
            this.Form2_Dept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form2_Dept.Name = "Form2_Dept";
            this.Form2_Dept.Size = new System.Drawing.Size(159, 25);
            this.Form2_Dept.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "학 과";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "성 별";
            // 
            // Form2_Grade
            // 
            this.Form2_Grade.Location = new System.Drawing.Point(99, 96);
            this.Form2_Grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form2_Grade.Name = "Form2_Grade";
            this.Form2_Grade.Size = new System.Drawing.Size(159, 25);
            this.Form2_Grade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "학 년";
            // 
            // Form2_Name
            // 
            this.Form2_Name.Location = new System.Drawing.Point(99, 65);
            this.Form2_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form2_Name.Name = "Form2_Name";
            this.Form2_Name.Size = new System.Drawing.Size(159, 25);
            this.Form2_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "이 름";
            // 
            // Form2_Id
            // 
            this.Form2_Id.Location = new System.Drawing.Point(99, 34);
            this.Form2_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form2_Id.Name = "Form2_Id";
            this.Form2_Id.Size = new System.Drawing.Size(159, 25);
            this.Form2_Id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "번 호";
            // 
            // Update_Btn
            // 
            this.Update_Btn.Font = new System.Drawing.Font("굴림", 40F);
            this.Update_Btn.Location = new System.Drawing.Point(370, 49);
            this.Update_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(280, 114);
            this.Update_Btn.TabIndex = 2;
            this.Update_Btn.Text = "수정";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
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
            this.label6.Text = "학생 수정";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Form2_Dept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Form2_Grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Form2_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Form2_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton form2_man;
        private System.Windows.Forms.RadioButton form2_woman;
    }
}