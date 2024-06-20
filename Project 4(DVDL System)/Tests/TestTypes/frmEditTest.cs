using DVDL_BusinessLayer_;
using Guna.UI2.WinForms;
using Project_4_DVDL_System_.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Project_4_DVDL_System_.Tests.TestTypes
{
    public partial class frmEditTest : Form
    {
        private int? _TestID = null;
        private clsTestType _Test = null;

        public frmEditTest(int? TestID)
        {
            InitializeComponent();
            _TestID = TestID;
        }

        private void _FillTestInfoInField()
        {
            lblTestID.Text = _Test.TestTypeID.ToString();
            txtTitle.Text = _Test.TestTypeTitle.ToString();
            txtDescription.Text = _Test.TestTypeDescription.ToString();
            txtFees.Text = _Test.TestTypeFees.ToString();

        }

        private void _LoadData()
        {
            _Test = clsTestType.Find(_TestID);

            if (_Test == null)
            {
                clsMessages.NotFound("Test", _TestID);

                this.Close();
                return;
            }

            _FillTestInfoInField();
        }

        private void _FillTestObjectWithFieldsData()
        {
            _Test.TestTypeTitle = txtTitle.Text.Trim();
            _Test.TestTypeDescription = txtDescription.Text.Trim();
            _Test.TestTypeFees = decimal.Parse(txtFees.Text.Trim());
        }

        private void _Save()
        {
            _FillTestObjectWithFieldsData();

            if (_Test.Save())
            {
                clsMessages.OperationDoneSuccessfully("Saved");
            }
            else
            {
                clsMessages.OperationFelid("Saved");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void frmEditTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
