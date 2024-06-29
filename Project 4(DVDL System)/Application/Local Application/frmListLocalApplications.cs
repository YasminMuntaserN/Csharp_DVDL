using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.License;
using Project_4_DVDL_System_.Tests.TestAppointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DVDL_BusinessLayer_.clsTestType;

namespace Project_4_DVDL_System_.Application.Local_Application
{
    public partial class frmListLocalApplications : Form
    {
        private DataTable _dtAllApplication = new DataTable();

        private int? _ApplicationIDFromDGV => (int?)dgvApplications.CurrentRow.Cells[0].Value;
        public frmListLocalApplications()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {
            cbFilter.SelectedIndex = 0;

            _dtAllApplication = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

            dgvApplications.DataSource = _dtAllApplication;

            if (dgvApplications.Rows.Count > 0)
            {

                dgvApplications.Columns[0].HeaderText = "ID";
                dgvApplications.Columns[0].Width = 90;

                dgvApplications.Columns[1].HeaderText = "Class Name";
                dgvApplications.Columns[1].Width = 200;

                dgvApplications.Columns[2].HeaderText = "National No";
                dgvApplications.Columns[2].Width = 150;

                dgvApplications.Columns[3].HeaderText = "Full Name";
                dgvApplications.Columns[3].Width = 170;

                dgvApplications.Columns[4].HeaderText = "Passed Test";
                dgvApplications.Columns[4].Width = 130;

                dgvApplications.Columns[5].HeaderText = "Status";
                dgvApplications.Columns[5].Width = 110;
            }

        }

        private void frmListLocalApplications_Load(object sender, EventArgs e)
        {
            _RefreshList();

            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None" && cbFilter.Text != "Status" && cbFilter.Text != "ClassName");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
   
        private string _GetRealColumnName()
        {
            switch (cbFilter.Text.Trim())
            {
                case "ID":
                    return "LocalDrivingLicenseApplicationID";

                case "National No":
                    return "NationalNo";

                case "Name":
                    return "FullName";

                default:
                    return "None";
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllApplication == null || _dtAllApplication.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnName();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllApplication.DefaultView.RowFilter = "";
                return;
            }

            if (cbFilter.Text == "ID")
            {
                // search with numbers
                _dtAllApplication.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtAllApplication.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtFilterValue.Text.Trim());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditLocalApplication frm=new frmAddEditLocalApplication();
            frm.ShowDialog();
            _RefreshList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmsAddApplication_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();  
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            frmAddEditLocalApplication frm = new frmAddEditLocalApplication(_ApplicationIDFromDGV);
            frm.ShowDialog();
            _RefreshList();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {

            if (clsMessages.conformDeleted("Local Driving License Application ", _ApplicationIDFromDGV))
            {
                //Perform Delete and refresh
                if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(_ApplicationIDFromDGV))
                {
                    clsMessages.OperationDoneSuccessfully("Deleted");
                    _RefreshList();
                }

                else
                    clsMessages.OperationFelid("Deleted");
            }
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            frmLocalApplicationDetails frm = new frmLocalApplicationDetails(_ApplicationIDFromDGV);
            frm.ShowDialog();
            _RefreshList();

        }

        private void cmsCancelApplication_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(_ApplicationIDFromDGV);

            if (clsLocalDrivingLicenseApplication.UpdateStatus(LocalDrivingLicenseApplication.ApplicationID, (byte)clsApplication.enStatus.Cancelled))
            {
                clsMessages.GeneralSuccessMessage("Application Cancelled Successfully.");
                _RefreshList();
            }
            else
            {
                clsMessages.GeneralErrorMessage("Could not cancel Application");
            }

        }

        private bool _GetTest(clsTestType.enTestType testType , string TestName)
        {
            frmTestAppointments frm = new frmTestAppointments(_ApplicationIDFromDGV, testType);
            frm.ShowDialog();
            //refresh
            _RefreshList();
            return true;
        }

        private void cmsSechduleVisionTest_Click(object sender, EventArgs e)
        {
            if (!_GetTest(clsTestType.enTestType.VisionTest , "Vision Test")) return;
        }

        private void cmsScheduleStreetTest_Click(object sender, EventArgs e)
        {
            if (!clsLocalDrivingLicenseApplication.DoesPassTestType(_ApplicationIDFromDGV, clsTestType.enTestType.WrittenTest))
            {
                MessageBox.Show("Person Should Pass the Written Test First!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_GetTest(clsTestType.enTestType.StreetTest, "Street Test")) return;

        }

        private void cmsScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            if (!clsLocalDrivingLicenseApplication.DoesPassTestType(_ApplicationIDFromDGV, clsTestType.enTestType.VisionTest))
            {
                clsMessages.NotAllowed("Person Should Pass the Vision Test First!");
                return;
            }

            if (!_GetTest(clsTestType.enTestType.WrittenTest, "Written Test")) return;

        }

        private void PerformEnabledChoice(clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication)
        {

            int TotalPassedTests = (int)dgvApplications.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            cmsIssueLicense.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            cmsShowLicense.Enabled = LicenseExists;

            cmsShowpersonLicenseHistory.Enabled = LicenseExists;

            cmsEdit.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == (byte)clsApplication.enStatus.New);

            cmsTests.Enabled = !LicenseExists;
        }

        private void PreformEnabledOptionFromScheduledTestMenu(clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication)
        {
            //Enable Disable Schedule Menu and it's sub Menu
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            cmsTests.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == (byte)clsApplication.enStatus.New);

            if (cmsTests.Enabled)
            {
                //To Allow Schedule vision test, Person must not passed the same test before.
                cmsScheduleVisionTest.Enabled = !PassedVisionTest;

                //To Allow Schedule written test, Person must pass the vision test and must not passed the same test before.
                cmsScheduleWrittenTest.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schedule Street test, Person must pass the vision * written tests, and must not passed the same test before.
                cmsScheduleStreetTest.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }
        }
     
        private void Menu_Opening(object sender, CancelEventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
            clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(_ApplicationIDFromDGV);

            PerformEnabledChoice(LocalDrivingLicenseApplication);

            PreformEnabledOptionFromScheduledTestMenu(LocalDrivingLicenseApplication);
        }

        private void cmsIssueLicense_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicense frmIssueDriverLicense = new frmIssueDriverLicense(_ApplicationIDFromDGV);
            frmIssueDriverLicense.ShowDialog();
            _RefreshList(); 
        }

        private void cmsShowLicense_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(
               LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmShowIssueDrivingLicenseDetails frm = new frmShowIssueDrivingLicenseDetails(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
