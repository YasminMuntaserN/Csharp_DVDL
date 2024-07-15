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
using TheArtOfDevHtmlRenderer.Adapters;

namespace Project_4_DVDL_System_.Application.Application_Types
{
    public partial class frmEditApplicationType : Form
    {
        private int? _ApplicationID = null;
        private clsApplicationType _Application = null;

        public frmEditApplicationType(int? ApplicationID)
        {
            _ApplicationID = ApplicationID;
            InitializeComponent();
        }

        private void _FillApplicationInfoInField()
        {
            lblApplicationID.Text = _ApplicationID.ToString();
            txtTitle.Text = _Application.ApplicationTypeTitle.ToString();
            txtFees.Text = _Application.ApplicationFees.ToString();

        }

        private void _LoadData()
        {
            _Application = clsApplicationType.Find(_ApplicationID);

            if (_Application == null)
            {
                clsMessages.NotFound("Application", _ApplicationID);

                this.Close();
                return;
            }

            _FillApplicationInfoInField();
        }

        private void _FillPersonObjectWithFieldsData()
        {
            _Application.ApplicationTypeTitle = txtTitle.Text.Trim();
            _Application.ApplicationFees = decimal.Parse(txtFees.Text.Trim());
        }

        private void _Save()
        {
            _FillPersonObjectWithFieldsData();

            if (_Application.Save())
            {
                clsMessages.OperationDoneSuccessfully("Saved");
            }
            else
            {
                clsMessages.OperationFelid("Saved");
            }
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

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
                _LoadData();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _Save();
        }
    }
}
