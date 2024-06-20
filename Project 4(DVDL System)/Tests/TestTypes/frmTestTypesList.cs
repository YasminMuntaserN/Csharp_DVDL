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

namespace Project_4_DVDL_System_.Tests.TestTypes
{
    public partial class frmTestTypesList : Form
    {
        private DataTable _dtAllTestTypes = new DataTable();

        private int? _TestTypeIDFromDGV => (int?)dgvTestTypes.CurrentRow.Cells[0].Value;

        public frmTestTypesList()
        {
            InitializeComponent();
        }

        private void _RefreshList()
        {

            _dtAllTestTypes = clsTestType.GetAllTestTypes();

            dgvTestTypes.DataSource = _dtAllTestTypes;

            if (dgvTestTypes.Rows.Count > 0)
            {

                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 100;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 210;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 200;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 200;

            }

        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshList();
        }

        private void cmsEditTest_Click(object sender, EventArgs e)
        {
            frmEditTest frmEditTest = new frmEditTest(_TestTypeIDFromDGV);
            frmEditTest.ShowDialog();
            _RefreshList();
        }
    }
}
