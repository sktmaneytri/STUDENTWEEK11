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
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void cOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsListForm form = new studentsListForm();
            form.Show();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm form = new StaticForm();
            form.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm2 form = new ManageStudentsForm2();
            form.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm form = new UpdateDeleteStudentForm();
            form.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm form = new PrintStudentForm();
            form.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm form = new AddCourseForm();
            form.Show();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm form = new RemoveCourseForm();
            form.Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm form = new EditCourseForm();
            form.Show();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageCourseForm form = new manageCourseForm();
            form.Show();
        }

        private void printCouresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCourseForm form = new PrintCourseForm();
            form.Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm form = new AddScoreForm();
            form.Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm form = new RemoveScoreForm();
            form.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm form = new ManageScoreForm();
            form.Show();
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreForm form = new AvgScoreForm();
            form.Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintScoreForm form = new PrintScoreForm();
            form.Show();
        }

        private void dataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm form = new StaticResultForm();
            form.Show();
        }
    }
}
