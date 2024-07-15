using DVDL_BusinessLayer_;
using Guna.UI2.WinForms;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.Properties;
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

namespace Project_4_DVDL_System_.Person
{
    public partial class frmAddEditPerson : Form
    {
        public Action<int?> PersonIDBack;

        private enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        private int?_PersonID = null;
        private clsPerson _Person = null;

        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddEditPerson(int? PersonID)
        {
           _PersonID = PersonID;   
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person";
               _Person = new clsPerson();
            }
            else
            {
                this.Text = "Update Person";
                lblTitle.Text = "Update Person";
            }
        }

        private void _FillPersonInfoInField()
        {
            lblPersonID.Text =_Person.PersonID.ToString();
            txtNationalNo.Text =_Person.NationalNo;
            txtFirstName.Text =_Person.FirstName;
            txtSecondName.Text =_Person.SecondName;
            txtThirdName.Text =_Person.ThirdName;
            txtLastName.Text =_Person.LastName;
            txtEmail.Text =_Person.Email;
            txtAddress.Text =_Person.Address;
            txtPhone.Text =_Person.Phone;
            dtpDateOfBirth.Value =_Person.DateOfBirth;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);
            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;

            }
            llRemoveImage.Visible = (_Person.ImagePath != "");

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }

        private void _LoadData()
        {
           _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                clsMessages.NotFound("person",_PersonID);

                this.Close();
                return;
            }

            _FillPersonInfoInField();
        }

        private void _FillPersonObjectWithFieldsData()
        {
           _Person.FirstName = txtFirstName.Text.Trim();
           _Person.SecondName = txtSecondName.Text.Trim();
           _Person.ThirdName = string.IsNullOrWhiteSpace(txtThirdName.Text.Trim()) ? null : txtThirdName.Text.Trim();
           _Person.LastName = txtLastName.Text.Trim();
           _Person.NationalNo = txtNationalNo.Text.Trim();
           _Person.Email = string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) ? null : txtEmail.Text.Trim();
           _Person.Address = txtAddress.Text.Trim();
           _Person.Phone = txtPhone.Text.Trim();
           _Person.Gender = (rbMale.Checked) ? (byte)0 : (byte)1;
           _Person.DateOfBirth = dtpDateOfBirth.Value;
           _Person.NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";
        }

        private void _Save()
        {
            _FillPersonObjectWithFieldsData();

            if (_Person.Save())
            {
                lblTitle.Text = "Update Person";
                this.Text = lblTitle.Text;
                lblPersonID.Text = _Person.PersonID.ToString();

                // change form mode to update
                _Mode = enMode.Update;

                clsMessages.OperationDoneSuccessfully("Saved");

                // Trigger the event to send data back to the caller form
                PersonIDBack?.Invoke(_Person?.PersonID);
            }
            else
            {
                clsMessages.OperationFelid("Saved");
            }
        }

        private bool _CheckCorrectData()
        {
            if(!rbFemale.Checked && !rbMale.Checked)
            {
                errorProvider1.SetError(rbFemale, "You must select Gender");
                return false;
            }
            if(cbCountry.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbCountry, "You must select Country");
                return false;
            }
            return true;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _FillCountriesInComboBox();

            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = Resources.user__1_;
            llRemoveImage.Visible = false;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }

            //validate email format
            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!_CheckCorrectData()) return;

            if (!ValidateChildren())
            {
                clsMessages.ValidationErrorMessage();
                return;
            }

            _Save();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
