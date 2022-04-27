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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        COURSE course = new COURSE();
        MY_DB db = new MY_DB();
       

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                    string courseLabel = label_box.Text;
                    int hours = (int)numericHours_box.Value;
                    string description = description_box.Text;
                    COURSE course = new COURSE();
                    if (course.EditCourse(id, courseLabel, hours, description))
                    {
                        MessageBox.Show("Edit succesfully", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif()
        {
            if ((label_box.Text.Trim() == "") || (description_box.Text.Trim() == "") || ((int)numericHours_box.Value == 0))

            {
                return false;
            }
            else
            {
                return true;
            }


        }
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            //select the combo item to nothing
            comboBoxCourse.SelectedItem = null;

        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display the data
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCoursesById(id);
                label_box.Text = table.Rows[0][1].ToString();
                numericHours_box.Value = int.Parse(table.Rows[0][2].ToString());
                description_box.Text = table.Rows[0][3].ToString();
            }
            catch
            {
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblDeleteCourse_Click(object sender, EventArgs e)
        {

        }

        private void description_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericHours_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericHours_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
