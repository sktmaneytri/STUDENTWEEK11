
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.help_btn = new System.Windows.Forms.Button();
            this.ACCOUNTLBL = new System.Windows.Forms.Label();
            this.lbForgetPass = new System.Windows.Forms.LinkLabel();
            this.lbSignUp = new System.Windows.Forms.LinkLabel();
            this.humanResourceCheck = new System.Windows.Forms.CheckBox();
            this.studentCheck = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTip = new System.Windows.Forms.ToolTip(this.components);
            this.passWordTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.copy_space_blue_circuits_digital_background_23_214882169951;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.help_btn);
            this.panel1.Controls.Add(this.ACCOUNTLBL);
            this.panel1.Controls.Add(this.lbForgetPass);
            this.panel1.Controls.Add(this.lbSignUp);
            this.panel1.Controls.Add(this.humanResourceCheck);
            this.panel1.Controls.Add(this.studentCheck);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 394);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(116, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Copyright © 2022 LIBRATECH. Powered by MTris";
            // 
            // help_btn
            // 
            this.help_btn.Font = new System.Drawing.Font("Microsoft Uighur", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.Location = new System.Drawing.Point(513, 360);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(66, 31);
            this.help_btn.TabIndex = 13;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // ACCOUNTLBL
            // 
            this.ACCOUNTLBL.AutoSize = true;
            this.ACCOUNTLBL.BackColor = System.Drawing.Color.Transparent;
            this.ACCOUNTLBL.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCOUNTLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ACCOUNTLBL.Location = new System.Drawing.Point(174, 23);
            this.ACCOUNTLBL.Name = "ACCOUNTLBL";
            this.ACCOUNTLBL.Size = new System.Drawing.Size(280, 36);
            this.ACCOUNTLBL.TabIndex = 12;
            this.ACCOUNTLBL.Text = "Account Login";
            // 
            // lbForgetPass
            // 
            this.lbForgetPass.AutoSize = true;
            this.lbForgetPass.Location = new System.Drawing.Point(286, 309);
            this.lbForgetPass.Name = "lbForgetPass";
            this.lbForgetPass.Size = new System.Drawing.Size(114, 17);
            this.lbForgetPass.TabIndex = 11;
            this.lbForgetPass.TabStop = true;
            this.lbForgetPass.Text = "Forget Password";
            this.lbForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbForgetPass_LinkClicked);
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Location = new System.Drawing.Point(60, 309);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(56, 17);
            this.lbSignUp.TabIndex = 10;
            this.lbSignUp.TabStop = true;
            this.lbSignUp.Text = "Sign up";
            this.lbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSignUp_LinkClicked);
            // 
            // humanResourceCheck
            // 
            this.humanResourceCheck.AutoSize = true;
            this.humanResourceCheck.BackColor = System.Drawing.Color.Transparent;
            this.humanResourceCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.humanResourceCheck.Location = new System.Drawing.Point(289, 188);
            this.humanResourceCheck.Name = "humanResourceCheck";
            this.humanResourceCheck.Size = new System.Drawing.Size(140, 21);
            this.humanResourceCheck.TabIndex = 9;
            this.humanResourceCheck.Text = "Human Resource";
            this.humanResourceCheck.UseVisualStyleBackColor = false;
            // 
            // studentCheck
            // 
            this.studentCheck.AutoSize = true;
            this.studentCheck.BackColor = System.Drawing.Color.Transparent;
            this.studentCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.studentCheck.Location = new System.Drawing.Point(107, 188);
            this.studentCheck.Name = "studentCheck";
            this.studentCheck.Size = new System.Drawing.Size(79, 21);
            this.studentCheck.TabIndex = 8;
            this.studentCheck.Text = "Student";
            this.studentCheck.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lime;
            this.btnLogin.Location = new System.Drawing.Point(63, 246);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 47);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(306, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 22);
            this.txtPassword.TabIndex = 4;
            this.passWordTip.SetToolTip(this.txtPassword, "Enter the password");
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(211, 98);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(243, 22);
            this.txtUserName.TabIndex = 3;
            this.passWordTip.SetToolTip(this.txtUserName, "Enter the username");
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(59, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // userNameTip
            // 
            this.userNameTip.IsBalloon = true;
            this.userNameTip.Tag = "";
            this.userNameTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // passWordTip
            // 
            this.passWordTip.IsBalloon = true;
            this.passWordTip.Tag = "";
            this.passWordTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.bandicam_2021_05_16_14_42_27_953;
            this.pictureBox2.Location = new System.Drawing.Point(478, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources._109861283_student_icon_education_concept_icon_with_settings_sign_student_icon_and_customize_setup_manage_proce1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.copy_space_blue_circuits_digital_background_23_21488216994;
            this.ClientSize = new System.Drawing.Size(654, 432);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox studentCheck;
        private System.Windows.Forms.CheckBox humanResourceCheck;
        private System.Windows.Forms.LinkLabel lbForgetPass;
        private System.Windows.Forms.LinkLabel lbSignUp;
        private System.Windows.Forms.Label ACCOUNTLBL;
        private System.Windows.Forms.ToolTip userNameTip;
        private System.Windows.Forms.ToolTip passWordTip;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}

