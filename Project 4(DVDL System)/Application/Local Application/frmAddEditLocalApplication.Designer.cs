namespace Project_4_DVDL_System_.Application.Local_Application
{
    partial class frmAddEditLocalApplication
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
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TcApplication = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new Project_4_DVDL_System_.Person.User_Controls.ctrlPersonCardWithFilter();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLocalApplicationD = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.TcApplication.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::Project_4_DVDL_System_.Properties.Resources.Local_Driving_License_512;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(70, 12);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(95, 70);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 250;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 16.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(172, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(593, 39);
            this.lblTitle.TabIndex = 247;
            this.lblTitle.Text = "Add New Local Driving License Application";
            // 
            // TcApplication
            // 
            this.TcApplication.Controls.Add(this.tabPagePersonalInfo);
            this.TcApplication.Controls.Add(this.tpApplicationInfo);
            this.TcApplication.ItemSize = new System.Drawing.Size(180, 40);
            this.TcApplication.Location = new System.Drawing.Point(12, 93);
            this.TcApplication.Name = "TcApplication";
            this.TcApplication.SelectedIndex = 0;
            this.TcApplication.Size = new System.Drawing.Size(847, 490);
            this.TcApplication.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TcApplication.TabButtonHoverState.FillColor = System.Drawing.Color.Black;
            this.TcApplication.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TcApplication.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TcApplication.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.TcApplication.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TcApplication.TabButtonIdleState.FillColor = System.Drawing.Color.Gray;
            this.TcApplication.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TcApplication.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.TcApplication.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.TcApplication.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TcApplication.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TcApplication.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TcApplication.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TcApplication.TabButtonSelectedState.InnerColor = System.Drawing.SystemColors.ActiveCaption;
            this.TcApplication.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TcApplication.TabIndex = 253;
            this.TcApplication.TabMenuBackColor = System.Drawing.Color.Transparent;
            this.TcApplication.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPagePersonalInfo.Controls.Add(this.btnNext);
            this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 44);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(839, 442);
            this.tabPagePersonalInfo.TabIndex = 0;
            this.tabPagePersonalInfo.Text = "Personal Info";
            this.tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(-4, 3);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(843, 360);
            this.ctrlPersonCardWithFilter1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 10;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Black;
            this.btnNext.FillColor2 = System.Drawing.Color.DimGray;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::Project_4_DVDL_System_.Properties.Resources.logout;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(616, 384);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.pictureBox1);
            this.tpApplicationInfo.Controls.Add(this.label1);
            this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblFees);
            this.tpApplicationInfo.Controls.Add(this.label2);
            this.tpApplicationInfo.Controls.Add(this.pictureBox3);
            this.tpApplicationInfo.Controls.Add(this.pictureBox6);
            this.tpApplicationInfo.Controls.Add(this.label15);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.pictureBox4);
            this.tpApplicationInfo.Controls.Add(this.label5);
            this.tpApplicationInfo.Controls.Add(this.lblLocalApplicationD);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationID);
            this.tpApplicationInfo.Controls.Add(this.guna2Separator1);
            this.tpApplicationInfo.Controls.Add(this.pictureBox10);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 44);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(839, 442);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClass.BorderColor = System.Drawing.Color.Gray;
            this.cbLicenseClass.BorderRadius = 10;
            this.cbLicenseClass.BorderThickness = 0;
            this.cbLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FillColor = System.Drawing.Color.Silver;
            this.cbLicenseClass.FocusedColor = System.Drawing.Color.Black;
            this.cbLicenseClass.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbLicenseClass.ForeColor = System.Drawing.Color.Black;
            this.cbLicenseClass.ItemHeight = 27;
            this.cbLicenseClass.Location = new System.Drawing.Point(292, 158);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(272, 33);
            this.cbLicenseClass.TabIndex = 366;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_4_DVDL_System_.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(235, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 183;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 182;
            this.label1.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(274, 287);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(74, 25);
            this.lblCreatedByUser.TabIndex = 181;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(274, 222);
            this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(62, 25);
            this.lblFees.TabIndex = 180;
            this.lblFees.Text = "[$$$]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 178;
            this.label2.Text = "Application Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_4_DVDL_System_.Properties.Resources.money__1_;
            this.pictureBox3.Location = new System.Drawing.Point(235, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 179;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Project_4_DVDL_System_.Properties.Resources.IssueDrivingLicense_32;
            this.pictureBox6.Location = new System.Drawing.Point(236, 161);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 177;
            this.pictureBox6.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 158);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 25);
            this.label15.TabIndex = 176;
            this.label15.Text = "License Class:";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(275, 103);
            this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(136, 25);
            this.lblApplicationDate.TabIndex = 174;
            this.lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_4_DVDL_System_.Properties.Resources.appointments;
            this.pictureBox4.Location = new System.Drawing.Point(237, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 173;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 172;
            this.label5.Text = "Application Date:";
            // 
            // lblLocalApplicationD
            // 
            this.lblLocalApplicationD.AutoSize = true;
            this.lblLocalApplicationD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalApplicationD.Location = new System.Drawing.Point(287, 28);
            this.lblLocalApplicationD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalApplicationD.Name = "lblLocalApplicationD";
            this.lblLocalApplicationD.Size = new System.Drawing.Size(49, 25);
            this.lblLocalApplicationD.TabIndex = 168;
            this.lblLocalApplicationD.Text = "N/A";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(42, 27);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(198, 25);
            this.lblApplicationID.TabIndex = 167;
            this.lblApplicationID.Text = "D.L.Application ID :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Green;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(47, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(750, 30);
            this.guna2Separator1.TabIndex = 166;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Project_4_DVDL_System_.Properties.Resources.id__1_;
            this.pictureBox10.Location = new System.Drawing.Point(249, 27);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 26);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 169;
            this.pictureBox10.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderThickness = 3;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Project_4_DVDL_System_.Properties.Resources.close__2_;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(470, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 45);
            this.btnClose.TabIndex = 255;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 3;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Project_4_DVDL_System_.Properties.Resources.bookmark;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(650, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 45);
            this.btnSave.TabIndex = 254;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditLocalApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 665);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TcApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddEditLocalApplication";
            this.Text = "Add Edit Local Application";
            this.Load += new System.EventHandler(this.frmAddEditLocalApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.TcApplication.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl TcApplication;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private Person.User_Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label lblLocalApplicationD;
        private System.Windows.Forms.Label lblApplicationID;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClass;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}