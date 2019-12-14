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
    public partial class Form3 : Form
    {
        private string reg_class;
        int selectedRowIndex;

        Form1 main_form;

        public Form3(int selectedRowIndex, string v1)
        {
            InitializeComponent();

            this.selectedRowIndex = selectedRowIndex;
            this.reg_class = v1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form3_class.Text = reg_class;

            if (Owner != null)
            {
                main_form = Owner as Form1;
            }
        }

        private void form3_insert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form3_stu.Text,
                Form3_class.Text};
            main_form.InsertRow(rowDatas);
            this.Close();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            Form3_class.Clear();
            Form3_stu.Clear();
        }
    }
}
