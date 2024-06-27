namespace Project_4_DVDL_System_.Tests
{
    partial class frmTakeTest
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
            this.ctrlScheduledTest1 = new Project_4_DVDL_System_.Tests.TestAppointments.ctrlScheduledTest();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPass = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnFail = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlScheduledTest1
            // 
            this.ctrlScheduledTest1.Location = new System.Drawing.Point(12, 12);
            this.ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            this.ctrlScheduledTest1.Size = new System.Drawing.Size(580, 572);
            this.ctrlScheduledTest1.TabIndex = 0;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(312, 595);
            this.lblUserMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(304, 25);
            this.lblUserMessage.TabIndex = 209;
            this.lblUserMessage.Text = "You cannot change the results";
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserMessage.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(148, 631);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(408, 91);
            this.txtNotes.TabIndex = 206;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 631);
            this.label10.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 25);
            this.label10.TabIndex = 202;
            this.label10.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 595);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 200;
            this.label8.Text = "Result:";
            // 
            // btnPass
            // 
            this.btnPass.AutoSize = true;
            this.btnPass.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.btnPass.CheckedState.BorderThickness = 0;
            this.btnPass.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.btnPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnPass.CheckedState.InnerOffset = -4;
            this.btnPass.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnPass.Location = new System.Drawing.Point(148, 591);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(70, 30);
            this.btnPass.TabIndex = 210;
            this.btnPass.Text = "Pass";
            this.btnPass.UncheckedState.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPass.UncheckedState.BorderThickness = 4;
            this.btnPass.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnPass.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnFail
            // 
            this.btnFail.AutoSize = true;
            this.btnFail.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.btnFail.CheckedState.BorderThickness = 0;
            this.btnFail.CheckedState.FillColor = System.Drawing.Color.Silver;
            this.btnFail.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnFail.CheckedState.InnerOffset = -4;
            this.btnFail.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnFail.Location = new System.Drawing.Point(224, 591);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(67, 30);
            this.btnFail.TabIndex = 211;
            this.btnFail.Text = "Fail";
            this.btnFail.UncheckedState.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFail.UncheckedState.BorderThickness = 4;
            this.btnFail.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFail.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Project_4_DVDL_System_.Properties.Resources.presentation;
            this.pictureBox7.Location = new System.Drawing.Point(100, 631);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 203;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_4_DVDL_System_.Properties.Resources.test__1_;
            this.pictureBox4.Location = new System.Drawing.Point(100, 595);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 201;
            this.pictureBox4.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(383, 742);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 45);
            this.btnClose.TabIndex = 212;
            this.btnClose.Text = "Close";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Project_4_DVDL_System_.Properties.Resources.bookmark;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(199, 742);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 45);
            this.guna2Button1.TabIndex = 213;
            this.guna2Button1.Text = "Save";
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 799);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ctrlScheduledTest1);
            this.Name = "frmTakeTest";
            this.Text = "Take Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TestAppointments.ctrlScheduledTest ctrlScheduledTest1;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2RadioButton btnPass;
        private Guna.UI2.WinForms.Guna2RadioButton btnFail;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}