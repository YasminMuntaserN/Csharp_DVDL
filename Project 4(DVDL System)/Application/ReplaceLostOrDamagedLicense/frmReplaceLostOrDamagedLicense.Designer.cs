namespace Project_4_DVDL_System_.Application.ReplaceLostOrDamagedLicense
{
    partial class frmReplaceLostOrDamagedLicense
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
            this.ctrlDrivingLicenseCardWithFilter1 = new Project_4_DVDL_System_.License.ctrlDrivingLicenseCardWithFilter();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbDamagedLicense = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLostLicense = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblRreplacedLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReplacement = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbReplacementFor.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDrivingLicenseCardWithFilter1
            // 
            this.ctrlDrivingLicenseCardWithFilter1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlDrivingLicenseCardWithFilter1.FilterEnabled = true;
            this.ctrlDrivingLicenseCardWithFilter1.Location = new System.Drawing.Point(12, 81);
            this.ctrlDrivingLicenseCardWithFilter1.Name = "ctrlDrivingLicenseCardWithFilter1";
            this.ctrlDrivingLicenseCardWithFilter1.Size = new System.Drawing.Size(1045, 422);
            this.ctrlDrivingLicenseCardWithFilter1.TabIndex = 0;
            this.ctrlDrivingLicenseCardWithFilter1.OnLicenseSelected += new System.Action<System.Nullable<int>>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.BackColor = System.Drawing.SystemColors.Control;
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReplacementFor.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbReplacementFor.Location = new System.Drawing.Point(581, 81);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(476, 68);
            this.gbReplacementFor.TabIndex = 192;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Repalcement For:";
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.CheckedState.BorderColor = System.Drawing.Color.Goldenrod;
            this.rbDamagedLicense.CheckedState.BorderThickness = 0;
            this.rbDamagedLicense.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbDamagedLicense.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDamagedLicense.CheckedState.InnerOffset = -4;
            this.rbDamagedLicense.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.rbDamagedLicense.ForeColor = System.Drawing.Color.Black;
            this.rbDamagedLicense.Location = new System.Drawing.Point(243, 30);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(192, 30);
            this.rbDamagedLicense.TabIndex = 194;
            this.rbDamagedLicense.Text = "DamegedLicense";
            this.rbDamagedLicense.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDamagedLicense.UncheckedState.BorderThickness = 3;
            this.rbDamagedLicense.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDamagedLicense.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamegedLicense_CheckedChanged);
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.CheckedState.BorderColor = System.Drawing.Color.Goldenrod;
            this.rbLostLicense.CheckedState.BorderThickness = 0;
            this.rbLostLicense.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbLostLicense.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLostLicense.CheckedState.InnerOffset = -4;
            this.rbLostLicense.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.rbLostLicense.ForeColor = System.Drawing.Color.Black;
            this.rbLostLicense.Location = new System.Drawing.Point(47, 30);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(150, 30);
            this.rbLostLicense.TabIndex = 193;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLostLicense.UncheckedState.BorderThickness = 3;
            this.rbLostLicense.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLostLicense.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox2.Controls.Add(this.pictureBox2);
            this.guna2GroupBox2.Controls.Add(this.lblApplicationFees);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.pictureBox3);
            this.guna2GroupBox2.Controls.Add(this.lblApplicationDate);
            this.guna2GroupBox2.Controls.Add(this.pictureBox4);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.lblApplicationID);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.pictureBox8);
            this.guna2GroupBox2.Controls.Add(this.lblOldLicenseID);
            this.guna2GroupBox2.Controls.Add(this.label12);
            this.guna2GroupBox2.Controls.Add(this.pictureBox7);
            this.guna2GroupBox2.Controls.Add(this.lblRreplacedLicenseID);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.pictureBox1);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.lblCreatedByUser);
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.guna2GroupBox2.Location = new System.Drawing.Point(-2, 509);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1059, 199);
            this.guna2GroupBox2.TabIndex = 193;
            this.guna2GroupBox2.Text = "Application Info for License Replacement :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_4_DVDL_System_.Properties.Resources.id;
            this.pictureBox2.Location = new System.Drawing.Point(228, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 213;
            this.pictureBox2.TabStop = false;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(266, 124);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationFees.TabIndex = 212;
            this.lblApplicationFees.Text = "[$$$]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 210;
            this.label2.Text = "Application Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_4_DVDL_System_.Properties.Resources.wallet;
            this.pictureBox3.Location = new System.Drawing.Point(228, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 211;
            this.pictureBox3.TabStop = false;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(266, 92);
            this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(136, 25);
            this.lblApplicationDate.TabIndex = 209;
            this.lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_4_DVDL_System_.Properties.Resources.appointment;
            this.pictureBox4.Location = new System.Drawing.Point(228, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 208;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 207;
            this.label5.Text = "Application Date:";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(266, 60);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationID.TabIndex = 206;
            this.lblApplicationID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 205;
            this.label4.Text = "L.R.Application ID:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Project_4_DVDL_System_.Properties.Resources.id;
            this.pictureBox8.Location = new System.Drawing.Point(686, 92);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 204;
            this.pictureBox8.TabStop = false;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseID.Location = new System.Drawing.Point(724, 92);
            this.lblOldLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblOldLicenseID.TabIndex = 203;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(474, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 25);
            this.label12.TabIndex = 202;
            this.label12.Text = "Old License ID:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Project_4_DVDL_System_.Properties.Resources.id__1_;
            this.pictureBox7.Location = new System.Drawing.Point(686, 60);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 201;
            this.pictureBox7.TabStop = false;
            // 
            // lblRreplacedLicenseID
            // 
            this.lblRreplacedLicenseID.AutoSize = true;
            this.lblRreplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRreplacedLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblRreplacedLicenseID.Location = new System.Drawing.Point(724, 60);
            this.lblRreplacedLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRreplacedLicenseID.Name = "lblRreplacedLicenseID";
            this.lblRreplacedLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblRreplacedLicenseID.TabIndex = 200;
            this.lblRreplacedLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(462, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 25);
            this.label10.TabIndex = 199;
            this.label10.Text = "Replaced License ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_4_DVDL_System_.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(686, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 198;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(474, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 197;
            this.label1.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByUser.Location = new System.Drawing.Point(724, 124);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(74, 25);
            this.lblCreatedByUser.TabIndex = 196;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llShowLicenseInfo.LinkColor = System.Drawing.Color.Black;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(283, 718);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(225, 24);
            this.llShowLicenseInfo.TabIndex = 271;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show New Licenses Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llShowLicenseHistory.LinkColor = System.Drawing.Color.Black;
            this.llShowLicenseHistory.Location = new System.Drawing.Point(48, 718);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(208, 24);
            this.llShowLicenseHistory.TabIndex = 270;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show Licenses History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Peru;
            this.btnClose.FillColor2 = System.Drawing.Color.Goldenrod;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Project_4_DVDL_System_.Properties.Resources.close__2_;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(661, 714);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 269;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReplacement
            // 
            this.btnReplacement.BorderRadius = 10;
            this.btnReplacement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReplacement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReplacement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReplacement.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReplacement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReplacement.Enabled = false;
            this.btnReplacement.FillColor = System.Drawing.Color.Peru;
            this.btnReplacement.FillColor2 = System.Drawing.Color.Goldenrod;
            this.btnReplacement.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnReplacement.ForeColor = System.Drawing.Color.White;
            this.btnReplacement.Image = global::Project_4_DVDL_System_.Properties.Resources.IssueDrivingLicense_32;
            this.btnReplacement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReplacement.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReplacement.Location = new System.Drawing.Point(852, 714);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Size = new System.Drawing.Size(191, 45);
            this.btnReplacement.TabIndex = 268;
            this.btnReplacement.Text = "Replacement";
            this.btnReplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReplacement.Click += new System.EventHandler(this.btnReplacement_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::Project_4_DVDL_System_.Properties.Resources.IssueDrivingLicense_32;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(225, 8);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(95, 50);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 273;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(317, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(383, 49);
            this.lblTitle.TabIndex = 272;
            this.lblTitle.Text = " License Replacement";
            // 
            // frmReplaceLostOrDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 766);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReplacement);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctrlDrivingLicenseCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplaceLostOrDamagedLicense";
            this.Text = "Replace Lost Or Damaged License";
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicense_Load);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private License.ctrlDrivingLicenseCardWithFilter ctrlDrivingLicenseCardWithFilter1;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private Guna.UI2.WinForms.Guna2RadioButton rbLostLicense;
        private Guna.UI2.WinForms.Guna2RadioButton rbDamagedLicense;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblRreplacedLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnReplacement;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lblTitle;
    }
}