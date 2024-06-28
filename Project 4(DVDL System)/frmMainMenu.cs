using DVDL_BusinessLayer_;
using Guna.UI2.WinForms;
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
        private Form _activeForm;
        private frmLogin _frmLogin;

        public frmMainMenu(frmLogin login)
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
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

        public async void OpenChildFormAsync(Form childForm, object btnSender)
        {
            await Task.Delay(100);

            _activeForm?.Close();

            _ActivateButton(btnSender);
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


        private void frmMainMenu_Load(object sender, EventArgs e)
        {

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
    }
}
