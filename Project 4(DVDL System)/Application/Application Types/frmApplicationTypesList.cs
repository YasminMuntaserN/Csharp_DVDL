using DVDL_BusinessLayer_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Application.Application_Types
{
    public partial class frmApplicationTypesList : Form
    {
        private DataTable _dtAllApplicationTypes = new DataTable();

        private int? _ApplicationTypeIDFromDGV => (int?)dgvApplication.CurrentRow.Cells[0].Value;
        public frmApplicationTypesList()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {

            _dtAllApplicationTypes =clsApplicationType.GetAllApplicationTypes();

            dgvApplication.DataSource = _dtAllApplicationTypes;

            if (dgvApplication.Rows.Count > 0)
            {

                dgvApplication.Columns[0].HeaderText = "Application ID";
                dgvApplication.Columns[0].Width = 200;

                dgvApplication.Columns[1].HeaderText = "Application Title";
                dgvApplication.Columns[1].Width = 230;

                dgvApplication.Columns[2].HeaderText = "Application Fees";
                dgvApplication.Columns[2].Width = 200;

            }

        }

        private void frmApplicationTypesList_Load(object sender, EventArgs e)
        {
            _RefreshList();
        }

        private void cmsEditApplication_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frmEditApplicationType = new frmEditApplicationType(_ApplicationTypeIDFromDGV);
            frmEditApplicationType.ShowDialog();
            _RefreshList();
        }
    }
}
