using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
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
                if (clsPerson.DeletePerson(_ApplicationIDFromDGV))
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
    }
}
