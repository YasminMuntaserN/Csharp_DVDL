using DVDL_BusinessLayer_;
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

namespace Project_4_DVDL_System_.Drivers
{
    public partial class frmListDrivers : Form
    {
        private DataTable _dtAllDrivers = new DataTable();

        private int? _DriverIDFromDGV => (int?)dgvDriviers.CurrentRow.Cells[0].Value;

        public frmListDrivers()
        {
            InitializeComponent();
        }

        private string _GetRealColumnName()
        {
            switch (cbFilter.Text.Trim())
            {
                case "Person ID":
                    return "PersonID";

                case "Name":
                    return "FullName";

                case "Driver ID":
                    return "DriverID";

                case "National No.":
                    return "NationalNo";

                default:
                    return "None";
            }
        }

        private void _RefreshList()
        {
            cbFilter.SelectedIndex = 0;

            _dtAllDrivers = clsDriver.GetAllDrivers();

            dgvDriviers.DataSource = _dtAllDrivers;


            if (dgvDriviers.Rows.Count > 0)
            {
                dgvDriviers.Columns[0].HeaderText = "Driver ID";
                dgvDriviers.Columns[0].Width = 110;

                dgvDriviers.Columns[1].HeaderText = "Person ID";
                dgvDriviers.Columns[1].Width = 120;

                dgvDriviers.Columns[2].HeaderText = "National No.";
                dgvDriviers.Columns[2].Width = 140;

                dgvDriviers.Columns[3].HeaderText = "Full Name";
                dgvDriviers.Columns[3].Width = 170;

                dgvDriviers.Columns[4].HeaderText = "Created Date";
                dgvDriviers.Columns[4].Width = 200;

                dgvDriviers.Columns[5].HeaderText = "No. Active License";
                dgvDriviers.Columns[5].Width = 180;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _RefreshList();

            cbFilter.SelectedIndex = 0;
        }

        private void txtFilterValue_TextChanged_2(object sender, EventArgs e)
        {

            if (_dtAllDrivers == null || _dtAllDrivers.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnName();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                return;
            }

            if (cbFilter.Text == "Person ID" || cbFilter.Text == "Driver ID")
            {
                // search with numbers
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtFilterValue.Text.Trim());
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None");


            if (cbFilter.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();

        }

        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else if (cbFilter.Text == "Driver ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void smShowPersonInfo_Click(object sender, EventArgs e)
        {
            frmShowDetails frmListDrivers = new frmShowDetails((int?)dgvDriviers.CurrentRow.Cells[1].Value);
            frmListDrivers.ShowDialog();    
        }
    }
}
