using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.License.Controls
{
    public partial class frmDriverLicenseHistory : Form
    {
        private int? _PersonID = -1;

        public frmDriverLicenseHistory()
        {
            InitializeComponent();
        }

        public frmDriverLicenseHistory(int? PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDriverLicenseHistory_Load(object sender, EventArgs e)
        {

            if (_PersonID != -1)
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlDriverLicensesHistory1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonCardWithFilter1.Enabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, Person.User_Controls.ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            _PersonID = e.PersonID;
            if (_PersonID != -1)
            {
                ctrlDriverLicensesHistory1.LoadInfoByPersonID(_PersonID);

            }
        }
    }
}
