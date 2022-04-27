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
using System.Drawing.Printing;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        STUDENT student =  new STUDENT();
        SCORE score = new SCORE();
        COURSE coure = new COURSE();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM std ");
            dataGridView2.DataSource = student.getStudents(command);

            dataGridView1.DataSource = score.getStudentScore();
            listBox1.DataSource = coure.getAllCourse();
            listBox1.DisplayMember = "label";
            listBox1.ValueMember = "id";

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getCourseScores(int.Parse(listBox1.SelectedValue.ToString()));
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScores(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
        }


        //print the datascore to file txt
        private void add_btn_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\score_list.txt";
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                //rows
                try
                {
                    writer.Write("\t" + "Student id " + "     |          Firstname    |          Lastname     |   Courseid    |      Label    |      Score    |");
                    writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)

                        {   
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");


                        }
                        writer.WriteLine("");
                        writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                    writer.Close();
                    MessageBox.Show("Data exported!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void printoPrinter_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
    }
}
