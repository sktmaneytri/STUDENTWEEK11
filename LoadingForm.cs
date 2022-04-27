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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            Ok_btn.Enabled = false;
            int x = 0;
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 10000;
            progressBar1.Value = 10;
            progressBar1.Step = 3;
            for (x = 1; x <= 10000; x++)
            {
                progressBar1.PerformStep();
            }
            Ok_btn.Enabled = true;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm01 main = new MainForm01();
            main.Show();
        }
    }
}
