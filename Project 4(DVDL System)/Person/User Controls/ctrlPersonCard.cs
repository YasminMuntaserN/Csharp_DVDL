using DVDL_BusinessLayer_;
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
            pbPersonImage.Image = (_Person.Gender == 0) ?Resources.man : Resources.woman;
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }
            else
            {
                pbPersonImage.Image = (_Person.Gender == 0) ? Resources.man : Resources.woman;
            }
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
