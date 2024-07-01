using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.License;
using Project_4_DVDL_System_.License.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Application.Detain_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private int? _ReleaseID = -1;
        private int? _SelectedLicenseID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int? LicenceID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenceID;
            ctrlDrivingLicenseCardWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrlDrivingLicenseCardWithFilter1.FilterEnabled = false;
        }

        private void _FillDetainInfo()
        {
            lblDetainID.Text =ctrlDrivingLicenseCardWithFilter1.License.DetainInfo.DetainID.ToString();
            lblDetainDate.Text =clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text=clsGlobal.CurrentUser.UserName;
            lblApplicationFees.Text = clsApplicationType.Find((byte)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).ApplicationFees.ToString();
            lblLicenseID.Text = _SelectedLicenseID.ToString();
            lblFineFees.Text = ctrlDrivingLicenseCardWithFilter1.License.DetainInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();
        }

        private void ctrlDrivingLicenseCardWithFilter1_OnLicenseSelected(int? obj)
        {

            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)

            {
                return;
            }

            //ToDo: make sure the license is not detained already.
            if (!ctrlDrivingLicenseCardWithFilter1.License.IsDetained)
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillDetainInfo();
            btnRelease.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Release the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ?ApplicationID = -1;

            bool IsReleased = ctrlDrivingLicenseCardWithFilter1.License.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID); ;

            lblApplicationID.Text = ApplicationID.ToString();

            if (!IsReleased)
            {
                clsMessages.GeneralErrorMessage("Felid to to release the Detain License");
                return;
            }
            clsMessages.GeneralSuccessMessage("Detained License released Successfully ");

            btnRelease.Enabled = false;
            ctrlDrivingLicenseCardWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowIssueDrivingLicenseDetails frmShow = new frmShowIssueDrivingLicenseDetails(_SelectedLicenseID);
            frmShow.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseHistory history = new frmDriverLicenseHistory
                (ctrlDrivingLicenseCardWithFilter1.License.DriverInfo.PersonID);
            history.ShowDialog();
        }
    }
}
