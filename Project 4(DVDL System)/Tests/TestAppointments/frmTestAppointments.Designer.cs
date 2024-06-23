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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pbTestTypeImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tpAppointmentsList.SuspendLayout();
            this.tpApplicayionInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAppointmentsList
            // 
            this.tpAppointmentsList.Controls.Add(this.tpApplicayionInfo);
            this.tpAppointmentsList.Controls.Add(this.tabPage2);
            this.tpAppointmentsList.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tpAppointmentsList.Location = new System.Drawing.Point(0, 104);
            this.tpAppointmentsList.Name = "tpAppointmentsList";
            this.tpAppointmentsList.SelectedIndex = 0;
            this.tpAppointmentsList.Size = new System.Drawing.Size(595, 572);
            this.tpAppointmentsList.TabIndex = 0;
            // 
            // tpApplicayionInfo
            // 
            this.tpApplicayionInfo.Controls.Add(this.ctrlLocalApplication1);
            this.tpApplicayionInfo.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpApplicayionInfo.Location = new System.Drawing.Point(4, 27);
            this.tpApplicayionInfo.Name = "tpApplicayionInfo";
            this.tpApplicayionInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicayionInfo.Size = new System.Drawing.Size(587, 541);
            this.tpApplicayionInfo.TabIndex = 0;
            this.tpApplicayionInfo.Text = "Application Info";
            this.tpApplicayionInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlLocalApplication1
            // 
            this.ctrlLocalApplication1.Location = new System.Drawing.Point(1, 6);
            this.ctrlLocalApplication1.Name = "ctrlLocalApplication1";
            this.ctrlLocalApplication1.Size = new System.Drawing.Size(583, 546);
            this.ctrlLocalApplication1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRecordsCount);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAddNewAppointment);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvLicenseTestAppointments);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appointments List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(106, 347);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(22, 18);
            this.lblRecordsCount.TabIndex = 140;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 139;
            this.label2.Text = "# Records:";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAppointment.Image = global::Project_4_DVDL_System_.Properties.Resources.appointments;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(473, 34);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(76, 62);
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
            this.dgvLicenseTestAppointments.Location = new System.Drawing.Point(9, 102);
            this.dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            this.dgvLicenseTestAppointments.RowHeadersWidth = 51;
            this.dgvLicenseTestAppointments.RowTemplate.Height = 26;
            this.dgvLicenseTestAppointments.Size = new System.Drawing.Size(576, 210);
            this.dgvLicenseTestAppointments.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 50;
            this.guna2CustomGradientPanel1.BorderThickness = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.pbTestTypeImage);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTitle);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-13, -23);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(621, 88);
            this.guna2CustomGradientPanel1.TabIndex = 178;
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.BackColor = System.Drawing.Color.Transparent;
            this.pbTestTypeImage.Image = global::Project_4_DVDL_System_.Properties.Resources.Vision_Test_32;
            this.pbTestTypeImage.ImageRotate = 0F;
            this.pbTestTypeImage.Location = new System.Drawing.Point(30, 27);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbTestTypeImage.Size = new System.Drawing.Size(89, 58);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTypeImage.TabIndex = 245;
            this.pbTestTypeImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(136, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(423, 45);
            this.lblTitle.TabIndex = 165;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 688);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.tpAppointmentsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTestAppointments";
            this.Text = "frmTestAppointments";
            this.tpAppointmentsList.ResumeLayout(false);
            this.tpApplicayionInfo.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpAppointmentsList;
        private System.Windows.Forms.TabPage tpApplicayionInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbTestTypeImage;
        private System.Windows.Forms.Label lblTitle;
        private Application.Local_Application.ctrlLocalApplication ctrlLocalApplication1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLicenseTestAppointments;
    }
}