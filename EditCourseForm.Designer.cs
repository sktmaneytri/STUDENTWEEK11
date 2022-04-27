
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class EditCourseForm
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.lblDeleteCourse = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericHours_box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label_box = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_btn.Location = new System.Drawing.Point(507, 439);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(143, 62);
            this.cancel_btn.TabIndex = 39;
            this.cancel_btn.Text = "Cancle";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.Color.Lime;
            this.Edit_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Edit_btn.Location = new System.Drawing.Point(263, 439);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(141, 62);
            this.Edit_btn.TabIndex = 38;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // lblDeleteCourse
            // 
            this.lblDeleteCourse.AutoSize = true;
            this.lblDeleteCourse.BackColor = System.Drawing.Color.DarkGreen;
            this.lblDeleteCourse.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDeleteCourse.Location = new System.Drawing.Point(355, 17);
            this.lblDeleteCourse.Name = "lblDeleteCourse";
            this.lblDeleteCourse.Size = new System.Drawing.Size(166, 28);
            this.lblDeleteCourse.TabIndex = 37;
            this.lblDeleteCourse.Text = "Edit Course";
            this.lblDeleteCourse.Click += new System.EventHandler(this.lblDeleteCourse_Click);
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(263, 243);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(387, 139);
            this.description_box.TabIndex = 36;
            this.description_box.Text = "";
            this.description_box.TextChanged += new System.EventHandler(this.description_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(83, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Description:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Number Of Hours:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericHours_box
            // 
            this.numericHours_box.Location = new System.Drawing.Point(263, 156);
            this.numericHours_box.Name = "numericHours_box";
            this.numericHours_box.Size = new System.Drawing.Size(387, 22);
            this.numericHours_box.TabIndex = 33;
            this.numericHours_box.ValueChanged += new System.EventHandler(this.numericHours_box_ValueChanged);
            this.numericHours_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericHours_box_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(58, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Select Courses:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_box
            // 
            this.label_box.Location = new System.Drawing.Point(263, 103);
            this.label_box.Name = "label_box";
            this.label_box.Size = new System.Drawing.Size(387, 22);
            this.label_box.TabIndex = 42;
            this.label_box.TextChanged += new System.EventHandler(this.label_box_TextChanged);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLabel.Location = new System.Drawing.Point(137, 101);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(62, 25);
            this.lblLabel.TabIndex = 41;
            this.lblLabel.Text = "Label:";
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(263, 58);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(387, 30);
            this.comboBoxCourse.TabIndex = 44;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_46311;
            this.pictureBox2.InitialImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_4632;
            this.pictureBox2.Location = new System.Drawing.Point(725, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.copy_space_blue_circuits_digital_background_23_21488216994;
            this.ClientSize = new System.Drawing.Size(858, 528);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_box);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.lblDeleteCourse);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericHours_box);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHours_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Label lblDeleteCourse;
        private System.Windows.Forms.RichTextBox description_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericHours_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox label_box;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}