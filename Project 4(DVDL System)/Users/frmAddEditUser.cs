using DVDL_BusinessLayer_;
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
using TheArtOfDevHtmlRenderer.Adapters;

namespace Project_4_DVDL_System_.Users
{
    public partial class frmAddEditUser : Form
    {
        public Action<int?> UserIDBack;
        private enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        private int? _UserID = null;
        private clsUser _User = null;

        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.Add; 
        }

        public frmAddEditUser(int? UserID)
        {
            _UserID = UserID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
            }
            else
            {
                this.Text = "Update User";
                lblTitle.Text = "Update User";
            }
        }

        private void _FillUserInfoInField()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;   
         }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                clsMessages.NotFound("User", _UserID);

                this.Close();
                return;
            }

            _FillUserInfoInField();
        }

        private void _FillUserObjectWithFieldsData()
        {
            _User.PersonID=ctrlPersonCardWithFilter1.PersonInfo.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = cbIsActive.Checked;
        }

        private bool _CheckForCorrectData()
        {
            if (ctrlPersonCardWithFilter1.PersonInfo == null)
            {
                TcUser.SelectedTab = tabPagePersonalInfo;
                clsMessages.GeneralErrorMessage("You have to select a person first!");
                return false;
            }

            if ( _Mode==enMode.Add && clsUser.DoesUserExist(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Username has already been used!");
                return false;
            }

            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "The password confirmation field does not match the password");
                return false;
            }


            if (!this.ValidateChildren())
            {
               clsMessages.ValidationErrorMessage();
                return false;
            }

            return true;
        }

        private void _Save()
        {
            _FillUserObjectWithFieldsData();

            if (_User.Save())
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;
                lblUserID.Text = _User.UserID.ToString();

                // change form mode to update
                _Mode = enMode.Update;

                clsMessages.OperationDoneSuccessfully("Saved");

                // Trigger the event to send data back to the caller form
                UserIDBack?.Invoke(_User?.UserID);
            }
            else
            {
                clsMessages.OperationFelid("Saved");
            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private bool _IsUserCorrect()
        {
            if (ctrlPersonCardWithFilter1.PersonInfo == null)
            {
                TcUser.SelectedTab = tabPagePersonalInfo;
                clsMessages.GeneralErrorMessage("You have to select a person first!");
                return false;
            }
            if (_Mode == enMode.Add && clsUser.DoesUserExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
            {
                clsMessages.GeneralErrorMessage("Selected Person already has a user, choose another one");
                return false;
            }

            return true;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (!_IsUserCorrect())
            {
                btnSave.Enabled = false;
                tabPageUserInfo.Enabled = false;
                return;
            }
            else
            {
                TcUser.SelectedTab = TcUser.TabPages["tabPageUserInfo"];
                btnSave.Enabled = true;
                tabPageUserInfo.Enabled = true;
            }
        }


        private void txtUserName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtConfirmPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_CheckForCorrectData())
            {
                return;
            }

            _Save();
        }
    }
}
