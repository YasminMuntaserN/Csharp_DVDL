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
using static DVDL_BusinessLayer_.clsLicense;

namespace Project_4_DVDL_System_.Application.ReplaceLostOrDamagedLicense
{
    public partial class frmReplaceLostOrDamagedLicense : Form
    {
        private int? _NewLicenseID;
        public frmReplaceLostOrDamagedLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
     
        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use According 
            // to user selection.

            if (rbDamagedLicense.Checked)

                return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }

        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rbDamagedLicense.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }

        private void CustomizeProcess(string OperationName)
        {
            lblTitle.Text = $"Replacement for {OperationName} License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).ApplicationFees.ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e) => CustomizeProcess("Lost");

        private void rbDamegedLicense_CheckedChanged(object sender, EventArgs e) => CustomizeProcess("Damaged");

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int? obj)
        {
            int? SelectedLicenseID = obj;
            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }

            //don't allow a replacement if is Active .
            if (!ctrlDrivingLicenseCardWithFilter1.License.IsActive)
            {
                clsMessages.GeneralErrorMessage("Selected License is not Not Active, choose an active license.");
                btnReplacement.Enabled = false;
                return;
            }

            btnReplacement.Enabled = true;
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
               ctrlDrivingLicenseCardWithFilter1.License.Replace(_GetIssueReason(),clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {
                clsMessages.GeneralErrorMessage("Felid to Issue a Replacement for this  License");
                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            lblRreplacedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrlDrivingLicenseCardWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowIssueDrivingLicenseDetails frm = new frmShowIssueDrivingLicenseDetails(_NewLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void frmReplaceLostOrDamagedLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

            rbDamagedLicense.Checked = true;
        }

    }
}
