
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class AddScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScoreForm));
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.score_box = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.lblDeleteCourse = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            resources.ApplyResources(this.comboBoxCourse, "comboBoxCourse");
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCourse_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Name = "label4";
            // 
            // score_box
            // 
            resources.ApplyResources(this.score_box, "score_box");
            this.score_box.Name = "score_box";
            this.score_box.TextChanged += new System.EventHandler(this.score_box_TextChanged);
            this.score_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.score_box_KeyPress);
            // 
            // lblLabel
            // 
            resources.ApplyResources(this.lblLabel, "lblLabel");
            this.lblLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLabel.Name = "lblLabel";
            // 
            // cancel_btn
            // 
            resources.ApplyResources(this.cancel_btn, "cancel_btn");
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Add_btn
            // 
            resources.ApplyResources(this.Add_btn, "Add_btn");
            this.Add_btn.BackColor = System.Drawing.Color.Lime;
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // lblDeleteCourse
            // 
            resources.ApplyResources(this.lblDeleteCourse, "lblDeleteCourse");
            this.lblDeleteCourse.BackColor = System.Drawing.Color.DarkGreen;
            this.lblDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDeleteCourse.Name = "lblDeleteCourse";
            // 
            // description_box
            // 
            resources.ApplyResources(this.description_box, "description_box");
            this.description_box.Name = "description_box";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            // 
            // id_box
            // 
            resources.ApplyResources(this.id_box, "id_box");
            this.id_box.Name = "id_box";
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Name = "label3";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_46311;
            this.pictureBox2.InitialImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_4632;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // AddScoreForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.e3982cc208873792337b423d9e7714b316;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score_box);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.lblDeleteCourse);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label2);
            this.Name = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox score_box;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label lblDeleteCourse;
        private System.Windows.Forms.RichTextBox description_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}