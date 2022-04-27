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
    public partial class AvgScoreForm : Form
    {
        public AvgScoreForm()
        {
            InitializeComponent();
        }

        private void AvgScoreForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with avenrage score by score
            SCORE score = new SCORE();
            dataGridView1.DataSource = score.avgScoreByCourse();
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                int len = this.dataGridView1.Rows.Count;
                for (int i = 0; i < len; i++)
                {

                    string s = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string k = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    double kq = Convert.ToDouble(k);
                    chart1.Series["Score"].Points.AddXY(s, k);
                }
            }
            catch (NullReferenceException ee)
            {
                ee.InnerException.ToString();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
