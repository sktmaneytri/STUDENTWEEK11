
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class RemoveCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveCourseForm));
            this.cancel_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.lblDeleteCourse = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericHours_box = new System.Windows.Forms.NumericUpDown();
            this.label_box = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.cancel_btn, "cancel_btn");
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.Lime;
            this.Remove_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Remove_btn, "Remove_btn");
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // lblDeleteCourse
            // 
            resources.ApplyResources(this.lblDeleteCourse, "lblDeleteCourse");
            this.lblDeleteCourse.BackColor = System.Drawing.Color.DarkGreen;
            this.lblDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDeleteCourse.Name = "lblDeleteCourse";
            this.lblDeleteCourse.Click += new System.EventHandler(this.lblDeleteCourse_Click);
            // 
            // description_box
            // 
            resources.ApplyResources(this.description_box, "description_box");
            this.description_box.Name = "description_box";
            this.description_box.TextChanged += new System.EventHandler(this.description_box_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericHours_box
            // 
            resources.ApplyResources(this.numericHours_box, "numericHours_box");
            this.numericHours_box.Name = "numericHours_box";
            this.numericHours_box.ValueChanged += new System.EventHandler(this.numericHours_box_ValueChanged);
            this.numericHours_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericHours_box_KeyPress);
            // 
            // label_box
            // 
            resources.ApplyResources(this.label_box, "label_box");
            this.label_box.Name = "label_box";
            this.label_box.TextChanged += new System.EventHandler(this.label_box_TextChanged);
            // 
            // lblLabel
            // 
            resources.ApplyResources(this.lblLabel, "lblLabel");
            this.lblLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.search_btn, "search_btn");
            this.search_btn.Name = "search_btn";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // id_box
            // 
            resources.ApplyResources(this.id_box, "id_box");
            this.id_box.Name = "id_box";
            this.id_box.TextChanged += new System.EventHandler(this.id_box_TextChanged);
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_46311;
            this.pictureBox2.InitialImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_4632;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // RemoveCourseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.copy_space_blue_circuits_digital_background_23_214882169951;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.lblDeleteCourse);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericHours_box);
            this.Controls.Add(this.label_box);
            this.Controls.Add(this.lblLabel);
            this.Name = "RemoveCourseForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.numericHours_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Label lblDeleteCourse;
        private System.Windows.Forms.RichTextBox description_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericHours_box;
        private System.Windows.Forms.TextBox label_box;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}