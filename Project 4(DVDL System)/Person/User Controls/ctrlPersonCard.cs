using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Person
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;
        private int? _PersonID;

        public clsPerson Person => _Person;
        public int? PersonID => _PersonID;

        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.man;
            else
                pbPersonImage.Image = Resources.woman;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillData()
        {
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblGendor.Text = _Person.GenderName;
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = clsFormat.DateToShort(_Person.DateOfBirth);
            lblAddress.Text = _Person.Address;

            _LoadPersonImage();

            lblCountry.Text = clsCountry.CountryNameByID(_Person.NationalityCountryID);

            llEditPersonInfo.Enabled = true;
        }

        public void LoadPersonInfo(int? personID)
        {
            _Person = clsPerson.Find(personID);

            if (_Person == null)
            {
                clsMessages.NotFound("person", personID);
                return;
            }
            _PersonID = personID;
            _FillData();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                clsMessages.NotFound("person",-1);
                return;
            }
            _PersonID = _Person.PersonID;
            _FillData();
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson editPerson = new frmAddEditPerson(_PersonID);
            editPerson.ShowDialog();

            // Refresh
            LoadPersonInfo(_PersonID);
        }

    }
}
