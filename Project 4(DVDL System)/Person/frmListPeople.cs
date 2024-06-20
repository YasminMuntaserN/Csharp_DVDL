using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_4_DVDL_System_.Person
{
    public partial class frmListPeople : Form
    {
        private DataTable _dtAllPeople = new DataTable();

        private int? _PersonIDFromDGV => (int?)dgvUsers.CurrentRow.Cells[0].Value;

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void _FillComboBoxWithCountries()
        {
            cbCountry.Items.Clear();

            DataTable Countries = clsCountry.GetAllCountries();

            foreach (DataRow country in Countries.Rows)
            {
                cbCountry.Items.Add(country["countryName"].ToString());
            }
        }

        private string _GetRealColumnName()
        {
            switch (cbFilter.Text)
            {
                case "Person ID":
                    return "PersonID";

                case "Name":
                    return "FullName";

                case "National No":
                    return "NationalNo";

                case "Phone":
                    return "Phone";

                case "Address":
                    return "Address";

                case "Country":
                    return "Country";

                default:
                    return "None";
            }
        }

        private void _RefreshList()
        {
            cbFilter.SelectedIndex = 0;

            _dtAllPeople = clsPerson.GetAllPeople();

            dgvUsers.DataSource = _dtAllPeople;


            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "Person ID";
                dgvUsers.Columns[0].Width = 130;

                dgvUsers.Columns[1].HeaderText = "National No";
                dgvUsers.Columns[1].Width = 130;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 200;

                dgvUsers.Columns[3].HeaderText = "Date Of Birth";
                dgvUsers.Columns[3].Width = 150;

                dgvUsers.Columns[4].HeaderText = "Gender";
                dgvUsers.Columns[4].Width = 100;

                dgvUsers.Columns[5].HeaderText = "Address";
                dgvUsers.Columns[5].Width = 100;

                dgvUsers.Columns[6].HeaderText = "Phone";
                dgvUsers.Columns[6].Width = 100;

                dgvUsers.Columns[7].HeaderText = "Email";
                dgvUsers.Columns[7].Width = 100;

                dgvUsers.Columns[8].HeaderText = "Country";
                dgvUsers.Columns[8].Width = 100;
            }
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _FillComboBoxWithCountries();
            _RefreshList();

            cbFilter.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None") && (cbFilter.Text != "Country");

            cbCountry.Visible = (cbFilter.Text == "Country");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            if (cbCountry.Visible)
                cbCountry.SelectedIndex = 0;
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllPeople == null || _dtAllPeople.Rows.Count == 0)
                return;

            string columnName = _GetRealColumnName();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilter.Text == "None")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                return;
            }

            if (cbFilter.Text == "Person ID")
            {
                // search with numbers
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtFilterValue.Text.Trim());
            }

        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmEdit = new frmAddEditPerson(_PersonIDFromDGV);
            frmEdit.ShowDialog();
            // Refresh List
            _RefreshList();
        }

        private void cmsShowDetails_Click(object sender, EventArgs e)
        {
            frmShowDetails frmShowDetails = new frmShowDetails(_PersonIDFromDGV);
            frmShowDetails.ShowDialog();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (clsMessages.conformDeleted("Person" ,_PersonIDFromDGV))
            {
                //Perform Delete and refresh
                if (clsPerson.DeletePerson(_PersonIDFromDGV))
                {
                    clsMessages.OperationDoneSuccessfully("Deleted");
                    _RefreshList();
                }

                else
                    clsMessages.OperationFelid("Deleted");
            }
        }

        private void cmsAddPerson_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();  
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilter.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson frmAdd = new frmAddEditPerson();
            frmAdd.ShowDialog();
            // Refresh List
            _RefreshList();
        }

        private void cbCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (_dtAllPeople == null || _dtAllPeople.Rows.Count == 0)
                return;


            _dtAllPeople.DefaultView.RowFilter =
                string.Format("[{0}] like '{1}%'", "CountryName", cbCountry.Text);

        }
    }
}
