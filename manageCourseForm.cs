using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    public partial class manageCourseForm : Form
    {
        public manageCourseForm()
        {
            InitializeComponent();
        }
        int pos;
        

        private void manageCourseForm_Load(object sender, EventArgs e)
        {
            reloadCourses();
        }
        COURSE course = new COURSE();

        //create a funtion to load the data of course into listbox
        public void reloadCourses()
        {
            listBoxCourses.DataSource = course.getAllCourse();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";
            //unselect the item from listbox
            listBoxCourses.SelectedItem = null;

            //display the totalcourse
            totalCourse.Text = "Total Courses: " + course.totalCourse();
        }

        //create a function to ddissplay course data depending on the index
        void showData(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];
            id_box.Text = dr.ItemArray[0].ToString();
            listBoxCourses.SelectedIndex = index;
            label_box.Text = dr.ItemArray[1].ToString();
            numericHours_box.Value = int.Parse(dr.ItemArray[2].ToString());
            description_box.Text = dr.ItemArray[3].ToString();
        }
        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            //display the selected course data
            pos = listBoxCourses.SelectedIndex;
            showData(pos);

        }


        
        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display the selected course data
            try
            {
                pos = listBoxCourses.SelectedIndex;
                showData(pos);
            } catch
            {

            }
        }
        private void First_btn_Click(object sender, EventArgs e)
        {
            try
            {
                pos = 0;
                showData(0);
            }catch
            {

            }
        }
        private void Previous_btn_Click(object sender, EventArgs e)
        {
            try
            {
                pos = pos - 1;
                showData(pos);
            }catch
            {
               
            }
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            try
            {
                pos = pos + 1;
                showData(pos);
            }catch { }
        }

        private void Last_btn_Click(object sender, EventArgs e)
        {
            try
            {
                pos = course.getAllCourse().Rows.Count - 1;
                showData(pos);
            }catch { }
        }

        //add course
        private void Add_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_box.Text);
            string courseLabel = label_box.Text;
            int hours = (int)numericHours_box.Value;
            string description = description_box.Text;
            COURSE course = new COURSE();
            if (verif() && course.checkUserName(courseLabel))
            {

                if (course.insertCourse(id, courseLabel, hours, description))
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
                MessageBox.Show("Empty Fields or This course already exist", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif()
        {
            if ((id_box.Text.Trim() == "") || (label_box.Text.Trim() == "") || (description_box.Text.Trim() == "") || ((int)numericHours_box.Value == 0))

            {
                return false;
            }
            else
            {
                return true;
            }


        }

        //edit course
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                try
                {
                    int id = int.Parse(id_box.Text);
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
        //remove course
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

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            reloadCourses();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            id_box.Text = "";
            label_box.Text = "";
            numericHours_box.Value = 0;
            description_box.Text = "";
        }
    }
}
