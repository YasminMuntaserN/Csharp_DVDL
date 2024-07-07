using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.License;
using Project_4_DVDL_System_.License.Controls;
using Project_4_DVDL_System_.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Application.International_License_Application
{
    public partial class frmListInternationalLicenses : Form
    {
        private DataTable _dtInternationalLicenseApplications;

        private int ?_DriverID => (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
        private int? _PersonID => clsDriver.Find(_DriverID).PersonID;

        private void _RefreshList()
        {
            _dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
            cbFilter.SelectedIndex = 0;

            dgvInternationalLicenses.DataSource = _dtInternationalLicenseApplications;

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 160;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 150;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 130;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[3].Width = 130;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 180;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 180;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 120;

            }
        }

        public frmListInternationalLicenses()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenseApplication application =
                new frmAddInternationalLicenseApplication();
            application.ShowDialog();

            _RefreshList();
        }

        private string _GetRealColumnName()
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilter.Text.Trim())
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;

                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;
            }
            return FilterColumn;    
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None" );

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtInternationalLicenseApplications == null || _dtInternationalLicenseApplications.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnName();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                return;
            }
            //in this case we deal with numbers not string.
            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtFilterValue.Text.Trim());
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            frmShowDetails details = new frmShowDetails(_PersonID);
            details.ShowDialog();
        }

        private void cmsShowLicense_Click(object sender, EventArgs e)
        {
            frmShowIssueDrivingLicenseDetails details=new frmShowIssueDrivingLicenseDetails((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            details.ShowDialog();
        }

        private void cmsShowpersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmDriverLicenseHistory frmDriverLicenseHistory = new frmDriverLicenseHistory(_PersonID);
            frmDriverLicenseHistory.ShowDialog();
        }

        private void frmListInternationalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
