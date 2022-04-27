
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class StaticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTotalStudent = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.lblMale = new System.Windows.Forms.Label();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.lblFemale = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTotalStudent.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotalStudent
            // 
            this.panelTotalStudent.BackColor = System.Drawing.Color.Turquoise;
            this.panelTotalStudent.Controls.Add(this.lblTotal);
            this.panelTotalStudent.Location = new System.Drawing.Point(13, 13);
            this.panelTotalStudent.Name = "panelTotalStudent";
            this.panelTotalStudent.Size = new System.Drawing.Size(676, 168);
            this.panelTotalStudent.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(676, 168);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Student: 100";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.MouseEnter += new System.EventHandler(this.lblTotal_MouseEnter);
            this.lblTotal.MouseLeave += new System.EventHandler(this.lblTotal_MouseLeave);
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMale.Controls.Add(this.lblMale);
            this.panelMale.Location = new System.Drawing.Point(13, 188);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(330, 216);
            this.panelMale.TabIndex = 1;
            // 
            // lblMale
            // 
            this.lblMale.BackColor = System.Drawing.Color.Transparent;
            this.lblMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.Location = new System.Drawing.Point(0, 0);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(330, 216);
            this.lblMale.TabIndex = 1;
            this.lblMale.Text = "Male: 50%";
            this.lblMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMale.MouseEnter += new System.EventHandler(this.lblMale_MouseEnter);
            this.lblMale.MouseLeave += new System.EventHandler(this.lblMale_MouseLeave);
            // 
            // panelFemale
            // 
            this.panelFemale.BackColor = System.Drawing.Color.Yellow;
            this.panelFemale.Controls.Add(this.lblFemale);
            this.panelFemale.Location = new System.Drawing.Point(349, 188);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(340, 216);
            this.panelFemale.TabIndex = 2;
            // 
            // lblFemale
            // 
            this.lblFemale.BackColor = System.Drawing.Color.Transparent;
            this.lblFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFemale.Location = new System.Drawing.Point(0, 0);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(340, 216);
            this.lblFemale.TabIndex = 1;
            this.lblFemale.Text = "Female: 50%";
            this.lblFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFemale.MouseEnter += new System.EventHandler(this.lblFemale_MouseEnter);
            this.lblFemale.MouseLeave += new System.EventHandler(this.lblFemale_MouseLeave);
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.Lime;
            this.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.Location = new System.Drawing.Point(690, 16);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(120, 39);
            this.Reset_btn.TabIndex = 3;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(690, 61);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(120, 33);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(19, 407);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.LabelForeColor = System.Drawing.Color.LightGray;
            series10.Legend = "Legend1";
            series10.Name = "student";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(324, 358);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart2.Legends.Add(legend11);
            this.chart2.Location = new System.Drawing.Point(230, 538);
            this.chart2.Name = "chart2";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(8, 20);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea12.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart3.Legends.Add(legend12);
            this.chart3.Location = new System.Drawing.Point(349, 410);
            this.chart3.Name = "chart3";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "s1";
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(340, 366);
            this.chart3.TabIndex = 7;
            this.chart3.TabStop = false;
            this.chart3.Text = "chart3";
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 761);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotalStudent);
            this.Name = "StaticForm";
            this.Text = "StaticForm";
            this.Load += new System.EventHandler(this.StaticForm_Load);
            this.panelTotalStudent.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.panelFemale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalStudent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}