using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
//using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using System.Drawing.Printing;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            fillGrid(new SqlCommand("SELECT * FROM std"));
            if(radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            SetMyCustomFormat();

        }
        STUDENT student = new STUDENT();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy - MM - dd";
            dataGridView1.DataSource = student.getStudents(command);
            //xu linh hinh anh
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            //display data on the datagridview depending on what the user have selected
            SqlCommand command;
            string query;
            //check if the radiobutton yes is checked
            //that mean the user want to use a date range
            if(radioButtonYes.Checked)
            {
                //get the date values
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if(radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '"+date1+"' AND '"+date2+"' AND gender = 'Male'";
                } else if(radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" +date2+ "' AND gender = 'Female'";
                } else
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }
                command = new SqlCommand(query);
                fillGrid(command);
            } else
            {
                //get the date values
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std";
                }
                command = new SqlCommand(query);
                fillGrid(command);
            }
        }


        //print data from datagirdview to a text file

        private void add_btn_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\student_list.txt"; 
            using (var writer = new StreamWriter(path))
            {
                if(!File.Exists(path))
                {
                    File.Create(path);
                }
                DateTime bdate;
                //rows
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            if (j == 3)
                            {
                                bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                            }
                            else if (j == dataGridView1.Columns.Count - 2)
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }

                        }
                        writer.WriteLine("");
                        writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                MessageBox.Show("Data exported!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch(Exception ex)
                {
                    MessageBox.Show( ex.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /*
        private void printToExcel_btn_Click(object sender, EventArgs e)
        {              
           Excel.Application excel = new Excel.Application();
           excel.Visible = true;
           object Missing = Type.Missing;
           Workbook workbook = excel.Workbooks.Add(Missing);
           Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
           int StartCol = 1;
           int StartRow = 1;


           for (int j = 0; j < dataGridView1.Columns.Count; j++)
           {
               Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
               myRange.Value2 = dataGridView1.Columns[j].HeaderText;
           }
           StartRow++;
           for (int i = 0; i < dataGridView1.Rows.Count; i++)
           {
               for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
               {

                   Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                   myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                   myRange.Select();
               }
           }
           */
            /*
                    
            
        }
        */


        private void Printer_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
        private Image ConvertToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

       
        private void printToWord_btn_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                TextWriter tw = new StreamWriter("D:/PhotoShop/student_list2.doc");

                
                for (int x = 0; x < dataGridView1.Columns.Count; x++)
                {
                    tw.Write(dataGridView1.Columns[x].HeaderText);
                    if (x != dataGridView1.Columns.Count - 1)
                    {
                        tw.Write(" | ");
                    }

                }

                tw.WriteLine();
                
                DateTime bdate;
                //writing the data
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            tw.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                        }
                        else if (j == dataGridView1.Columns.Count - 2)
                        {
                            tw.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            tw.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }

                    }
                    tw.WriteLine("");
                    tw.WriteLine("---------------------------------------------------------------------");
                }
                tw.Close();
                MessageBox.Show("Data exported!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
            SaveDocx saveDocx = new SaveDocx();
            DataTable data = (DataTable)this.dataGridView1.DataSource;
            List<string> header = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                header.Add(data.Columns[i].ColumnName);
            }
            List<STUDENT> listStu = new List<STUDENT>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataGridViewRow row = this.dataGridView1.Rows[i];
                int Id = int.Parse(row.Cells[0].Value.ToString().Trim());
                string fname = row.Cells[1].Value.ToString().Trim();
                string lname = row.Cells[2].Value.ToString().Trim();
                DateTime bdate;
               
                 bdate = DateTime.Parse(row.Cells[3].Value.ToString());
                bool gender = (row.Cells[4].Value.ToString().Trim() == "Male");
                string phone = row.Cells[5].Value.ToString().Trim();
                string address = row.Cells[6].Value.ToString().Trim();
                Image pic = this.ConvertToImage((Byte[])row.Cells[7].Value);
                listStu.Add(new STUDENT(Id, fname, lname, bdate, gender, phone, address, pic));
            }
            saveDocx.createTable(header, listStu);
            MessageBox.Show("Export successful!");

        }
        public void SetMyCustomFormat()   // Customs Date theo ý muốn của mình, bỏ thứ và hiện giao diện Date theo ý
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy - MM - dd";
        }

    }
}
