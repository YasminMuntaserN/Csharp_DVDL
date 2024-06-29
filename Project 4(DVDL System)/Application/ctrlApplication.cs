using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
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
using static System.Net.Mime.MediaTypeNames;

namespace Project_4_DVDL_System_.Application
{
    public partial class ctrlApplication : UserControl
    {
        private clsApplication _Application;
        private int? _ApplicationID;

        public clsApplication Application => _Application;
        public int? ApplicationID => _ApplicationID;

        public ctrlApplication()
        {
            InitializeComponent();
        }

        private void _FillData()
        {
            lblApplicationID.Text = _ApplicationID.ToString();  
            lblApplicant.Text =_Application.ApplicationStatus.ToString();
            lblCreatedByUser.Text = clsUser.Find(_Application.CreatedByUserID).UserName;
            lblDate.Text=clsFormat.DateToShort(_Application.ApplicationDate);
            lblStatus.Text = _Application.ApplicationStatus == 1? "New" : _Application.ApplicationStatus == 2 ? "Cancelled" : "Completed";
            lblStatusDate.Text = clsFormat.DateToShort(_Application.LastStatusDate);
            lblFees.Text =_Application.PaidFees.ToString();
            lblType.Text = clsApplicationType.Find(_Application.ApplicationTypeID).ApplicationTypeTitle;

        }

        public void LoadApplicationInfo(int? ApplicationID)
        {
            _Application = clsApplication.Find(ApplicationID);

            if (_Application == null)
            {
                clsMessages.NotFound("Application", ApplicationID);
                return;
            }
            _ApplicationID = ApplicationID;
            _FillData();
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDetails frmShowDetails = new frmShowDetails(_Application.ApplicantPersonID);
            frmShowDetails.ShowDialog();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
