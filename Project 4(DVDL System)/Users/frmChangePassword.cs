using DVDL_BusinessLayer_;
using DVDL_HelperLayer_;
using Guna.UI2.WinForms;
using Project_4_DVDL_System_.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Users
{
    public partial class frmChangePassword : Form
    {
        private int? _UserID = null;
        private clsUser _User;

        public frmChangePassword(int? UserID)
        {
            InitializeComponent();
            _UserID = UserID;   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(_UserID);

            if( _User == null ) 
            {
                clsMessages.NotFound("Person" ,_UserID);
                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void _ResetFields()
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            txtCurrentPassword.Focus();
        }

        private void _ChangePassword()
        {
            _User.Password = txtNewPassword.Text;
            if (_User.Save())
            {
                clsMessages.GeneralSuccessMessage("Password Changed Successfully.");
                _ResetFields();
            }
            else
            {
                clsMessages.GeneralErrorMessage("An Error Occurred, Password did not change.");
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();
            if (string.IsNullOrEmpty(currentPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
            // Validate the current password against the stored hash
            if (_User.Password != clsGlobal.Encrypt(currentPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "The entered password is incorrect. Please try again.");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void _TextBox_TextChanged(object sender, EventArgs e)
        {
            ((Guna2TextBox)sender).UseSystemPasswordChar = true;
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "The password field cannot be empty. Please enter a new password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }

            if (clsGlobal.Encrypt(newPassword) == _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This password is the same as your current one. Please choose a different password.");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string confirmPassword = txtConfirmPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "The Confirm Password field cannot be empty. Please enter a new password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

            string newPassword = txtNewPassword.Text.Trim();

            if (confirmPassword != newPassword)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match. Please confirm your new password again.");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }


        private void frmChangePassword_Activated(object sender, EventArgs e)
        {
            txtCurrentPassword.Focus();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return;
            }
            _ChangePassword();
        }
    }
}
