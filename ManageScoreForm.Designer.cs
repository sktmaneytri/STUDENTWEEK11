
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class ManageScoreForm
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
            this.id_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.score_box = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.remove_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.description_box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.avgScore_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showstd_btn = new System.Windows.Forms.Button();
            this.showScore_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(221, 52);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(244, 22);
            this.id_box.TabIndex = 67;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(58, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Student id:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(221, 91);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(244, 30);
            this.comboBoxCourse.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(24, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "Select Courses:";
            // 
            // score_box
            // 
            this.score_box.Location = new System.Drawing.Point(221, 136);
            this.score_box.Name = "score_box";
            this.score_box.Size = new System.Drawing.Size(244, 22);
            this.score_box.TabIndex = 63;
            this.score_box.TextChanged += new System.EventHandler(this.score_box_TextChanged);
            this.score_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.score_box_KeyPress);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLabel.Location = new System.Drawing.Point(103, 136);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(65, 25);
            this.lblLabel.TabIndex = 62;
            this.lblLabel.Text = "Score:";
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove_btn.Location = new System.Drawing.Point(301, 412);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(143, 62);
            this.remove_btn.TabIndex = 61;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.Lime;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add_btn.Location = new System.Drawing.Point(108, 412);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(141, 62);
            this.Add_btn.TabIndex = 60;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(221, 210);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(244, 179);
            this.description_box.TabIndex = 59;
            this.description_box.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(49, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Description:";
            // 
            // avgScore_btn
            // 
            this.avgScore_btn.BackColor = System.Drawing.Color.Blue;
            this.avgScore_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgScore_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.avgScore_btn.Location = new System.Drawing.Point(108, 490);
            this.avgScore_btn.Name = "avgScore_btn";
            this.avgScore_btn.Size = new System.Drawing.Size(336, 53);
            this.avgScore_btn.TabIndex = 68;
            this.avgScore_btn.Text = "Avg Score by Course";
            this.avgScore_btn.UseVisualStyleBackColor = false;
            this.avgScore_btn.Click += new System.EventHandler(this.avgScore_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(517, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 491);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // showstd_btn
            // 
            this.showstd_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showstd_btn.Location = new System.Drawing.Point(517, 13);
            this.showstd_btn.Name = "showstd_btn";
            this.showstd_btn.Size = new System.Drawing.Size(339, 33);
            this.showstd_btn.TabIndex = 70;
            this.showstd_btn.Text = "Show Students";
            this.showstd_btn.UseVisualStyleBackColor = false;
            this.showstd_btn.Click += new System.EventHandler(this.showstd_btn_Click);
            // 
            // showScore_btn
            // 
            this.showScore_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showScore_btn.Location = new System.Drawing.Point(977, 13);
            this.showScore_btn.Name = "showScore_btn";
            this.showScore_btn.Size = new System.Drawing.Size(339, 33);
            this.showScore_btn.TabIndex = 71;
            this.showScore_btn.Text = "Show Scores";
            this.showScore_btn.UseVisualStyleBackColor = false;
            this.showScore_btn.Click += new System.EventHandler(this.showScore_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "*to edit a score you we have to Delete it and RE add it with the value you want";
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showScore_btn);
            this.Controls.Add(this.showstd_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.avgScore_btn);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score_box);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label2);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox score_box;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.RichTextBox description_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button avgScore_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showstd_btn;
        private System.Windows.Forms.Button showScore_btn;
        private System.Windows.Forms.Label label1;
    }
}