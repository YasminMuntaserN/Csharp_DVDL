using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.License
{
    public partial class frmShowIssueDrivingLicenseDetails : Form
    {
        private int? _LicenseID = null;

        public frmShowIssueDrivingLicenseDetails(int? LicenseID)
        {
            _LicenseID = LicenseID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowIssueDrivingLicenseDetails_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.LoadLicenseInfo(_LicenseID);
        }
    }
}
