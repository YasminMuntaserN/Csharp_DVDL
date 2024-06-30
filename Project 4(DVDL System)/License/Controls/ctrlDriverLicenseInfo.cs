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

namespace Project_4_DVDL_System_.License
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int? _LicenseID = null;
        private clsLicense _License = null;

        public int? LicenseID => _LicenseID;
        public clsLicense License => _License;

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage(clsApplication application)
        {
            if (application.PersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.man;
            else
                pbPersonImage.Image = Resources.woman;

            string ImagePath = application.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);

        }

        private bool _FillLicenseInfoInFields()
        {
            lblClass.Text = clsLicenseClass.Find(_License.LicenseClass).ClassName;
            clsApplication application = clsApplication.Find(_License.ApplicationID);
            if (application == null) return false;
            lblName.Text = application.PersonName;
            lblNationalNo.Text = application.PersonInfo.NationalNo;
            lblGender.Text = application.PersonInfo.GenderName;
            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lblIssueReason.Text = clsLicense.GetIssueReasonText(_License.IssueReason);
            lblNotes.Text = _License.Notes;
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = clsFormat.DateToShort(application.PersonInfo.DateOfBirth);
            lblExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblDriverID.Text = _License.DriverID.ToString();
            lblIsDetainad.Text = "Return Back";
            _LoadPersonImage(application);
            return true;
        }

        public void LoadLicenseInfo(int? LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.Find(LicenseID);

            if (_License == null)
            {
                clsMessages.NotFound("License", LicenseID);
                _LicenseID = -1;
                return;
            }
            lblLicenseID.Text = _License.LicenseID.ToString();
            _FillLicenseInfoInFields();
        }

    }
}
