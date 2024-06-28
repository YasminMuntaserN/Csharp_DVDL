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

namespace Project_4_DVDL_System_.License
{
    public partial class frmIssueDriverLicense : Form
    {
        private int? _LocalDrivingApplicationID;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public frmIssueDriverLicense(int? localDrivingApplication)
        {
            InitializeComponent();
            _LocalDrivingApplicationID = localDrivingApplication;
        }

        private bool _AppliedForLicence()
        {

            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication
                (_LocalDrivingApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                clsMessages.NotFound("Local Driving License Application", _LocalDrivingApplicationID);
                this.Close();
                return false;
            }


            if (!_LocalDrivingLicenseApplication.PassedAllTests(_LocalDrivingApplicationID))
            {
                clsMessages.GeneralSuccessMessage("Person Should Pass All Tests First.");
                this.Close();
                return false;
            }

            int LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();
            if (LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }

            return true;
        }

        private void frmIssueDriverLicense_Load(object sender, EventArgs e)
        {
            if (!_AppliedForLicence()) { return; }

            ctrlLocalApplication1.LoadLocalApplicationInfo(_LocalDrivingApplicationID);
        }

        private void btnIssue_Click_1(object sender, EventArgs e)
        {
            int? LicenseID = _LocalDrivingLicenseApplication.IssueLicenseForTheFirstTime(txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                clsMessages.GeneralSuccessMessage("License Issued Successfully");
                this.Close();
            }
            else
            {
                clsMessages.GeneralErrorMessage("License Was not Issued ! ");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
