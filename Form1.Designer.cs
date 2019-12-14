using System;

namespace WinFormDBProject2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbClass = new System.Windows.Forms.RadioButton();
            this.rbRegister = new System.Windows.Forms.RadioButton();
            this.lable1 = new System.Windows.Forms.Label();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.tbregStuName = new System.Windows.Forms.TextBox();
            this.lbregstuName = new System.Windows.Forms.Label();
            this.tbregClassName = new System.Windows.Forms.TextBox();
            this.lbregName = new System.Windows.Forms.Label();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.form1_all = new System.Windows.Forms.RadioButton();
            this.form1_woman = new System.Windows.Forms.RadioButton();
            this.form1_man = new System.Windows.Forms.RadioButton();
            this.tbstuGrade = new System.Windows.Forms.ComboBox();
            this.lbstuDept = new System.Windows.Forms.Label();
            this.tbstuDept = new System.Windows.Forms.TextBox();
            this.tbstuName = new System.Windows.Forms.TextBox();
            this.lbstuGrade = new System.Windows.Forms.Label();
            this.lbstuSex = new System.Windows.Forms.Label();
            this.lbstuName = new System.Windows.Forms.Label();
            this.tbstuId = new System.Windows.Forms.TextBox();
            this.lbstuID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbclassComp = new System.Windows.Forms.Label();
            this.tbclassComp = new System.Windows.Forms.TextBox();
            this.tbclassday = new System.Windows.Forms.TextBox();
            this.tbclassName = new System.Windows.Forms.TextBox();
            this.lbclassDay = new System.Windows.Forms.Label();
            this.lbclassName = new System.Windows.Forms.Label();
            this.tbclassId = new System.Windows.Forms.TextBox();
            this.lbclassID = new System.Windows.Forms.Label();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.class_delete = new System.Windows.Forms.Button();
            this.trick = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btntxt = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbRegister.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 304);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(949, 444);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 174);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(291, 32);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "학생 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(527, 250);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(291, 32);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(527, 99);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(291, 32);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "찾기";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(527, 136);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(291, 32);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "학생 추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbStudent.Location = new System.Drawing.Point(851, 192);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(112, 23);
            this.rbStudent.TabIndex = 19;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "학생 정보";
            this.rbStudent.UseVisualStyleBackColor = true;
            this.rbStudent.CheckedChanged += new System.EventHandler(this.RbStudent_CheckedChanged);
            // 
            // rbClass
            // 
            this.rbClass.AutoSize = true;
            this.rbClass.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbClass.Location = new System.Drawing.Point(851, 225);
            this.rbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbClass.Name = "rbClass";
            this.rbClass.Size = new System.Drawing.Size(112, 23);
            this.rbClass.TabIndex = 20;
            this.rbClass.TabStop = true;
            this.rbClass.Text = "강의 정보";
            this.rbClass.UseVisualStyleBackColor = true;
            this.rbClass.CheckedChanged += new System.EventHandler(this.RbClass_CheckedChanged);
            // 
            // rbRegister
            // 
            this.rbRegister.AutoSize = true;
            this.rbRegister.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbRegister.Location = new System.Drawing.Point(851, 258);
            this.rbRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRegister.Name = "rbRegister";
            this.rbRegister.Size = new System.Drawing.Size(112, 23);
            this.rbRegister.TabIndex = 21;
            this.rbRegister.TabStop = true;
            this.rbRegister.Text = "수강 신청";
            this.rbRegister.UseVisualStyleBackColor = true;
            this.rbRegister.CheckedChanged += new System.EventHandler(this.RbRegister_CheckedChanged);
            // 
            // lable1
            // 
            this.lable1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lable1.Font = new System.Drawing.Font("굴림", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lable1.Location = new System.Drawing.Point(294, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(434, 54);
            this.lable1.TabIndex = 26;
            this.lable1.Text = "2020 수강신청";
            this.lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.tbregStuName);
            this.gbRegister.Controls.Add(this.lbregstuName);
            this.gbRegister.Controls.Add(this.tbregClassName);
            this.gbRegister.Controls.Add(this.lbregName);
            this.gbRegister.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbRegister.Location = new System.Drawing.Point(64, 82);
            this.gbRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRegister.Size = new System.Drawing.Size(432, 205);
            this.gbRegister.TabIndex = 28;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "수강 신청";
            // 
            // tbregStuName
            // 
            this.tbregStuName.Location = new System.Drawing.Point(143, 68);
            this.tbregStuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbregStuName.Multiline = true;
            this.tbregStuName.Name = "tbregStuName";
            this.tbregStuName.Size = new System.Drawing.Size(271, 29);
            this.tbregStuName.TabIndex = 15;
            // 
            // lbregstuName
            // 
            this.lbregstuName.AutoSize = true;
            this.lbregstuName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbregstuName.Location = new System.Drawing.Point(37, 70);
            this.lbregstuName.Name = "lbregstuName";
            this.lbregstuName.Size = new System.Drawing.Size(101, 20);
            this.lbregstuName.TabIndex = 11;
            this.lbregstuName.Text = "학생 번호";
            this.lbregstuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbregClassName
            // 
            this.tbregClassName.Location = new System.Drawing.Point(143, 31);
            this.tbregClassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbregClassName.Multiline = true;
            this.tbregClassName.Name = "tbregClassName";
            this.tbregClassName.Size = new System.Drawing.Size(271, 29);
            this.tbregClassName.TabIndex = 10;
            // 
            // lbregName
            // 
            this.lbregName.AutoSize = true;
            this.lbregName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbregName.Location = new System.Drawing.Point(37, 34);
            this.lbregName.Name = "lbregName";
            this.lbregName.Size = new System.Drawing.Size(101, 20);
            this.lbregName.TabIndex = 9;
            this.lbregName.Text = "강의 번호";
            this.lbregName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.Controls.Add(this.form1_all);
            this.gbStudent.Controls.Add(this.form1_woman);
            this.gbStudent.Controls.Add(this.form1_man);
            this.gbStudent.Controls.Add(this.tbstuGrade);
            this.gbStudent.Controls.Add(this.lbstuDept);
            this.gbStudent.Controls.Add(this.tbstuDept);
            this.gbStudent.Controls.Add(this.tbstuName);
            this.gbStudent.Controls.Add(this.lbstuGrade);
            this.gbStudent.Controls.Add(this.lbstuSex);
            this.gbStudent.Controls.Add(this.lbstuName);
            this.gbStudent.Controls.Add(this.tbstuId);
            this.gbStudent.Controls.Add(this.lbstuID);
            this.gbStudent.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbStudent.Location = new System.Drawing.Point(70, 79);
            this.gbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStudent.Size = new System.Drawing.Size(432, 221);
            this.gbStudent.TabIndex = 25;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "학생 정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(140, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "# 학과는 학과번호로 입력";
            // 
            // form1_all
            // 
            this.form1_all.AutoSize = true;
            this.form1_all.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.form1_all.Location = new System.Drawing.Point(143, 138);
            this.form1_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_all.Name = "form1_all";
            this.form1_all.Size = new System.Drawing.Size(68, 23);
            this.form1_all.TabIndex = 30;
            this.form1_all.TabStop = true;
            this.form1_all.Text = "모두";
            this.form1_all.UseVisualStyleBackColor = true;
            // 
            // form1_woman
            // 
            this.form1_woman.AutoSize = true;
            this.form1_woman.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.form1_woman.Location = new System.Drawing.Point(369, 138);
            this.form1_woman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_woman.Name = "form1_woman";
            this.form1_woman.Size = new System.Drawing.Size(49, 23);
            this.form1_woman.TabIndex = 29;
            this.form1_woman.TabStop = true;
            this.form1_woman.Text = "여";
            this.form1_woman.UseVisualStyleBackColor = true;
            // 
            // form1_man
            // 
            this.form1_man.AutoSize = true;
            this.form1_man.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.form1_man.Location = new System.Drawing.Point(255, 138);
            this.form1_man.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_man.Name = "form1_man";
            this.form1_man.Size = new System.Drawing.Size(49, 23);
            this.form1_man.TabIndex = 22;
            this.form1_man.TabStop = true;
            this.form1_man.Text = "남";
            this.form1_man.UseVisualStyleBackColor = true;
            // 
            // tbstuGrade
            // 
            this.tbstuGrade.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbstuGrade.FormattingEnabled = true;
            this.tbstuGrade.Location = new System.Drawing.Point(143, 99);
            this.tbstuGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbstuGrade.Name = "tbstuGrade";
            this.tbstuGrade.Size = new System.Drawing.Size(271, 28);
            this.tbstuGrade.TabIndex = 21;
            // 
            // lbstuDept
            // 
            this.lbstuDept.AutoSize = true;
            this.lbstuDept.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbstuDept.Location = new System.Drawing.Point(43, 176);
            this.lbstuDept.Name = "lbstuDept";
            this.lbstuDept.Size = new System.Drawing.Size(83, 20);
            this.lbstuDept.TabIndex = 19;
            this.lbstuDept.Text = "학    과";
            this.lbstuDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbstuDept
            // 
            this.tbstuDept.Location = new System.Drawing.Point(143, 172);
            this.tbstuDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbstuDept.Multiline = true;
            this.tbstuDept.Name = "tbstuDept";
            this.tbstuDept.Size = new System.Drawing.Size(271, 29);
            this.tbstuDept.TabIndex = 18;
            // 
            // tbstuName
            // 
            this.tbstuName.Location = new System.Drawing.Point(143, 62);
            this.tbstuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbstuName.Multiline = true;
            this.tbstuName.Name = "tbstuName";
            this.tbstuName.Size = new System.Drawing.Size(271, 29);
            this.tbstuName.TabIndex = 15;
            // 
            // lbstuGrade
            // 
            this.lbstuGrade.AutoSize = true;
            this.lbstuGrade.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbstuGrade.Location = new System.Drawing.Point(43, 102);
            this.lbstuGrade.Name = "lbstuGrade";
            this.lbstuGrade.Size = new System.Drawing.Size(83, 20);
            this.lbstuGrade.TabIndex = 14;
            this.lbstuGrade.Text = "학    년";
            this.lbstuGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbstuSex
            // 
            this.lbstuSex.AutoSize = true;
            this.lbstuSex.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbstuSex.Location = new System.Drawing.Point(43, 138);
            this.lbstuSex.Name = "lbstuSex";
            this.lbstuSex.Size = new System.Drawing.Size(83, 20);
            this.lbstuSex.TabIndex = 13;
            this.lbstuSex.Text = "성    별";
            this.lbstuSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbstuName
            // 
            this.lbstuName.AutoSize = true;
            this.lbstuName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbstuName.Location = new System.Drawing.Point(43, 65);
            this.lbstuName.Name = "lbstuName";
            this.lbstuName.Size = new System.Drawing.Size(83, 20);
            this.lbstuName.TabIndex = 11;
            this.lbstuName.Text = "이    름";
            this.lbstuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbstuId
            // 
            this.tbstuId.Location = new System.Drawing.Point(143, 26);
            this.tbstuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbstuId.Multiline = true;
            this.tbstuId.Name = "tbstuId";
            this.tbstuId.Size = new System.Drawing.Size(271, 29);
            this.tbstuId.TabIndex = 10;
            // 
            // lbstuID
            // 
            this.lbstuID.AutoSize = true;
            this.lbstuID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbstuID.Location = new System.Drawing.Point(43, 29);
            this.lbstuID.Name = "lbstuID";
            this.lbstuID.Size = new System.Drawing.Size(83, 20);
            this.lbstuID.TabIndex = 9;
            this.lbstuID.Text = "번    호";
            this.lbstuID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbclassComp);
            this.panel1.Controls.Add(this.tbclassComp);
            this.panel1.Controls.Add(this.tbclassday);
            this.panel1.Controls.Add(this.tbclassName);
            this.panel1.Controls.Add(this.lbclassDay);
            this.panel1.Controls.Add(this.lbclassName);
            this.panel1.Controls.Add(this.tbclassId);
            this.panel1.Controls.Add(this.lbclassID);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 148);
            this.panel1.TabIndex = 21;
            // 
            // lbclassComp
            // 
            this.lbclassComp.AutoSize = true;
            this.lbclassComp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbclassComp.Location = new System.Drawing.Point(2, 110);
            this.lbclassComp.Name = "lbclassComp";
            this.lbclassComp.Size = new System.Drawing.Size(101, 20);
            this.lbclassComp.TabIndex = 19;
            this.lbclassComp.Text = "이수 구분";
            this.lbclassComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbclassComp
            // 
            this.tbclassComp.Location = new System.Drawing.Point(109, 108);
            this.tbclassComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbclassComp.Multiline = true;
            this.tbclassComp.Name = "tbclassComp";
            this.tbclassComp.Size = new System.Drawing.Size(271, 29);
            this.tbclassComp.TabIndex = 18;
            // 
            // tbclassday
            // 
            this.tbclassday.Location = new System.Drawing.Point(109, 72);
            this.tbclassday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbclassday.Multiline = true;
            this.tbclassday.Name = "tbclassday";
            this.tbclassday.Size = new System.Drawing.Size(271, 29);
            this.tbclassday.TabIndex = 16;
            // 
            // tbclassName
            // 
            this.tbclassName.Location = new System.Drawing.Point(109, 36);
            this.tbclassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbclassName.Multiline = true;
            this.tbclassName.Name = "tbclassName";
            this.tbclassName.Size = new System.Drawing.Size(271, 29);
            this.tbclassName.TabIndex = 15;
            // 
            // lbclassDay
            // 
            this.lbclassDay.AutoSize = true;
            this.lbclassDay.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbclassDay.Location = new System.Drawing.Point(2, 76);
            this.lbclassDay.Name = "lbclassDay";
            this.lbclassDay.Size = new System.Drawing.Size(101, 20);
            this.lbclassDay.TabIndex = 14;
            this.lbclassDay.Text = "수강 날짜";
            this.lbclassDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbclassName
            // 
            this.lbclassName.AutoSize = true;
            this.lbclassName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbclassName.Location = new System.Drawing.Point(11, 39);
            this.lbclassName.Name = "lbclassName";
            this.lbclassName.Size = new System.Drawing.Size(83, 20);
            this.lbclassName.TabIndex = 11;
            this.lbclassName.Text = "이    름";
            this.lbclassName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbclassId
            // 
            this.tbclassId.Location = new System.Drawing.Point(109, 0);
            this.tbclassId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbclassId.Multiline = true;
            this.tbclassId.Name = "tbclassId";
            this.tbclassId.Size = new System.Drawing.Size(271, 29);
            this.tbclassId.TabIndex = 10;
            // 
            // lbclassID
            // 
            this.lbclassID.AutoSize = true;
            this.lbclassID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbclassID.Location = new System.Drawing.Point(5, 7);
            this.lbclassID.Name = "lbclassID";
            this.lbclassID.Size = new System.Drawing.Size(101, 20);
            this.lbclassID.TabIndex = 9;
            this.lbclassID.Text = "강의 번호";
            this.lbclassID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.panel1);
            this.gbClass.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbClass.Location = new System.Drawing.Point(70, 86);
            this.gbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClass.Name = "gbClass";
            this.gbClass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClass.Size = new System.Drawing.Size(432, 205);
            this.gbClass.TabIndex = 27;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "강의 정보";
            // 
            // class_delete
            // 
            this.class_delete.Location = new System.Drawing.Point(527, 212);
            this.class_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.class_delete.Name = "class_delete";
            this.class_delete.Size = new System.Drawing.Size(291, 32);
            this.class_delete.TabIndex = 29;
            this.class_delete.Text = "강의 삭제";
            this.class_delete.UseVisualStyleBackColor = true;
            this.class_delete.Click += new System.EventHandler(this.class_delete_Click);
            // 
            // trick
            // 
            this.trick.Location = new System.Drawing.Point(888, 304);
            this.trick.Name = "trick";
            this.trick.Size = new System.Drawing.Size(100, 25);
            this.trick.TabIndex = 30;
            // 
            // btntxt
            // 
            this.btntxt.Location = new System.Drawing.Point(851, 99);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(133, 35);
            this.btntxt.TabIndex = 31;
            this.btntxt.Text = "txt로 저장";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.Btntxt_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(851, 148);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(133, 35);
            this.btnexcel.TabIndex = 32;
            this.btnexcel.Text = "excel로 저장";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.Btnexcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 792);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.trick);
            this.Controls.Add(this.class_delete);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.gbClass);
            this.Controls.Add(this.rbRegister);
            this.Controls.Add(this.rbClass);
            this.Controls.Add(this.rbStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "전북대학교 수강신청 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbClass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbClass;
        private System.Windows.Forms.RadioButton rbRegister;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.TextBox tbregStuName;
        private System.Windows.Forms.Label lbregstuName;
        private System.Windows.Forms.TextBox tbregClassName;
        private System.Windows.Forms.Label lbregName;
        private System.Windows.Forms.Label lbstuID;
        private System.Windows.Forms.TextBox tbstuId;
        private System.Windows.Forms.Label lbstuName;
        private System.Windows.Forms.Label lbstuSex;
        private System.Windows.Forms.Label lbstuGrade;
        private System.Windows.Forms.TextBox tbstuName;
        private System.Windows.Forms.TextBox tbstuDept;
        private System.Windows.Forms.Label lbstuDept;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbclassComp;
        private System.Windows.Forms.TextBox tbclassComp;
        private System.Windows.Forms.TextBox tbclassday;
        private System.Windows.Forms.TextBox tbclassName;
        private System.Windows.Forms.Label lbclassDay;
        private System.Windows.Forms.Label lbclassName;
        private System.Windows.Forms.TextBox tbclassId;
        private System.Windows.Forms.Label lbclassID;
        private System.Windows.Forms.ComboBox tbstuGrade;
        private System.Windows.Forms.RadioButton form1_man;
        private System.Windows.Forms.RadioButton form1_woman;
        private System.Windows.Forms.RadioButton form1_all;
        private System.Windows.Forms.Button class_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trick;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btnexcel;
    }
}

