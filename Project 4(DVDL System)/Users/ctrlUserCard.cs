using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
using Project_4_DVDL_System_.Properties;
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
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;
        private int? _UserID;

        public clsUser User => _User;
        public int? UserID => _UserID;

        public ctrlUserCard()
        {
            InitializeComponent();
        }
        private void _FillData()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive? "Yes" :"No";
        }
        public void LoadUserInfo(int?UserID)
        {
            _User = clsUser.Find(UserID);

            if (_User == null)
            {
                clsMessages.NotFound("User", UserID);
                return;
            }
            _UserID = UserID;
            _FillData();
        }

    }
}
