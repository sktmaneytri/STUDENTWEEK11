
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class ManageStudentsForm2
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
            this.uploadImage_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.lblpicture = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.gender_female_check = new System.Windows.Forms.RadioButton();
            this.gender_male_check = new System.Windows.Forms.RadioButton();
            this.lbladdr = new System.Windows.Forms.Label();
            this.birthDate_box = new System.Windows.Forms.DateTimePicker();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lastName_text = new System.Windows.Forms.TextBox();
            this.lblfname = new System.Windows.Forms.Label();
            this.firstName_text = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.studentID_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadimage_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.lblkeywords = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new NguyenMinhTri_20110422_LOGIN_BUOI1.MyDBDataSet();
            this.totalStudent_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.stdTableAdapter = new NguyenMinhTri_20110422_LOGIN_BUOI1.MyDBDataSetTableAdapters.stdTableAdapter();
            this.add_btn = new System.Windows.Forms.Button();
            this.picture_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadImage_btn
            // 
            this.uploadImage_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.uploadImage_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImage_btn.Location = new System.Drawing.Point(153, 550);
            this.uploadImage_btn.Name = "uploadImage_btn";
            this.uploadImage_btn.Size = new System.Drawing.Size(101, 33);
            this.uploadImage_btn.TabIndex = 39;
            this.uploadImage_btn.Text = "Upload Image";
            this.uploadImage_btn.UseVisualStyleBackColor = false;
            this.uploadImage_btn.Click += new System.EventHandler(this.uploadImage_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove_btn.Location = new System.Drawing.Point(289, 688);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(85, 41);
            this.remove_btn.TabIndex = 38;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // lblpicture
            // 
            this.lblpicture.AutoSize = true;
            this.lblpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpicture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpicture.Location = new System.Drawing.Point(42, 378);
            this.lblpicture.Name = "lblpicture";
            this.lblpicture.Size = new System.Drawing.Size(66, 18);
            this.lblpicture.TabIndex = 35;
            this.lblpicture.Text = "Picture:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgender.Location = new System.Drawing.Point(42, 222);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(68, 18);
            this.lblgender.TabIndex = 34;
            this.lblgender.Text = "Gender:";
            // 
            // gender_female_check
            // 
            this.gender_female_check.AutoSize = true;
            this.gender_female_check.Location = new System.Drawing.Point(289, 222);
            this.gender_female_check.Name = "gender_female_check";
            this.gender_female_check.Size = new System.Drawing.Size(75, 21);
            this.gender_female_check.TabIndex = 33;
            this.gender_female_check.TabStop = true;
            this.gender_female_check.Text = "Female";
            this.gender_female_check.UseVisualStyleBackColor = true;
            // 
            // gender_male_check
            // 
            this.gender_male_check.AutoSize = true;
            this.gender_male_check.Location = new System.Drawing.Point(153, 222);
            this.gender_male_check.Name = "gender_male_check";
            this.gender_male_check.Size = new System.Drawing.Size(59, 21);
            this.gender_male_check.TabIndex = 32;
            this.gender_male_check.TabStop = true;
            this.gender_male_check.Text = "Male";
            this.gender_male_check.UseVisualStyleBackColor = true;
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbladdr.Location = new System.Drawing.Point(42, 322);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(74, 18);
            this.lbladdr.TabIndex = 31;
            this.lbladdr.Text = "Address:";
            // 
            // birthDate_box
            // 
            this.birthDate_box.Location = new System.Drawing.Point(153, 179);
            this.birthDate_box.Name = "birthDate_box";
            this.birthDate_box.Size = new System.Drawing.Size(211, 22);
            this.birthDate_box.TabIndex = 30;
            this.birthDate_box.Value = new System.DateTime(2022, 4, 7, 0, 0, 0, 0);
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(153, 268);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(211, 22);
            this.phone_text.TabIndex = 29;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblphone.Location = new System.Drawing.Point(42, 268);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(61, 18);
            this.lblphone.TabIndex = 28;
            this.lblphone.Text = "Phone:";
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(153, 319);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(211, 22);
            this.address_text.TabIndex = 27;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldate.Location = new System.Drawing.Point(42, 184);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(88, 18);
            this.lbldate.TabIndex = 26;
            this.lbldate.Text = "Birth Date:";
            // 
            // lastName_text
            // 
            this.lastName_text.Location = new System.Drawing.Point(153, 135);
            this.lastName_text.Name = "lastName_text";
            this.lastName_text.Size = new System.Drawing.Size(211, 22);
            this.lastName_text.TabIndex = 25;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfname.Location = new System.Drawing.Point(42, 88);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(96, 18);
            this.lblfname.TabIndex = 24;
            this.lblfname.Text = "First Name:";
            // 
            // firstName_text
            // 
            this.firstName_text.Location = new System.Drawing.Point(153, 88);
            this.firstName_text.Name = "firstName_text";
            this.firstName_text.Size = new System.Drawing.Size(211, 22);
            this.firstName_text.TabIndex = 23;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLname.Location = new System.Drawing.Point(42, 138);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(94, 18);
            this.lblLname.TabIndex = 22;
            this.lblLname.Text = "Last Name:";
            // 
            // studentID_text
            // 
            this.studentID_text.Location = new System.Drawing.Point(153, 44);
            this.studentID_text.Name = "studentID_text";
            this.studentID_text.Size = new System.Drawing.Size(211, 22);
            this.studentID_text.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblID";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student ID:";
            // 
            // downloadimage_btn
            // 
            this.downloadimage_btn.BackColor = System.Drawing.Color.Turquoise;
            this.downloadimage_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadimage_btn.Location = new System.Drawing.Point(260, 550);
            this.downloadimage_btn.Name = "downloadimage_btn";
            this.downloadimage_btn.Size = new System.Drawing.Size(104, 33);
            this.downloadimage_btn.TabIndex = 40;
            this.downloadimage_btn.Text = "Download";
            this.downloadimage_btn.UseVisualStyleBackColor = false;
            this.downloadimage_btn.Click += new System.EventHandler(this.downloadimage_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Teal;
            this.edit_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edit_btn.Location = new System.Drawing.Point(153, 688);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 41);
            this.edit_btn.TabIndex = 41;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reset_btn.Location = new System.Drawing.Point(429, 688);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(84, 41);
            this.reset_btn.TabIndex = 42;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // lblkeywords
            // 
            this.lblkeywords.AccessibleName = "lblID";
            this.lblkeywords.AutoSize = true;
            this.lblkeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkeywords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblkeywords.Location = new System.Drawing.Point(514, 29);
            this.lblkeywords.Name = "lblkeywords";
            this.lblkeywords.Size = new System.Drawing.Size(217, 25);
            this.lblkeywords.TabIndex = 43;
            this.lblkeywords.Text = "Enter a value to search:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(802, 32);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(308, 22);
            this.SearchBox.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.stdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(499, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 566);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.myDBDataSetBindingSource;
            // 
            // myDBDataSetBindingSource
            // 
            this.myDBDataSetBindingSource.DataSource = this.myDBDataSet;
            this.myDBDataSetBindingSource.Position = 0;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalStudent_btn
            // 
            this.totalStudent_btn.BackColor = System.Drawing.Color.Blue;
            this.totalStudent_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalStudent_btn.Location = new System.Drawing.Point(869, 678);
            this.totalStudent_btn.Name = "totalStudent_btn";
            this.totalStudent_btn.Size = new System.Drawing.Size(218, 51);
            this.totalStudent_btn.TabIndex = 46;
            this.totalStudent_btn.Text = "Total student:";
            this.totalStudent_btn.UseVisualStyleBackColor = false;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search_btn.Location = new System.Drawing.Point(1148, 19);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(136, 42);
            this.search_btn.TabIndex = 47;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refresh_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refresh_btn.Location = new System.Drawing.Point(1312, 19);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(112, 41);
            this.refresh_btn.TabIndex = 48;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_btn.Location = new System.Drawing.Point(31, 688);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(86, 41);
            this.add_btn.TabIndex = 37;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // picture_box
            // 
            this.picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_box.Location = new System.Drawing.Point(153, 365);
            this.picture_box.Name = "picture_box";
            this.picture_box.Padding = new System.Windows.Forms.Padding(3);
            this.picture_box.Size = new System.Drawing.Size(211, 179);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 36;
            this.picture_box.TabStop = false;
            this.picture_box.Visible = false;
            // 
            // ManageStudentsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1471, 755);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.totalStudent_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.lblkeywords);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.downloadimage_btn);
            this.Controls.Add(this.uploadImage_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.picture_box);
            this.Controls.Add(this.lblpicture);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.gender_female_check);
            this.Controls.Add(this.gender_male_check);
            this.Controls.Add(this.lbladdr);
            this.Controls.Add(this.birthDate_box);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lastName_text);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.firstName_text);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.studentID_text);
            this.Controls.Add(this.label1);
            this.Name = "ManageStudentsForm2";
            this.Text = "ManageStudentsForm2";
            this.Load += new System.EventHandler(this.ManageStudentsForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadImage_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Label lblpicture;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.RadioButton gender_female_check;
        private System.Windows.Forms.RadioButton gender_male_check;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.DateTimePicker birthDate_box;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox lastName_text;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox firstName_text;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox studentID_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downloadimage_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label lblkeywords;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button totalStudent_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private MyDBDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}