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
    public partial class frmDetain_License : Form
    {
        private int? _DetainID = -1;
        private int ?_SelectedLicenseID = -1;

        public frmDetain_License()
        {
            InitializeComponent();
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
            if (ctrlDrivingLicenseCardWithFilter1.License.IsDetained)
            {
                clsMessages.GeneralErrorMessage("Selected License i already detained, choose another one.");
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            _DetainID = ctrlDrivingLicenseCardWithFilter1.License.Detain(Convert.ToSingle(txtFineFees.Text), clsGlobal.CurrentUser.UserID);
            if (_DetainID == -1)
            {
                clsMessages.GeneralErrorMessage("Felid to Detain License");
                return;
            }

            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrlDrivingLicenseCardWithFilter1.FilterEnabled = false;
            txtFineFees.Enabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowIssueDrivingLicenseDetails frmShow =new frmShowIssueDrivingLicenseDetails(_SelectedLicenseID);
            frmShow.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseHistory history = new frmDriverLicenseHistory
                (ctrlDrivingLicenseCardWithFilter1.License.DriverInfo.PersonID);   
            history.ShowDialog();   
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);

            };
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmDetain_License_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }

    }
}
