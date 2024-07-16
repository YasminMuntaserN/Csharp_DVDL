using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Application.International_License_Application
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        private int? _InternationalLicenseID;
    
        public frmShowInternationalLicenseInfo(int? InternationalID)
        {
            _InternationalLicenseID = InternationalID;   
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseInfo1.LoadInfo(_InternationalLicenseID);
        }
    }
}
