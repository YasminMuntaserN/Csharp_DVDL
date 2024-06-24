using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Application.Local_Application;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.Properties;
using Project_4_DVDL_System_.Tests.TestTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Tests.TestAppointments
{
    public partial class frmTestAppointments : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int? _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
        private int? _TestAppointmentID => (int?)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;
        public frmTestAppointments(int? LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {

                case clsTestType.enTestType.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Vision_Test_32;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Written_Test_32_Sechdule;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Street_Test_32;
                        break;
                    }
            }
        }

        private void _RefreshList()
        {

            ctrlLocalApplication1.LoadLocalApplicationInfo(_LocalDrivingLicenseApplicationID);
            _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, (int)_TestType);

            dgvLicenseTestAppointments.DataSource = _dtLicenseTestAppointments;
            lblRecordsCount.Text = dgvLicenseTestAppointments.Rows.Count.ToString();

            if (dgvLicenseTestAppointments.Rows.Count > 0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }

        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(_LocalDrivingLicenseApplicationID);

            // first we want to check if the person have an active Appointment 
            if (LocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                clsMessages.NotAllowed("Person Already have an active appointment for this test, You cannot add new appointment");
                return;
            }
            //then we check if the person have any test same as the The test type
            clsTest LastTest = LocalDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            if (LastTest == null)
            {
                frmAddEditScheduleTest frm1 = new frmAddEditScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
                frm1.ShowDialog();
                _RefreshList();
                return;
            }
            // else it have a test as the same type with Test Type we want ti check if the result of this test passed or not
            if (LastTest.TestResult == true)
            {
                clsMessages.NotAllowed("This person already passed this test before, you can only retake Felid test");
                return;
            }

            frmAddEditScheduleTest frmAddEditScheduleTest =new frmAddEditScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
            frmAddEditScheduleTest.ShowDialog();
            _RefreshList();
        }

        private void cmsEditTest_Click(object sender, EventArgs e)
        {
            frmAddEditScheduleTest frm = new frmAddEditScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, _TestAppointmentID);
            frm.ShowDialog();
            _RefreshList(); 
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();


            ctrlLocalApplication1.LoadLocalApplicationInfo(_LocalDrivingLicenseApplicationID);
            _RefreshList();

        }
    }
}
