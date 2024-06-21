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
using System.Web.Hosting;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Application.Local_Application
{
    public partial class frmAddEditLocalApplication : Form
    {
        public Action<int?> ApplicationIDBack;
        private enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        private int? _ApplicationID = null;
        private clsLocalDrivingLicenseApplication _LocalApplication = null;

        private void _FillLicenseClassesInComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }
        }

        private void setDefaultValues()
        {
            cbLicenseClass.SelectedIndex = 2;
            lblFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewLocalDrivingLicense).ApplicationFees.ToString();
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = "Admin";
        }

        private void _ResetTitles()
        {
            _FillLicenseClassesInComboBox();
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Local Driving License Application";
                this.Text = "Add New Local Driving License Application";
                _LocalApplication = new clsLocalDrivingLicenseApplication();
                setDefaultValues();
            }
            else
            {
                this.Text = "Update Local Driving License Application";
                lblTitle.Text = "Update Local Driving License Application";
            }
        }

        public frmAddEditLocalApplication()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddEditLocalApplication(int? ID)
        {
            _ApplicationID = ID;    
            InitializeComponent();
            _Mode = enMode.Update;

        }

        private void _FillApplicationInfoInField()
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalApplication.ApplicantPersonID);
            lblLocalApplicationD.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = clsFormat.DateToShort(_LocalApplication.ApplicationDate);
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(clsLicenseClass.Find(_LocalApplication.LicenseClassID).ClassName);
            lblFees.Text = _LocalApplication.PaidFees.ToString();
            lblCreatedByUser.Text = clsUser.Find(_LocalApplication.CreatedByUserID).UserName;

        }

        private void _LoadData()
        {
            _LocalApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(_ApplicationID);

            if (_LocalApplication == null)
            {
                clsMessages.NotFound("Local Driving License Application", _ApplicationID);

                this.Close();
                return;
            }

            _FillApplicationInfoInField();
        }

        private void _FillApplicationObjectWithFieldsData()
        {
            _LocalApplication.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID; 
            _LocalApplication.ApplicationDate = DateTime.Now;
            _LocalApplication.ApplicationTypeID = 1;
            _LocalApplication.ApplicationStatus = (byte)clsApplication.enStatus.New;
            _LocalApplication.LastStatusDate = DateTime.Now;
            _LocalApplication.PaidFees = Convert.ToDecimal(lblFees.Text);
            _LocalApplication.CreatedByUserID = 3;
            _LocalApplication.LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;
        }

        private bool _CheckForCorrectData()
        {
            if (ctrlPersonCardWithFilter1.PersonInfo == null)
            {
                TcApplication.SelectedTab = tabPagePersonalInfo;
                clsMessages.GeneralErrorMessage("You have to select a person first!");
                return false;
            }

            int? LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;


            int? ActiveApplicationID = clsLocalDrivingLicenseApplication.GetActiveApplicationIDForLicenseClass(LicenseClassID,ctrlPersonCardWithFilter1.PersonID, 1);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
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
            _FillApplicationObjectWithFieldsData();

            if (_LocalApplication.Save())
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = lblTitle.Text;
                lblLocalApplicationD.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();

                // change form mode to update
                _Mode = enMode.Update;

                clsMessages.OperationDoneSuccessfully("Saved");

                // Trigger the event to send data back to the caller form
                ApplicationIDBack?.Invoke(_LocalApplication?.LocalDrivingLicenseApplicationID);
            }
            else
            {
                clsMessages.OperationFelid("Saved");
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            TcApplication.SelectedTab = TcApplication.TabPages["tpApplicationInfo"];
        }

        private void frmAddEditLocalApplication_Load(object sender, EventArgs e)
        {
            _ResetTitles();

            if (_Mode == enMode.Update)
                _LoadData();
        }
    }
}
