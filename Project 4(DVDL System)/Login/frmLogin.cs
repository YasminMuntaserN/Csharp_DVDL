using DVDL_BusinessLayer_;
using Guna.UI2.WinForms;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_4_DVDL_System_.Login
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return;
            }

            string HashedPassword = clsGlobal.ComputeHash(txtPassword.Text.Trim());

            if (!clsUser.DoesUserExist(txtUserName.Text.Trim(), HashedPassword))
            {
                txtUserName.Focus();
                clsMessages.GeneralErrorMessage("Invalid Username/Password.");
                return;
            }

            clsUser User = clsUser.Find(txtUserName.Text.Trim(), HashedPassword);

            if (User == null)
            {
                txtUserName.Focus();
                clsMessages.GeneralErrorMessage("Invalid Username/Password.");
                return;
            }

            if (chkRememberMe.Checked)
            {
                //store username and password
                clsGlobal.RememberUsernameAndPassword
                    (txtUserName.Text.Trim(), clsGlobal.Encrypt(txtPassword.Text.Trim()));
            }
            else
            {
                //remove username and password
                clsGlobal.RemoveStoredCredential();
            }

            if (!User.IsActive)
            {
                txtUserName.Focus();

                MessageBox.Show("Your account is not Active, Contact Admin.",
                    "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.CurrentUser = User;
            this.Hide();
            frmMainMenu OpenMainMenu = new frmMainMenu(this);
            OpenMainMenu.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = clsGlobal.Decrypt(Password);
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void ValidatingOfTextBoxes(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((Guna2TextBox)sender).Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(((Guna2TextBox)sender), "This field is required!");
            }
            else
            {
                errorProvider1.SetError(((Guna2TextBox)sender), null);
            }
        }

        private void llCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser();

            frmAddEditUser.UserIDBack = OnUserIDBack;
            frmAddEditUser.ShowDialog();

        }

        private void OnUserIDBack(int? userId)
        {
            if (userId.HasValue)
            {
                clsUser user =clsUser.Find(userId);
                    txtUserName.Text = user.UserName;
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)=> guna2Panel1.Visible = true;

        private void setLightMode()
        {
            this.BackColor = Color.White;
            label1.ForeColor =label2.ForeColor = label4.ForeColor = chkRememberMe.ForeColor =Color.Black;
            guna2Panel1.Visible = btnDarkMobe.Visible = false;
        }

        private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)=> setLightMode();

    }
}
