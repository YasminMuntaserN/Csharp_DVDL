using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Application.Local_Application
{
    public partial class frmLocalApplicationDetails : Form
    {
        public frmLocalApplicationDetails(int? ID)
        {
            InitializeComponent();
            ctrlLocalApplication1.LoadLocalApplicationInfo(ID); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
