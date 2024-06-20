using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
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

namespace Project_4_DVDL_System_.Users
{
    public partial class frmUsersList : Form
    {
        private DataTable _dtAllUser = new DataTable();

        private int? _UserIDFromDGV => (int?)dgvUsers.CurrentRow.Cells[0].Value;
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void cmsAddUser_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void _RefreshList()
        {
            cbFilter.SelectedIndex = 0;

            _dtAllUser = clsUser.GetAllUsers();

            dgvUsers.DataSource = _dtAllUser;

            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 105;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 105;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 200;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 105;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 105;
            }

        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _RefreshList();

            cbFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAdd = new frmAddEditUser();
            frmAdd.ShowDialog();
            // Refresh List
            _RefreshList();
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAdd = new frmAddEditUser(_UserIDFromDGV);
            frmAdd.ShowDialog();
            // Refresh List
            _RefreshList();
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frmShowDetails = new frmShowUserDetails(_UserIDFromDGV);
            frmShowDetails.ShowDialog();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (clsMessages.conformDeleted("User", _UserIDFromDGV))
            {
                //Perform Delete and refresh
                if (clsUser.DeleteUser(_UserIDFromDGV))
                {
                    clsMessages.OperationDoneSuccessfully("Deleted");
                    _RefreshList();
                }

                else
                    clsMessages.OperationFelid("Deleted");
            }
        }

        private void stmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(_UserIDFromDGV);
            frmChangePassword.ShowDialog(); 
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private string _GetRealColumnName()
        {
            switch (cbFilter.Text)
            {
                case "Person ID":
                    return "PersonID";

                case "User Name":
                    return "UserName";

                case "User ID":
                    return "UserID";

                default:
                    return "None";
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllUser == null || _dtAllUser.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnName();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllUser.DefaultView.RowFilter = "";
                return;
            }

            if (cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
            {
                // search with numbers
                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtFilterValue.Text.Trim());
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilter.Text == "Person ID" || cbFilter.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
