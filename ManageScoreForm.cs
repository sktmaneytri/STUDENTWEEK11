using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        SCORE Score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        string data = "score";

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            //datagirdview with student score
            dataGridView1.DataSource = Score.getStudentScore();

        }

        private void showstd_btn_Click(object sender, EventArgs e)
        {
            //display the dataof student into the datagirdview
            data = "student";
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM std ");
            dataGridView1.DataSource = student.getStudents(command);
        }

        private void showScore_btn_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = Score.getStudentScore();
        }
        //getdata from datagirdview
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDataGridview();
        }

        //function to get data from datagridview
        public void getDataFromDataGridview()
        {
            if (data == "student")
            {
                id_box.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
            }
            else if(data == "score")
            {
                id_box.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }

        }
        public int CreateAutoID()
        {
            int id = 0;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM course", mydb.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            id = table.Rows.Count;
            return id = id + 1;
        }
        bool verif()
        {
            if ((id_box.Text.Trim() == "") || (score_box.Text.Trim() == "") || ((int)comboBoxCourse.SelectedValue == 0))

            {
                return false;
            }
            else
            {
                return true;
            }


        }
        //btn add score
        private void Add_btn_Click(object sender, EventArgs e)
        {
            //add a new course
            int id = CreateAutoID();
            int studentid = int.Parse(id_box.Text);
            int courseid = Convert.ToInt32(comboBoxCourse.SelectedValue);
            float score = float.Parse(score_box.Text);
            string description = description_box.Text;
            if (verif() && !Score.checkScoreExist(studentid, courseid))
            {

                if (Score.insertScore(id, studentid, courseid, score, description))
                {
                    MessageBox.Show("New Score Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields or This score already exist", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //btn remove score
        private void remove_btn_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseid = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            DialogResult dg = MessageBox.Show("You want delete this score ?", "Detele Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    if (Score.DeleteScore(studentid, courseid))
                    {
                        MessageBox.Show("Delete succesfully", "Detele Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = Score.getStudentScore();
                        dataGridView1.AllowUserToAddRows = false;
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Detele Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void avgScore_btn_Click(object sender, EventArgs e)
        {
            AvgScoreForm form = new AvgScoreForm();
            form.Show();
        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void score_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void score_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
