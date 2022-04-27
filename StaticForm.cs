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
    public partial class StaticForm : Form
    {
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        public StaticForm()
        {
            InitializeComponent();
            panTotalColor = panelTotalStudent.BackColor;
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;
            //display
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            //tinh %
            double maleStudentsPercentage = (totalMale * (100 / total));
            maleStudentsPercentage = Math.Round(maleStudentsPercentage, 2);
            double FemaleStudentsPercentage = (totalFemale * (100 / total));
            FemaleStudentsPercentage = Math.Round(FemaleStudentsPercentage, 2);
            lblTotal.Text = ("Total Students: " + total.ToString());
            lblMale.Text = ("Total male Students: " + maleStudentsPercentage.ToString() + " %");
            lblFemale.Text = ("Total female Students: " + FemaleStudentsPercentage.ToString() + " %");
            chart3.Titles.Add("Pie chart");
            chart3.Series["s1"].Points.AddXY("male", maleStudentsPercentage.ToString());
            chart3.Series["s1"].Points.AddXY("female", FemaleStudentsPercentage.ToString());

            //line chart
            chart1.Titles.Add("Line chart");
            chart1.Series["student"].Points.AddXY("male", totalMale.ToString());
            chart1.Series["student"].Points.AddXY("female", totalFemale.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void StaticForm_Load(object sender, EventArgs e)
        {   
            /*
            panTotalColor = panelTotalStudent.BackColor;
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;
            //display
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            //tinh %
            double maleStudentsPercentage = (totalMale * (100 / total));
            maleStudentsPercentage = Math.Round(maleStudentsPercentage, 2);
            double FemaleStudentsPercentage = (totalFemale * (100 / total));
            FemaleStudentsPercentage = Math.Round(FemaleStudentsPercentage, 2);
            lblTotal.Text = ("Total Students: " + total.ToString());
            lblMale.Text = ("Total male Students: " + maleStudentsPercentage.ToString() + " %");
            lblFemale.Text = ("Total female Students: " + FemaleStudentsPercentage.ToString() + " %");
            */

        }

        

        private void lblTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotalStudent.BackColor = Color.Orange;
            lblTotal.ForeColor = panTotalColor;
        }

        private void lblTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotalStudent.BackColor = panTotalColor;
            lblTotal.ForeColor = Color.Orange;
        }

        private void lblMale_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.Orange;
            lblMale.ForeColor = panMaleColor;
        }

        private void lblMale_MouseLeave(object sender, EventArgs e)
        {
            panelMale.BackColor = panMaleColor;
            lblMale.ForeColor = Color.Orange;
        }

        private void lblFemale_MouseEnter(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.Orange;
            lblFemale.ForeColor = panFemaleColor;
        }

        private void lblFemale_MouseLeave(object sender, EventArgs e)
        {
            panelFemale.BackColor = panFemaleColor;
            lblFemale.ForeColor = Color.Orange;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());
            //tinh %
            double maleStudentsPercentage = (totalMale * (100 / total));
            maleStudentsPercentage = Math.Round(maleStudentsPercentage, 2);
            double FemaleStudentsPercentage = (totalFemale * (100 / total));
            FemaleStudentsPercentage = Math.Round(FemaleStudentsPercentage, 2);
            lblTotal.Text = ("Total Students: " + total.ToString());
            lblMale.Text = ("Total male Students: " + maleStudentsPercentage.ToString() + " %");
            lblFemale.Text = ("Total female Students: " + FemaleStudentsPercentage.ToString() + " %");
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chart_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
