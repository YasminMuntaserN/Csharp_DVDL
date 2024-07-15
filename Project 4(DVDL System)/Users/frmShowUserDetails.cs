using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4_DVDL_System_.Users
{
    public partial class frmShowUserDetails : Form
    {
        public frmShowUserDetails(int? UserID)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserInfo(UserID);   
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
