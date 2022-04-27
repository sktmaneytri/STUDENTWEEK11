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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int CreateAutoID()
        {
            int id = 0;
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM course", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            id = table.Rows.Count;
            return id = id + 1;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_box.Text);
            string courseLabel = label_box.Text;
            int hours = (int)numericHours_box.Value;
            string description = description_box.Text;
            COURSE course = new COURSE();
            if (verif() && course.checkUserName(courseLabel) && hours > 9)
            {
                
                if (course.insertCourse( id, courseLabel, hours, description))
                {
                    MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields or This course already exist or The number of hours < 10", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif()
        {
            if ((id_box.Text.Trim() == "")||(label_box.Text.Trim() == "") || (description_box.Text.Trim() == "") || ((int)numericHours_box.Value == 0))

            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

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

        private void numericHours_box_KeyPress(object sender, KeyPressEventArgs e)
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
