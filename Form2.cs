using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDBProject2
{
    public partial class Form2 : Form
    {
        private string stu_Id;
        private string stu_Name;
        private string stu_Grade;
        private string dept_Id;
        private int selectedRowIndex;

        Form1 main_form;

        public Form2(int selectedRowIndex, string v1, string v2, string v3, string v4)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.stu_Id = v1;
            this.stu_Name = v2;
            this.stu_Grade = v3;
            this.dept_Id = v4;
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form2_Id.Text,
                Form2_Name.Text,
                Form2_Grade.Text,
                Form2_Dept.Text};
            main_form.UpdateRow(rowDatas);
            this.Close();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            Form2_Id.Clear();
            Form2_Name.Clear();
            Form2_Grade.Clear();
            Form2_Dept.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2_Id.Text = stu_Id;
            Form2_Name.Text = stu_Name;
            Form2_Grade.Text = stu_Grade;
            Form2_Dept.Text = dept_Id;

            if (Owner != null)
            {
                main_form = Owner as Form1;
            }
        }
    }
}
