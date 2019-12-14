using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormDBProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapterS;
        MySqlDataAdapter dataAdapterC;
        MySqlDataAdapter dataAdapterR;
        DataSet dataSet;
        int selectedRowIndex;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=class_registrationwinform;uid=root;pwd=020402; allow user variables=true");
            dataAdapterS = new MySqlDataAdapter("SELECT * FROM student_info", conn);
            dataAdapterC = new MySqlDataAdapter("SELECT * FROM class_info", conn);
            dataAdapterR = new MySqlDataAdapter("SELECT * FROM class_reg", conn);

            dataSet = new DataSet();

            dataAdapterS.Fill(dataSet, "student_info");
            dataGridView1.DataSource = dataSet.Tables["student_info"];

            stu_ComboBox();
        }

        #region Table Select
        private void RbStudent_CheckedChanged(object sender, EventArgs e)
        {
            dataSet = new DataSet();

            dataAdapterS.Fill(dataSet, "student_info");
            dataGridView1.DataSource = dataSet.Tables["student_info"];

            gbStudent.Visible = true;
            gbClass.Visible = false;
            gbRegister.Visible = false;
        }

        private void RbClass_CheckedChanged(object sender, EventArgs e)
        {
            dataSet = new DataSet();

            dataAdapterC.Fill(dataSet, "class_info");
            dataGridView1.DataSource = dataSet.Tables["class_info"];

            gbStudent.Visible = false;
            gbClass.Visible = true;
            gbRegister.Visible = false;
        }

        private void RbRegister_CheckedChanged(object sender, EventArgs e)
        {
            dataAdapterR = new MySqlDataAdapter("SELECT * FROM class_reg", conn);
            dataSet = new DataSet();

            dataAdapterR.Fill(dataSet, "class_reg");
            dataGridView1.DataSource = dataSet.Tables["class_reg"];

            gbStudent.Visible = false;
            gbClass.Visible = false;
            gbRegister.Visible = true;
        }


        #endregion

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                #region student_info Table Select
                string queryStr;
                string[] conditions = new string[6];
                conditions[0] = (tbstuId.Text != "") ? "stu_id=@stu_id" : null;
                conditions[1] = (tbstuName.Text != "") ? "stu_name=@stu_name" : null;
                conditions[2] = (tbstuGrade.Text != "") ? "stu_grade=@stu_grade" : null;
                if (form1_all.Checked)
                {
                    trick.Clear();
                    conditions[3] = (trick.Text != "") ? "stu_sex=@stu_sex" : null;
                }
                else if (form1_man.Checked)
                    conditions[3] = form1_man.Checked ? "stu_sex=@stu_sex" : null;
                else
                    conditions[3] = form1_woman.Checked ? "stu_sex=@stu_sex" : null;
                conditions[4] = (tbstuDept.Text != "") ? "dept_id=@dept_id" : null;


                if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)  //만약 데이터가 다 들어있으면
                {
                    queryStr = $"SELECT * FROM student_info WHERE ";
                    bool firstCondition = true;    //firstCondition을 true로 해두고
                    for (int i = 0; i < conditions.Length; i++)  //conditions의 길이(5)만큼 for문을 돌려서
                    {
                        if (conditions[i] != null)
                            if (firstCondition)
                            {
                                queryStr += conditions[i];
                                firstCondition = false;
                            }
                            else
                            {
                                queryStr += " and " + conditions[i];
                            }
                    }
                }
                else
                {
                    queryStr = "SELECT * FROM student_info";
                }
                #region SelectCommand 객체 생성 및 Parameters 설정
                dataAdapterS.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapterS.SelectCommand.Parameters.AddWithValue("@stu_id", tbstuId.Text);
                dataAdapterS.SelectCommand.Parameters.AddWithValue("@stu_name", tbstuName.Text);
                dataAdapterS.SelectCommand.Parameters.AddWithValue("@stu_grade", tbstuGrade.Text);
                if (form1_all.Checked)
                    dataAdapterS.SelectCommand.Parameters.AddWithValue("@stu_sex", trick.Text);
                else if (form1_man.Checked)
                    dataAdapterS.SelectCommand.Parameters.AddWithValue("@stu_sex", "남");
                else
                    dataAdapterS.SelectCommand.Parameters.AddWithValue("@stu_sex", "여");

                dataAdapterS.SelectCommand.Parameters.AddWithValue("@dept_id", tbstuDept.Text);
                #endregion

                try
                {
                    conn.Open();
                    dataSet.Clear();
                    if (dataAdapterS.Fill(dataSet, "student_info") > 0)
                        dataGridView1.DataSource = dataSet.Tables["student_info"];
                    else
                        MessageBox.Show("찾는 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else if (rbClass.Checked)
            {
                #region class_info Table select
                string queryStr;
                string[] conditions = new string[8];
                conditions[0] = (tbclassId.Text != "") ? "class_id=@class_id" : null;
                conditions[1] = (tbclassName.Text != "") ? "class_name=@class_name" : null;
                conditions[2] = (tbclassday.Text != "") ? "class_day=@class_day" : null;
                conditions[3] = (tbclassComp.Text != "") ? "class_comp=@class_comp" : null;


                if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null || conditions[5] != null || conditions[6] != null)  //만약 데이터가 다 들어있으면
                {
                    queryStr = $"SELECT * FROM class_info WHERE ";
                    bool firstCondition = true;    //firstCondition을 true로 해두고
                    for (int i = 0; i < conditions.Length; i++)  //conditions의 길이(5)만큼 for문을 돌려서
                    {
                        if (conditions[i] != null)
                            if (firstCondition)
                            {
                                queryStr += conditions[i];
                                firstCondition = false;
                            }
                            else
                            {
                                queryStr += " and " + conditions[i];
                            }
                    }
                }
                else
                {
                    queryStr = "SELECT * FROM class_info";
                }
                #region SelectCommand 객체 생성 및 Parameters 설정
                dataAdapterC.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapterC.SelectCommand.Parameters.AddWithValue("@class_id", tbclassId.Text);
                dataAdapterC.SelectCommand.Parameters.AddWithValue("@class_name", tbclassName.Text);
                dataAdapterC.SelectCommand.Parameters.AddWithValue("@class_time_start", tbclassday.Text);
                dataAdapterC.SelectCommand.Parameters.AddWithValue("@class_comp", tbclassComp.Text);
                #endregion

                try
                {
                    conn.Open();
                    dataSet.Clear();
                    if (dataAdapterC.Fill(dataSet, "class_info") > 0)
                        dataGridView1.DataSource = dataSet.Tables["class_info"];
                    else
                        MessageBox.Show("찾는 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else
            {
                #region class_reg Table Select
                string queryStr;
                string[] conditions = new string[3];
                conditions[0] = (tbregStuName.Text != "") ? "stu_id=@stu_id" : null;
                conditions[1] = (tbregClassName.Text != "") ? "class_id=@class_id" : null;

                if (conditions[0] != null || conditions[1] != null)  //만약 데이터가 다 들어있으면
                {
                    queryStr = $"SELECT * FROM class_reg WHERE ";
                    bool firstCondition = true;    //firstCondition을 true로 해두고
                    for (int i = 0; i < conditions.Length; i++)  //conditions의 길이(6)만큼 for문을 돌려서
                    {
                        if (conditions[i] != null)
                            if (firstCondition)
                            {
                                queryStr += conditions[i];
                                firstCondition = false;
                            }
                            else
                            {
                                queryStr += " and " + conditions[i];
                            }
                    }
                }
                else
                {
                    queryStr = "SELECT * FROM class_reg";
                }
                #region SelectCommand 객체 생성 및 Parameters 설정
                dataAdapterR.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapterR.SelectCommand.Parameters.AddWithValue("@stu_id", tbregStuName.Text);
                dataAdapterR.SelectCommand.Parameters.AddWithValue("@class_id", tbregClassName.Text);
                #endregion

                try
                {
                    conn.Open();
                    dataSet.Clear();
                    if (dataAdapterR.Fill(dataSet, "class_reg") > 0)
                        dataGridView1.DataSource = dataSet.Tables["class_reg"];
                    else
                        MessageBox.Show("찾는 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                #region student_info Table insert
                string[] rowDatas = {
                    tbstuId.Text,
                    tbstuName.Text,
                    tbstuGrade.Text,
                    tbstuDept.Text
                };

                string queryStr = "INSERT INTO student_info (stu_Id, stu_Name, stu_Grade, stu_Sex, dept_id) " +
                    "VALUES(@stu_Id, @stu_Name, @stu_Grade, @stu_Sex, @dept_id)";
                dataAdapterS.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapterS.InsertCommand.Parameters.Add("@stu_Id", MySqlDbType.Int32);
                dataAdapterS.InsertCommand.Parameters.Add("@stu_Name", MySqlDbType.VarChar);
                dataAdapterS.InsertCommand.Parameters.Add("@stu_Grade", MySqlDbType.VarChar);
                dataAdapterS.InsertCommand.Parameters.Add("@stu_Sex", MySqlDbType.VarChar);
                dataAdapterS.InsertCommand.Parameters.Add("@dept_id", MySqlDbType.Int32);

                //Parameter를 이용한 처리
                dataAdapterS.InsertCommand.Parameters["@stu_Id"].Value = rowDatas[0];
                dataAdapterS.InsertCommand.Parameters["@stu_Name"].Value = rowDatas[1];
                dataAdapterS.InsertCommand.Parameters["@stu_Grade"].Value = rowDatas[2];
                if (form1_man.Checked)
                    dataAdapterS.InsertCommand.Parameters["@stu_Sex"].Value = "남";
                else
                    dataAdapterS.InsertCommand.Parameters["@stu_Sex"].Value = "여";

                dataAdapterS.InsertCommand.Parameters["@dept_id"].Value = rowDatas[3];

                try
                {
                    conn.Open();
                    dataAdapterS.InsertCommand.ExecuteNonQuery();

                    dataSet.Clear();                                        // Clear로 이전 데이터 지우기
                    dataAdapterS.Fill(dataSet, "student_info");
                    dataGridView1.DataSource = dataSet.Tables["student_info"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                #region student_info Table delete
                int id;
                string sql = "DELETE FROM student_info WHERE stu_id=@stu_id";
                dataAdapterS.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapterS.DeleteCommand.Parameters.Add("@stu_id", MySqlDbType.Int32);
                id = (int)dataGridView1.SelectedRows[0].Cells["stu_id"].Value;
                dataAdapterS.DeleteCommand.Parameters["@stu_id"].Value = id;

                try
                {
                    conn.Open();
                    dataAdapterS.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapterS.Fill(dataSet, "stu_id");
                    dataGridView1.DataSource = dataSet.Tables["stu_id"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
        }


        #region 함수
        private void stu_ComboBox()
        {
            string sql1 = "SELECT distinct stu_grade FROM student_info";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    tbstuGrade.Items.Add(reader.GetString("stu_grade"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        internal void UpdateRow(string[] rowDatas)
        {
            string sql = "UPDATE student_info SET stu_id=@stu_id, stu_name=@stu_name, stu_grade=@stu_grade, dept_id=@dept_id WHERE stu_Id=@stu_Id";
            dataAdapterS.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapterS.UpdateCommand.Parameters.AddWithValue("@stu_id", rowDatas[0]);
            dataAdapterS.UpdateCommand.Parameters.AddWithValue("@stu_name", rowDatas[1]);
            dataAdapterS.UpdateCommand.Parameters.AddWithValue("@stu_grade", rowDatas[2]);
            dataAdapterS.UpdateCommand.Parameters.AddWithValue("@dept_id", rowDatas[3]);

            try
            {
                conn.Open();
                dataAdapterS.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapterS.Fill(dataSet, "student_info");
                dataGridView1.DataSource = dataSet.Tables["student_info"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO class_reg (stu_id, class_id) " +
                    "VALUES(@stu_id, @class_id)";
            dataAdapterR.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapterR.InsertCommand.Parameters.Add("@stu_id", MySqlDbType.Int32);
            dataAdapterR.InsertCommand.Parameters.Add("@class_id", MySqlDbType.Int32);

            dataAdapterR.InsertCommand.Parameters["@stu_id"].Value = rowDatas[0];
            dataAdapterR.InsertCommand.Parameters["@class_id"].Value = rowDatas[1];

            try
            {
                conn.Open();
                dataAdapterR.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapterR.Fill(dataSet, "class_reg");
                dataGridView1.DataSource = dataSet.Tables["class_reg"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 초기화
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbstuId.Clear();
            tbstuName.Clear();
            tbstuGrade.Text = "";
            tbstuDept.Clear();
            tbclassId.Clear();
            tbclassName.Clear();
            tbclassday.Clear();
            tbclassComp.Clear();
            tbregClassName.Clear();
            tbregStuName.Clear();
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbStudent.Checked)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

                Form2 Dig = new Form2(
                    selectedRowIndex,
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[4].Value.ToString()
                    );

                Dig.Owner = this;
                Dig.ShowDialog();
                Dig.Dispose();
            }
            if (rbClass.Checked)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

                Form3 Dig = new Form3(
                    selectedRowIndex,
                    row.Cells[0].Value.ToString()
                    );

                Dig.Owner = this;
                Dig.ShowDialog();
                Dig.Dispose();
            }
        }

        private void class_delete_Click(object sender, EventArgs e)
        {
            if (rbRegister.Checked)
            {
                #region class_reg Table delete
                int id;
                string sql = "DELETE FROM class_reg WHERE class_id=@class_id";
                dataAdapterR.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapterR.DeleteCommand.Parameters.Add("@class_id", MySqlDbType.Int32);
                id = (int)dataGridView1.SelectedRows[0].Cells["class_id"].Value;
                dataAdapterR.DeleteCommand.Parameters["@class_id"].Value = id;

                try
                {
                    conn.Open();
                    dataAdapterR.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapterR.Fill(dataSet, "class_id");
                    dataGridView1.DataSource = dataSet.Tables["class_id"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
        }

        void SaveTxtFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Columns 이름들을 저장(한 줄)
                foreach (DataColumn col in dataSet.Tables["class_reg"].Columns)
                {
                    sw.Write($"{col.ColumnName}\t");
                }
                sw.WriteLine();

                // Rows 데이터들을 저장
                foreach (DataRow row in dataSet.Tables["class_reg"].Rows)
                {
                    string rowString = "";
                    foreach (var item in row.ItemArray)
                    {
                        rowString += $"{item}\t"; // 각 열의 데이터를 스트링 변수에 저장
                    }
                    sw.WriteLine(rowString);
                }
            }
        }

        private void Btntxt_Click(object sender, EventArgs e)
        {
            // dataGridView1에 데이터가 있는지 체크
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("저장할 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveTxtFile(saveFileDialog1.FileName);
            }
        }

        private void SaveExcelFile(string filePath)
        {
            // 1. 엑셀 사용에 필요한 객체 준비
            Excel.Application eApp; // 엑셀 프로그램
            Excel.Workbook eWorkbook;  // 엑셀 워크북(시트 여러 개 포함)
            Excel.Worksheet eWorkSheet; // 엑셀 워크 시트

            eApp = new Excel.Application();
            eWorkbook = eApp.Workbooks.Add();  // 엑셀 프로그램 객체에 포함시킴
            eWorkSheet = eWorkbook.Sheets[1];  // 엑셀 워크시트는 index가 1부터 시작됨

            // 2. 엑셀에 저장할 데이터를 2차원 스트링 배열로 준비
            int colCount = dataSet.Tables["class_reg"].Columns.Count;
            int rowCount = dataSet.Tables["class_reg"].Rows.Count + 1;
            string[,] dataArr = new string[rowCount, colCount];  // 검색 결과를 저장할 배열

            // 2-1. Column 이름 저장
            for (int i = 0; i < dataSet.Tables["class_reg"].Columns.Count; i++)
            {
                dataArr[0, i] = dataSet.Tables["class_reg"].Columns[i].ColumnName;  // 첫 행에 컬럼이름들 저장
            }

            // 2-2. Row 데이터 저장
            for (int i = 0; i < dataSet.Tables["class_reg"].Rows.Count; i++)
            {
                for (int j = 0; j < dataSet.Tables["class_reg"].Columns.Count; j++)
                {
                    dataArr[i + 1, j] = dataSet.Tables["class_reg"].Rows[i].ItemArray[j].ToString();
                }
            }

            // 3. 준비된 스트링 배열을 엑셀파일로 저장
            string endCell = Convert.ToChar(65 + dataSet.Tables["class_reg"].Columns.Count - 1).ToString() + rowCount.ToString();
            eWorkSheet.get_Range($"A1:{endCell}").Value = dataArr;  // 배열의 데이터를 엑셀 시트에 기록

            eWorkbook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            eWorkbook.Close(false, Type.Missing, Type.Missing);
            eApp.Quit();
        }

        private void Btnexcel_Click(object sender, EventArgs e)
        {
            // dataGridView1에 데이터가 있는지 체크
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("저장할 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.Filter = "엑셀 파일(*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveExcelFile(saveFileDialog1.FileName);
            }
        }
    }
}
