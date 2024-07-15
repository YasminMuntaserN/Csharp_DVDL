using System;

namespace Project_4_DVDL_System_
{
    partial class frmMainMenu
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
            this.btnApplications = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.drivingLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.smLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.smInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.smRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.smRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.replacmentDamageOrLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.smManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.SmManageLocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.SmInternationalDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.smDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.smManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.Sperator = new System.Windows.Forms.ToolStripSeparator();
            this.smManageTestsTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDrivers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccountSettings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.smCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.smChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.smSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.guna2ContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplications.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnApplications.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.btnApplications.CustomBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnApplications.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnApplications.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApplications.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApplications.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplications.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApplications.FillColor = System.Drawing.Color.Transparent;
            this.btnApplications.Font = new System.Drawing.Font("Palatino Linotype", 15.8F, System.Drawing.FontStyle.Bold);
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.Location = new System.Drawing.Point(37, 71);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(228, 55);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.Text = "Applications";
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.Linen;
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseServicesToolStripMenuItem,
            this.toolStripSeparator1,
            this.smManageApplications,
            this.toolStripSeparator2,
            this.smDetainLicenses,
            this.toolStripSeparator3,
            this.smManageApplicationTypes,
            this.Sperator,
            this.smManageTestsTypes});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.Goldenrod;
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.Goldenrod;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(382, 218);
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            this.drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smNewDrivingLicense,
            this.toolStripSeparator12,
            this.smRenewDrivingLicense,
            this.toolStripSeparator4,
            this.smRetakeTest,
            this.toolStripSeparator11,
            this.replacmentDamageOrLostToolStripMenuItem});
            this.drivingLicenseServicesToolStripMenuItem.Image = global::Project_4_DVDL_System_.Properties.Resources.License_View_32;
            this.drivingLicenseServicesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            this.drivingLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(381, 38);
            this.drivingLicenseServicesToolStripMenuItem.Text = "         Driving License Services";
            // 
            // smNewDrivingLicense
            // 
            this.smNewDrivingLicense.BackColor = System.Drawing.Color.Linen;
            this.smNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smLocalLicense,
            this.toolStripSeparator5,
            this.smInternationalLicense});
            this.smNewDrivingLicense.Image = global::Project_4_DVDL_System_.Properties.Resources.driver_license__2_;
            this.smNewDrivingLicense.Name = "smNewDrivingLicense";
            this.smNewDrivingLicense.Size = new System.Drawing.Size(418, 36);
            this.smNewDrivingLicense.Text = "       New Driving License";
            // 
            // smLocalLicense
            // 
            this.smLocalLicense.BackColor = System.Drawing.Color.Linen;
            this.smLocalLicense.Image = global::Project_4_DVDL_System_.Properties.Resources.home__2_;
            this.smLocalLicense.Name = "smLocalLicense";
            this.smLocalLicense.Size = new System.Drawing.Size(333, 36);
            this.smLocalLicense.Text = "      Local License";
            this.smLocalLicense.Click += new System.EventHandler(this.smLocalLicense_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.Color.Linen;
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(330, 6);
            // 
            // smInternationalLicense
            // 
            this.smInternationalLicense.BackColor = System.Drawing.Color.Linen;
            this.smInternationalLicense.Image = global::Project_4_DVDL_System_.Properties.Resources.countries1;
            this.smInternationalLicense.Name = "smInternationalLicense";
            this.smInternationalLicense.Size = new System.Drawing.Size(333, 36);
            this.smInternationalLicense.Text = "      International License";
            this.smInternationalLicense.Click += new System.EventHandler(this.smInternationalLicense_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(415, 6);
            // 
            // smRenewDrivingLicense
            // 
            this.smRenewDrivingLicense.BackColor = System.Drawing.Color.Linen;
            this.smRenewDrivingLicense.Image = global::Project_4_DVDL_System_.Properties.Resources.IssueDrivingLicense_32;
            this.smRenewDrivingLicense.Name = "smRenewDrivingLicense";
            this.smRenewDrivingLicense.Size = new System.Drawing.Size(418, 36);
            this.smRenewDrivingLicense.Text = "        Renew Driving License";
            this.smRenewDrivingLicense.Click += new System.EventHandler(this.smRenewDrivingLicense_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.Linen;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(415, 6);
            // 
            // smRetakeTest
            // 
            this.smRetakeTest.BackColor = System.Drawing.Color.Linen;
            this.smRetakeTest.Image = global::Project_4_DVDL_System_.Properties.Resources.test;
            this.smRetakeTest.Name = "smRetakeTest";
            this.smRetakeTest.Size = new System.Drawing.Size(418, 36);
            this.smRetakeTest.Text = "      Retake Test";
            this.smRetakeTest.Click += new System.EventHandler(this.smRetakeTest_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(415, 6);
            // 
            // replacmentDamageOrLostToolStripMenuItem
            // 
            this.replacmentDamageOrLostToolStripMenuItem.BackColor = System.Drawing.Color.Linen;
            this.replacmentDamageOrLostToolStripMenuItem.Image = global::Project_4_DVDL_System_.Properties.Resources.License_View_32;
            this.replacmentDamageOrLostToolStripMenuItem.Name = "replacmentDamageOrLostToolStripMenuItem";
            this.replacmentDamageOrLostToolStripMenuItem.Size = new System.Drawing.Size(418, 36);
            this.replacmentDamageOrLostToolStripMenuItem.Text = "         Replacment Damage or Lost";
            this.replacmentDamageOrLostToolStripMenuItem.Click += new System.EventHandler(this.replacmentDamageOrLostToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(378, 6);
            // 
            // smManageApplications
            // 
            this.smManageApplications.BackColor = System.Drawing.Color.Linen;
            this.smManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmManageLocalDrivingLicenseApplications,
            this.toolStripSeparator10,
            this.SmInternationalDrivingLicense});
            this.smManageApplications.Image = global::Project_4_DVDL_System_.Properties.Resources.feature;
            this.smManageApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smManageApplications.Name = "smManageApplications";
            this.smManageApplications.Size = new System.Drawing.Size(381, 38);
            this.smManageApplications.Text = "       Manage Applications";
            // 
            // SmManageLocalDrivingLicenseApplications
            // 
            this.SmManageLocalDrivingLicenseApplications.BackColor = System.Drawing.Color.Linen;
            this.SmManageLocalDrivingLicenseApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SmManageLocalDrivingLicenseApplications.Image = global::Project_4_DVDL_System_.Properties.Resources.home__2_;
            this.SmManageLocalDrivingLicenseApplications.Name = "SmManageLocalDrivingLicenseApplications";
            this.SmManageLocalDrivingLicenseApplications.Size = new System.Drawing.Size(530, 36);
            this.SmManageLocalDrivingLicenseApplications.Text = "      Manage Local Driving License Applications";
            this.SmManageLocalDrivingLicenseApplications.Click += new System.EventHandler(this.manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(527, 6);
            // 
            // SmInternationalDrivingLicense
            // 
            this.SmInternationalDrivingLicense.BackColor = System.Drawing.Color.Linen;
            this.SmInternationalDrivingLicense.Image = global::Project_4_DVDL_System_.Properties.Resources.countries1;
            this.SmInternationalDrivingLicense.Name = "SmInternationalDrivingLicense";
            this.SmInternationalDrivingLicense.Size = new System.Drawing.Size(530, 36);
            this.SmInternationalDrivingLicense.Text = "     International Driving License Applications";
            this.SmInternationalDrivingLicense.Click += new System.EventHandler(this.SmInternationalDrivingLicense_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(378, 6);
            // 
            // smDetainLicenses
            // 
            this.smDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.smDetainLicenses.Image = global::Project_4_DVDL_System_.Properties.Resources.driver_license1;
            this.smDetainLicenses.Name = "smDetainLicenses";
            this.smDetainLicenses.Size = new System.Drawing.Size(381, 38);
            this.smDetainLicenses.Text = "       Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.BackColor = System.Drawing.Color.Linen;
            this.manageDetainedLicensesToolStripMenuItem.Image = global::Project_4_DVDL_System_.Properties.Resources.feature1;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(393, 36);
            this.manageDetainedLicensesToolStripMenuItem.Text = "       Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.BackColor = System.Drawing.Color.Linen;
            this.detainLicenseToolStripMenuItem.Image = global::Project_4_DVDL_System_.Properties.Resources.Detain_32;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(393, 36);
            this.detainLicenseToolStripMenuItem.Text = "       DetainLicense";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.BackColor = System.Drawing.Color.Linen;
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::Project_4_DVDL_System_.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(393, 36);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "       Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(378, 6);
            // 
            // smManageApplicationTypes
            // 
            this.smManageApplicationTypes.Image = global::Project_4_DVDL_System_.Properties.Resources.cv;
            this.smManageApplicationTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smManageApplicationTypes.Name = "smManageApplicationTypes";
            this.smManageApplicationTypes.Size = new System.Drawing.Size(381, 38);
            this.smManageApplicationTypes.Text = "       Manage Application Types";
            this.smManageApplicationTypes.Click += new System.EventHandler(this.smManageApplicationTypes_Click);
            // 
            // Sperator
            // 
            this.Sperator.Name = "Sperator";
            this.Sperator.Size = new System.Drawing.Size(378, 6);
            // 
            // smManageTestsTypes
            // 
            this.smManageTestsTypes.Image = global::Project_4_DVDL_System_.Properties.Resources.Schedule_Test_32;
            this.smManageTestsTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smManageTestsTypes.Name = "smManageTestsTypes";
            this.smManageTestsTypes.Size = new System.Drawing.Size(381, 38);
            this.smManageTestsTypes.Text = "       Manage Tests Types";
            this.smManageTestsTypes.Click += new System.EventHandler(this.smManageTestsTypes_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPeople.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnPeople.CustomBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPeople.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnPeople.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPeople.FillColor = System.Drawing.Color.Transparent;
            this.btnPeople.Font = new System.Drawing.Font("Palatino Linotype", 15.8F, System.Drawing.FontStyle.Bold);
            this.btnPeople.ForeColor = System.Drawing.Color.White;
            this.btnPeople.Location = new System.Drawing.Point(295, 71);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(228, 55);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Text = "People";
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click_1);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsers.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnUsers.CustomBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUsers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Font = new System.Drawing.Font("Palatino Linotype", 15.8F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(555, 71);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(228, 55);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDrivers.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnDrivers.CustomBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDrivers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnDrivers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDrivers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDrivers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrivers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDrivers.FillColor = System.Drawing.Color.Transparent;
            this.btnDrivers.Font = new System.Drawing.Font("Palatino Linotype", 15.8F, System.Drawing.FontStyle.Bold);
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Location = new System.Drawing.Point(822, 71);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(228, 55);
            this.btnDrivers.TabIndex = 3;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAccountSettings.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAccountSettings.ContextMenuStrip = this.guna2ContextMenuStrip2;
            this.btnAccountSettings.CustomBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAccountSettings.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnAccountSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccountSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnAccountSettings.Font = new System.Drawing.Font("Palatino Linotype", 15.8F, System.Drawing.FontStyle.Bold);
            this.btnAccountSettings.ForeColor = System.Drawing.Color.White;
            this.btnAccountSettings.Location = new System.Drawing.Point(1076, 71);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(228, 55);
            this.btnAccountSettings.TabIndex = 4;
            this.btnAccountSettings.Text = "Account Settings";
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // guna2ContextMenuStrip2
            // 
            this.guna2ContextMenuStrip2.BackColor = System.Drawing.Color.Linen;
            this.guna2ContextMenuStrip2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smCurrentUserInfo,
            this.toolStripSeparator8,
            this.smChangePassword,
            this.toolStripSeparator9,
            this.smSignOut});
            this.guna2ContextMenuStrip2.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.Goldenrod;
            this.guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.Goldenrod;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip2.Size = new System.Drawing.Size(313, 130);
            // 
            // smCurrentUserInfo
            // 
            this.smCurrentUserInfo.Image = global::Project_4_DVDL_System_.Properties.Resources.user_avatar__3_;
            this.smCurrentUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smCurrentUserInfo.Name = "smCurrentUserInfo";
            this.smCurrentUserInfo.Size = new System.Drawing.Size(312, 38);
            this.smCurrentUserInfo.Text = "         Current User Info";
            this.smCurrentUserInfo.Click += new System.EventHandler(this.smCurrentUserInfo_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(309, 6);
            // 
            // smChangePassword
            // 
            this.smChangePassword.BackColor = System.Drawing.Color.Linen;
            this.smChangePassword.Image = global::Project_4_DVDL_System_.Properties.Resources.reset_password;
            this.smChangePassword.Name = "smChangePassword";
            this.smChangePassword.Size = new System.Drawing.Size(312, 38);
            this.smChangePassword.Text = "       Change Password";
            this.smChangePassword.Click += new System.EventHandler(this.smChangePassword_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(309, 6);
            // 
            // smSignOut
            // 
            this.smSignOut.Image = global::Project_4_DVDL_System_.Properties.Resources.logout1;
            this.smSignOut.Name = "smSignOut";
            this.smSignOut.Size = new System.Drawing.Size(312, 38);
            this.smSignOut.Text = "       Sign Out";
            this.smSignOut.Click += new System.EventHandler(this.smSignOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(435, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1037, 84);
            this.label1.TabIndex = 9;
            this.label1.Text = " Driver and Vehicle Licensens Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(855, 663);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 137;
            this.label4.Text = "Version 1.0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Stencil", 23.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(675, 495);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 70);
            this.label3.TabIndex = 138;
            this.label3.Text = "(DVLD) System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1803, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccountSettings);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.btnApplications);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.guna2ContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnApplications;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem smManageApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem smDetainLicenses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem smManageApplicationTypes;
        private System.Windows.Forms.ToolStripSeparator Sperator;
        private System.Windows.Forms.ToolStripMenuItem smManageTestsTypes;
        private System.Windows.Forms.ToolStripMenuItem smNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem smRenewDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem smRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem smLocalLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem smInternationalLicense;
        private Guna.UI2.WinForms.Guna2Button btnPeople;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDrivers;
        private Guna.UI2.WinForms.Guna2Button btnAccountSettings;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem smCurrentUserInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem smChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem smSignOut;
        private System.Windows.Forms.ToolStripMenuItem SmManageLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem SmInternationalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem replacmentDamageOrLostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

