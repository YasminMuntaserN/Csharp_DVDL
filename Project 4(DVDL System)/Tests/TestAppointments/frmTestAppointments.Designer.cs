namespace Project_4_DVDL_System_.Tests.TestAppointments
{
    partial class frmTestAppointments
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
            this.tpAppointmentsList = new System.Windows.Forms.TabControl();
            this.tpApplicayionInfo = new System.Windows.Forms.TabPage();
            this.ctrlLocalApplication1 = new Project_4_DVDL_System_.Application.Local_Application.ctrlLocalApplication();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLicenseTestAppointments = new System.Windows.Forms.DataGridView();
            this.Menu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmsEditTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTestTypeImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.tpAppointmentsList.SuspendLayout();
            this.tpApplicayionInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAppointmentsList
            // 
            this.tpAppointmentsList.Controls.Add(this.tpApplicayionInfo);
            this.tpAppointmentsList.Controls.Add(this.tabPage2);
            this.tpAppointmentsList.Font = new System.Drawing.Font("Times New Roman", 12.2F);
            this.tpAppointmentsList.Location = new System.Drawing.Point(12, 133);
            this.tpAppointmentsList.Name = "tpAppointmentsList";
            this.tpAppointmentsList.SelectedIndex = 0;
            this.tpAppointmentsList.Size = new System.Drawing.Size(745, 553);
            this.tpAppointmentsList.TabIndex = 0;
            // 
            // tpApplicayionInfo
            // 
            this.tpApplicayionInfo.Controls.Add(this.ctrlLocalApplication1);
            this.tpApplicayionInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpApplicayionInfo.Location = new System.Drawing.Point(4, 31);
            this.tpApplicayionInfo.Name = "tpApplicayionInfo";
            this.tpApplicayionInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicayionInfo.Size = new System.Drawing.Size(737, 518);
            this.tpApplicayionInfo.TabIndex = 0;
            this.tpApplicayionInfo.Text = "Application Info";
            this.tpApplicayionInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlLocalApplication1
            // 
            this.ctrlLocalApplication1.Location = new System.Drawing.Point(3, 6);
            this.ctrlLocalApplication1.Name = "ctrlLocalApplication1";
            this.ctrlLocalApplication1.Size = new System.Drawing.Size(738, 548);
            this.ctrlLocalApplication1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRecordsCount);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAddNewAppointment);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvLicenseTestAppointments);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appointments List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(124, 330);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(30, 23);
            this.lblRecordsCount.TabIndex = 140;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 139;
            this.label2.Text = "# Records:";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAppointment.Image = global::Project_4_DVDL_System_.Properties.Resources.appointments__1_;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(631, 34);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(52, 44);
            this.btnAddNewAppointment.TabIndex = 138;
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 136;
            this.label1.Text = "Appointments:";
            // 
            // dgvLicenseTestAppointments
            // 
            this.dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenseTestAppointments.ContextMenuStrip = this.Menu;
            this.dgvLicenseTestAppointments.Location = new System.Drawing.Point(9, 84);
            this.dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            this.dgvLicenseTestAppointments.RowHeadersWidth = 51;
            this.dgvLicenseTestAppointments.RowTemplate.Height = 26;
            this.dgvLicenseTestAppointments.Size = new System.Drawing.Size(722, 210);
            this.dgvLicenseTestAppointments.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditTest,
            this.cmsTakeTest});
            this.Menu.Name = "Menu";
            this.Menu.RenderStyle.ArrowColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.Menu.RenderStyle.ColorTable = null;
            this.Menu.RenderStyle.RoundedEdges = true;
            this.Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.Menu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Menu.Size = new System.Drawing.Size(158, 64);
            // 
            // cmsEditTest
            // 
            this.cmsEditTest.ForeColor = System.Drawing.Color.White;
            this.cmsEditTest.Image = global::Project_4_DVDL_System_.Properties.Resources.setting1;
            this.cmsEditTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmsEditTest.Name = "cmsEditTest";
            this.cmsEditTest.Size = new System.Drawing.Size(157, 30);
            this.cmsEditTest.Text = "Edit Test";
            this.cmsEditTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmsEditTest.Click += new System.EventHandler(this.cmsEditTest_Click);
            // 
            // cmsTakeTest
            // 
            this.cmsTakeTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmsTakeTest.Image = global::Project_4_DVDL_System_.Properties.Resources.test;
            this.cmsTakeTest.Name = "cmsTakeTest";
            this.cmsTakeTest.Size = new System.Drawing.Size(157, 30);
            this.cmsTakeTest.Text = "Take Test";
            this.cmsTakeTest.Click += new System.EventHandler(this.cmsTakeTest_Click);
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.BackColor = System.Drawing.Color.Transparent;
            this.pbTestTypeImage.Image = global::Project_4_DVDL_System_.Properties.Resources.Vision_Test_32;
            this.pbTestTypeImage.ImageRotate = 0F;
            this.pbTestTypeImage.Location = new System.Drawing.Point(251, -3);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbTestTypeImage.Size = new System.Drawing.Size(231, 82);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTypeImage.TabIndex = 245;
            this.pbTestTypeImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(186, 67);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(423, 45);
            this.lblTitle.TabIndex = 165;
            this.lblTitle.Text = "Vision Test Appointments";
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
            this.btnClose.Location = new System.Drawing.Point(287, 688);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 45);
            this.btnClose.TabIndex = 179;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 737);
            this.Controls.Add(this.pbTestTypeImage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tpAppointmentsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTestAppointments";
            this.Text = "TestAppointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            this.tpAppointmentsList.ResumeLayout(false);
            this.tpApplicayionInfo.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpAppointmentsList;
        private System.Windows.Forms.TabPage tpApplicayionInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbTestTypeImage;
        private System.Windows.Forms.Label lblTitle;
        private Application.Local_Application.ctrlLocalApplication ctrlLocalApplication1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLicenseTestAppointments;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem cmsEditTest;
        private System.Windows.Forms.ToolStripMenuItem cmsTakeTest;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}