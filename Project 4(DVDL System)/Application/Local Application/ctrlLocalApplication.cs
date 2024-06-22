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
using static System.Net.Mime.MediaTypeNames;

namespace Project_4_DVDL_System_.Application.Local_Application
{
    public partial class ctrlLocalApplication : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalApplication;
        private int? _LocalApplicationID;

        public clsLocalDrivingLicenseApplication LocalApplication => _LocalApplication;
        public int? LocalApplicationID => _LocalApplicationID;

        public ctrlLocalApplication()
        {
            InitializeComponent();
        }

        private void _FillData()
        {
            ctrlApplication1.LoadApplicationInfo(_LocalApplication.ApplicationID);
            lblLocalDrivingLicenseApplicationID.Text = _LocalApplicationID.ToString();
            lblAppliedFor.Text =clsLicenseClass.Find(_LocalApplication.LicenseClassID).ClassName;
            lblPassedTests.Text = clsTest.PassedTestCount(_LocalApplicationID).ToString()+"/3";
        }

        public void LoadLocalApplicationInfo(int? LocalApplicationID)
        {
            _LocalApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalApplicationID);

            if (_LocalApplication == null)
            {
                clsMessages.NotFound("Local Driving License Application", LocalApplicationID);
                return;
            }
            _LocalApplicationID = LocalApplicationID;
            _FillData();
        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
