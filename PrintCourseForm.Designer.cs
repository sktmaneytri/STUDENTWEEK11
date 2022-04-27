
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class PrintCourseForm
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
            this.components = new System.ComponentModel.Container();
            this.Printer_btn = new System.Windows.Forms.Button();
            this.printToExcel_btn = new System.Windows.Forms.Button();
            this.printToWord_btn = new System.Windows.Forms.Button();
            this.stdTableAdapter = new NguyenMinhTri_20110422_LOGIN_BUOI1.MyDBDataSetTableAdapters.stdTableAdapter();
            this.add_btn = new System.Windows.Forms.Button();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new NguyenMinhTri_20110422_LOGIN_BUOI1.MyDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Printer_btn
            // 
            this.Printer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Printer_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printer_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Printer_btn.Location = new System.Drawing.Point(952, 650);
            this.Printer_btn.Name = "Printer_btn";
            this.Printer_btn.Size = new System.Drawing.Size(252, 50);
            this.Printer_btn.TabIndex = 28;
            this.Printer_btn.Text = "To Printer";
            this.Printer_btn.UseVisualStyleBackColor = false;
            this.Printer_btn.Click += new System.EventHandler(this.Printer_btn_Click);
            // 
            // printToExcel_btn
            // 
            this.printToExcel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.printToExcel_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToExcel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printToExcel_btn.Location = new System.Drawing.Point(640, 650);
            this.printToExcel_btn.Name = "printToExcel_btn";
            this.printToExcel_btn.Size = new System.Drawing.Size(252, 50);
            this.printToExcel_btn.TabIndex = 27;
            this.printToExcel_btn.Text = "Print To Excel";
            this.printToExcel_btn.UseVisualStyleBackColor = false;
            // 
            // printToWord_btn
            // 
            this.printToWord_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.printToWord_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToWord_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printToWord_btn.Location = new System.Drawing.Point(314, 650);
            this.printToWord_btn.Name = "printToWord_btn";
            this.printToWord_btn.Size = new System.Drawing.Size(265, 50);
            this.printToWord_btn.TabIndex = 26;
            this.printToWord_btn.Text = "Print To File Word";
            this.printToWord_btn.UseVisualStyleBackColor = false;
            this.printToWord_btn.Click += new System.EventHandler(this.printToWord_btn_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Blue;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.Location = new System.Drawing.Point(12, 650);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(244, 50);
            this.add_btn.TabIndex = 24;
            this.add_btn.Text = "Print To Text File";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 562);
            this.dataGridView1.TabIndex = 29;
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.e3982cc208873792337b423d9e7714b37;
            this.ClientSize = new System.Drawing.Size(1233, 755);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Printer_btn);
            this.Controls.Add(this.printToExcel_btn);
            this.Controls.Add(this.printToWord_btn);
            this.Controls.Add(this.add_btn);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Printer_btn;
        private System.Windows.Forms.Button printToExcel_btn;
        private System.Windows.Forms.Button printToWord_btn;
        private MyDBDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}