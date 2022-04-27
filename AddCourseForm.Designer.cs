
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class AddCourseForm
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
            this.lblLabel = new System.Windows.Forms.Label();
            this.label_box = new System.Windows.Forms.TextBox();
            this.numericHours_box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.description_box = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLabel.Location = new System.Drawing.Point(121, 113);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(62, 25);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Label:";
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            // 
            // label_box
            // 
            this.label_box.Location = new System.Drawing.Point(247, 115);
            this.label_box.Name = "label_box";
            this.label_box.Size = new System.Drawing.Size(387, 22);
            this.label_box.TabIndex = 100;
            this.label_box.TextChanged += new System.EventHandler(this.label_box_TextChanged);
            // 
            // numericHours_box
            // 
            this.numericHours_box.Location = new System.Drawing.Point(247, 164);
            this.numericHours_box.Name = "numericHours_box";
            this.numericHours_box.Size = new System.Drawing.Size(387, 22);
            this.numericHours_box.TabIndex = 5;
            this.numericHours_box.ValueChanged += new System.EventHandler(this.numericHours_box_ValueChanged);
            this.numericHours_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericHours_box_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(117, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Times:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(67, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(247, 251);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(387, 139);
            this.description_box.TabIndex = 8;
            this.description_box.Text = "";
            this.description_box.TextChanged += new System.EventHandler(this.description_box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(339, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "New Course";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_btn.Location = new System.Drawing.Point(491, 447);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(143, 62);
            this.cancel_btn.TabIndex = 20;
            this.cancel_btn.Text = "Cancle";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_btn.Location = new System.Drawing.Point(247, 447);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(141, 62);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(247, 68);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(387, 22);
            this.id_box.TabIndex = 1;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(148, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_46311;
            this.pictureBox2.InitialImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_23_48_09_4632;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.copy_space_blue_circuits_digital_background_23_21488216995;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericHours_box);
            this.Controls.Add(this.label_box);
            this.Controls.Add(this.lblLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericHours_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox label_box;
        private System.Windows.Forms.NumericUpDown numericHours_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox description_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}