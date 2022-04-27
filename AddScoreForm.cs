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


namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORE Score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {   
            //COURSE 
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";


            //student 
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std");
            dataGridView1.DataSource = student.getStudents(command);


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id_box.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        public int CreateAutoID()
        {
            int id = 0;
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM score", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            id = table.Rows.Count;
            return id = id + 1;
        }
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

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void score_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void score_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
