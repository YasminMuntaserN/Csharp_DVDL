namespace Project_4_DVDL_System_.Login
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.llCreateAccount = new System.Windows.Forms.LinkLabel();
            this.chkRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDarkMobe = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LightMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcom Back !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(58, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login into";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(189, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "DVDL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(290, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "System";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUserName.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUserName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtUserName.Location = new System.Drawing.Point(63, 312);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
            this.txtUserName.PlaceholderText = "Username";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(326, 55);
            this.txtUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TextOffset = new System.Drawing.Point(10, 0);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingOfTextBoxes);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtPassword.Location = new System.Drawing.Point(63, 396);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(326, 55);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingOfTextBoxes);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(211)))), ((int)(((byte)(159)))));
            this.btnLogin.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.btnLogin.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.FillColor2 = System.Drawing.Color.SeaGreen;
            this.btnLogin.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.HoverState.FillColor2 = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(62, 500);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(327, 52);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llCreateAccount
            // 
            this.llCreateAccount.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.llCreateAccount.AutoSize = true;
            this.llCreateAccount.Font = new System.Drawing.Font("Sitka Heading", 16F, System.Drawing.FontStyle.Bold);
            this.llCreateAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llCreateAccount.LinkColor = System.Drawing.Color.SeaGreen;
            this.llCreateAccount.Location = new System.Drawing.Point(118, 566);
            this.llCreateAccount.Name = "llCreateAccount";
            this.llCreateAccount.Size = new System.Drawing.Size(198, 39);
            this.llCreateAccount.TabIndex = 12;
            this.llCreateAccount.TabStop = true;
            this.llCreateAccount.Text = "Create Account";
            this.llCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCreateAccount_LinkClicked);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkRememberMe.CheckedState.BorderRadius = 0;
            this.chkRememberMe.CheckedState.BorderThickness = 0;
            this.chkRememberMe.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.chkRememberMe.CheckMarkColor = System.Drawing.Color.SeaGreen;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.ForeColor = System.Drawing.Color.White;
            this.chkRememberMe.Location = new System.Drawing.Point(144, 622);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(165, 32);
            this.chkRememberMe.TabIndex = 13;
            this.chkRememberMe.Text = "Remeber Me ?";
            this.chkRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRememberMe.UncheckedState.BorderRadius = 0;
            this.chkRememberMe.UncheckedState.BorderThickness = 0;
            this.chkRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDarkMobe
            // 
            this.btnDarkMobe.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDarkMobe.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDarkMobe.Image = global::Project_4_DVDL_System_.Properties.Resources.dots;
            this.btnDarkMobe.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDarkMobe.ImageRotate = 0F;
            this.btnDarkMobe.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDarkMobe.Location = new System.Drawing.Point(383, 1);
            this.btnDarkMobe.Name = "btnDarkMobe";
            this.btnDarkMobe.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDarkMobe.Size = new System.Drawing.Size(56, 48);
            this.btnDarkMobe.TabIndex = 14;
            this.btnDarkMobe.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Project_4_DVDL_System_.Properties.Resources.Screenshot__22__removebg_preview;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(64, 61);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(308, 113);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // ToggleSwitch
            // 
            this.ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch.Location = new System.Drawing.Point(137, 5);
            this.ToggleSwitch.Name = "ToggleSwitch";
            this.ToggleSwitch.Size = new System.Drawing.Size(60, 23);
            this.ToggleSwitch.TabIndex = 15;
            this.ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch.CheckedChanged += new System.EventHandler(this.ToggleSwitch_CheckedChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.LightMode);
            this.guna2Panel1.Controls.Add(this.ToggleSwitch);
            this.guna2Panel1.Location = new System.Drawing.Point(196, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 36);
            this.guna2Panel1.TabIndex = 16;
            this.guna2Panel1.Visible = false;
            // 
            // LightMode
            // 
            this.LightMode.AutoSize = true;
            this.LightMode.Font = new System.Drawing.Font("Verdana", 12.2F);
            this.LightMode.ForeColor = System.Drawing.SystemColors.Window;
            this.LightMode.Location = new System.Drawing.Point(3, 5);
            this.LightMode.Name = "LightMode";
            this.LightMode.Size = new System.Drawing.Size(128, 25);
            this.LightMode.TabIndex = 16;
            this.LightMode.Text = "Light Mode";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(428, 679);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnDarkMobe);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.llCreateAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.LinkLabel llCreateAccount;
        private Guna.UI2.WinForms.Guna2CheckBox chkRememberMe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ImageButton btnDarkMobe;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label LightMode;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch;
    }
}