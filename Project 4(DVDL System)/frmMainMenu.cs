using DVDL_BusinessLayer_;
using Guna.UI2.WinForms;
using Project_4_DVDL_System_.Application.Detain_License;
using Project_4_DVDL_System_.Application.Local_Application;
using Project_4_DVDL_System_.Application.Renew_Local_License;
using Project_4_DVDL_System_.Application.ReplaceLostOrDamagedLicense;
using Project_4_DVDL_System_.Drivers;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.Login;
using Project_4_DVDL_System_.Person;
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
        private Guna2Button _currentButton;
        private ToolStripMenuItem _currentMenuItem;
        private Form _activeForm;
        private frmLogin _frmLogin;

        private  enum _enFrom {button ,menu };

        private static _enFrom ActionFrom = _enFrom.button; 

        public frmMainMenu(frmLogin login)
        {
            InitializeComponent();
        }
     
        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Guna2Button)btnSender)
                {
                    _DisableMenuButton();
                    _currentButton = (Guna2Button)btnSender;
                }
            }
        }

        private void _ActivateMenu(object cmsMenu)
        {
            if (cmsMenu != null)
            {
                if (_currentMenuItem != (ToolStripMenuItem)cmsMenu)
                {
                    _DisableMenuButton();
                    _currentMenuItem = (ToolStripMenuItem)cmsMenu;
                }
            }
        }

        private void _DisableMenuButton()
        {
            Guna2Button GunaAdvenceButton = new Guna2Button();

            foreach (Control previousBtn in Disaplypanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    GunaAdvenceButton = (Guna2Button)previousBtn;
                }
            }
        }

        public async void OpenChildFormAsync(Form childForm, object btnSender )
        {
            await Task.Delay(100);

            _activeForm?.Close();

            if(ActionFrom ==_enFrom.button)
               _ActivateButton(btnSender);
            else
                _ActivateMenu(btnSender);

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Disaplypanel.Controls.Add(childForm);
            Disaplypanel.Tag = childForm;
            guna2Panel1.FillColor = Color.Linen;
            childForm.BringToFront();
            childForm.Show();
        }

        private void openMenu(object sender, Guna2ContextMenuStrip menuStrip)
        {
            Guna2Button btnSender = (Guna2Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            menuStrip.Show(ptLowerLeft);
        }

        private void btnPeople_Click_1(object sender, EventArgs e)
        {
            ActionFrom = _enFrom.button;
            guna2Panel1.Visible = true;
            OpenChildFormAsync(new frmListPeople(), sender);
        }

        private void btnApplications_Click_1(object sender, EventArgs e)
        {
            openMenu(sender, guna2ContextMenuStrip1);
        }

        private void btnAccountSettings_Click_1(object sender, EventArgs e)
        {
            openMenu(sender, guna2ContextMenuStrip2);
        }

        private void manageLocalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionFrom = _enFrom.menu;
            guna2Panel1.Visible = true;
            OpenChildFormAsync(new frmListLocalApplications(), sender);
            
        }

        private void smRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalLicense frmRenewLocalLicense = new frmRenewLocalLicense();
            frmRenewLocalLicense.ShowDialog();  
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            ActionFrom = _enFrom.button;
            guna2Panel1.Visible = true;
            OpenChildFormAsync(new frmListDrivers(), sender);
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
            ActionFrom = _enFrom.menu;
            guna2Panel1.Visible = true;
            OpenChildFormAsync(new frmDetainList(), sender);
        }
    }
}
