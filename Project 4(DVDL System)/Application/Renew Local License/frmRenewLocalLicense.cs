using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Application.Renew_Local_License
{
    public partial class frmRenewLocalLicense : Form
    {
        private int ?_ApplicationID = null ;
        private clsLocalDrivingLicenseApplication _Application = null;

        public int ?ApplicationID => _ApplicationID;
        public clsLocalDrivingLicenseApplication Application => _Application;

        public int? _NewLicenseID = null;

        public frmRenewLocalLicense()
        {
            InitializeComponent();
        }
            
        private void frmRenewLocalLicense_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseCardWithFilter1.txtLicenseIDFocus();
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;

            lblExpirationDate.Text = "???";
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillRenewApplicationInfoInFields()
        {
            int DefaultValidityLength = ctrlDrivingLicenseCardWithFilter1.License.LicenseClassInfo.DefaultValidityLength;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lblLicenseFees.Text = ctrlDrivingLicenseCardWithFilter1.License.LicenseClassInfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDrivingLicenseCardWithFilter1.License.Notes;


            //check the license is not Expired.
            if (!ctrlDrivingLicenseCardWithFilter1.License.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiered, it will expire on: " + clsFormat.DateToShort(ctrlDrivingLicenseCardWithFilter1.License.ExpirationDate)
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            //check the license is not Expired.
            if (!ctrlDrivingLicenseCardWithFilter1.License.IsActive)
            {
                clsMessages.GeneralErrorMessage("Selected License is not Not Active, choose an active license.");
                btnRenew.Enabled = false;
                return;
            }



             btnRenew.Enabled = true;
        }

        private void ctrlDrivingLicenseCardWithFilter1_OnLicenseSelected(int? obj)
        {
            int? SelectedLicenseID = obj;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)

            {
                return;
            }
            FillRenewApplicationInfoInFields();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
                ctrlDrivingLicenseCardWithFilter1.License.RenewLicense(txtNotes.Text.Trim(),
                clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                clsMessages.GeneralErrorMessage("Felid to Renew the License");
                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            ctrlDrivingLicenseCardWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowIssueDrivingLicenseDetails frm = new frmShowIssueDrivingLicenseDetails(_NewLicenseID);
            frm.ShowDialog();
        } 
    }
}
