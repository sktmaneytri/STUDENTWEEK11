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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void removeScore_btn_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseid = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            DialogResult dg = MessageBox.Show("You want delete this score ?", "Detele Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    if (score.DeleteScore(studentid, courseid))
                    {
                        MessageBox.Show("Delete succesfully", "Detele Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentScore();
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
