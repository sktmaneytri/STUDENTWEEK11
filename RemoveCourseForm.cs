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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        MY_DB db = new MY_DB();
        private void search_btn_Click(object sender, EventArgs e)
        {
            string label = label_box.Text;
            string id = id_box.Text;
            try
            {
                
                SqlCommand command = new SqlCommand("SELECT label, hours, description FROM course WHERE Id = @id", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                DataTable table = course.getCourses(command);
                if (table.Rows.Count > 0)
                {
                    label_box.Text = table.Rows[0]["label"].ToString();
                    numericHours_box.Value = Convert.ToDecimal(table.Rows[0]["hours"]);
                    description_box.Text = table.Rows[0]["description"].ToString();
                }
                else
                {
                    MessageBox.Show("Not found", "Find course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Find course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("You want delete this course ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    if (course.DeleteCourse(int.Parse(id_box.Text)))
                    {
                        MessageBox.Show("Delete succesfully", "Detele Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        id_box.Text = "";
                        label_box.Text = "";
                        numericHours_box.Value = 0;
                        description_box.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Error!", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }

        private void numericHours_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
