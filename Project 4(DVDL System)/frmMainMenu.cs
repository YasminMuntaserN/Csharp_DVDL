using DVDL_BusinessLayer_;
using Guna.UI2.WinForms;
using Project_4_DVDL_System_.Application.Application_Types;
using Project_4_DVDL_System_.Application.Detain_License;
using Project_4_DVDL_System_.Application.International_License_Application;
using Project_4_DVDL_System_.Application.Local_Application;
using Project_4_DVDL_System_.Application.Renew_Local_License;
using Project_4_DVDL_System_.Application.ReplaceLostOrDamagedLicense;
using Project_4_DVDL_System_.Drivers;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.Login;
using Project_4_DVDL_System_.Person;
using Project_4_DVDL_System_.Tests.TestTypes;
using Project_4_DVDL_System_.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_
{
    public partial class frmMainMenu : Form
    {
        private frmLogin _frmLogin;

        public frmMainMenu(frmLogin login)
        {
            _frmLogin = login;
            InitializeComponent();
        }

        private void btnPeople_Click_1(object sender, EventArgs e)
        {
            frmListPeople frmListPeople = new frmListPeople();
            frmListPeople.ShowDialog();
        }

        private void manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalApplications frmListLocalApplications = new frmListLocalApplications();
            frmListLocalApplications.ShowDialog();
        }

        private void smRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalLicense frmRenewLocalLicense = new frmRenewLocalLicense();
            frmRenewLocalLicense.ShowDialog();  
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmListDrivers frmListDrivers = new frmListDrivers();
            frmListDrivers.ShowDialog();
        }

        private void replacmentDamageOrLostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicense frm =new frmReplaceLostOrDamagedLicense();   
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetain_License license =new frmDetain_License();
            license.ShowDialog();   
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainList frmDetainList   = new frmDetainList();
            frmDetainList.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense license = new frmReleaseDetainedLicense();
            license.ShowDialog();
        }

        private void smInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenseApplication frm =new frmAddInternationalLicenseApplication(); 
            frm.ShowDialog();
        }

        private void SmInternationalDrivingLicense_Click(object sender, EventArgs e)
        {
            frmListInternationalLicenses frmListInternationalLicenses = new frmListInternationalLicenses();
            frmListInternationalLicenses.ShowDialog();  
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsersList frmUsersList = new frmUsersList();
            frmUsersList.ShowDialog();  
        }

        private void smCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm=new frmShowUserDetails(clsGlobal.CurrentUser.UserID);  
            frm.ShowDialog();
        }

        private void smChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword =new frmChangePassword(clsGlobal.CurrentUser.UserID);   
            frmChangePassword.ShowDialog();
        }

        private void smSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void openContextMenuStrip(object sender, EventArgs e,Guna2ContextMenuStrip menuStrip)
        {
            Guna2Button btnSender = (Guna2Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            menuStrip.Show(ptLowerLeft);
        }
      
        private void btnApplications_Click(object sender, EventArgs e)
        {
            openContextMenuStrip(sender, e ,guna2ContextMenuStrip1);
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            openContextMenuStrip(sender, e, guna2ContextMenuStrip2);
        }

        private void smLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddEditLocalApplication frm =new frmAddEditLocalApplication();   
            frm.ShowDialog();   
        }

        private void smRetakeTest_Click(object sender, EventArgs e)
        {
            frmListLocalApplications frm = new frmListLocalApplications();
            frm.ShowDialog();
        }

        private void smManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmApplicationTypesList frmApplicationTypesList = new frmApplicationTypesList();
            frmApplicationTypesList.ShowDialog();   
        }

        private void smManageTestsTypes_Click(object sender, EventArgs e)
        {
            frmTestTypesList frmTestTypesList = new frmTestTypesList(); 
            frmTestTypesList.ShowDialog();
        }
    }
}
