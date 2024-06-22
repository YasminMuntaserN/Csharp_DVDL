using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
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

namespace Project_4_DVDL_System_.Person.User_Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public class SelectPersonEventArgs : EventArgs
        {
            public int? PersonID { get; }

            public SelectPersonEventArgs(int? PersonID)
            {
                this.PersonID = PersonID;
            }
        }


        public event EventHandler<SelectPersonEventArgs> OnPersonSelectedEvent;

        public void OnPersonSelected(int? PersonID)
        {
            if (OnPersonSelectedEvent != null)
            {
                OnPersonSelectedEvent(this, new SelectPersonEventArgs(PersonID));
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get => _FilterEnabled;

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private clsPerson _Person;
        private int? _PersonID;


        public clsPerson PersonInfo => _Person;
        public int? PersonID => _PersonID;

        public void LoadPersonInfo(int? PersonID)
        {
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);

            if (OnPersonSelectedEvent != null)
                OnPersonSelected(ctrlPersonCard1?.PersonID);
            _Person = ctrlPersonCard1.Person;
            _PersonID = PersonID;

        }

        public void LoadPersonInfo(string NationalNo)
        {
            txtFilterValue.Text = NationalNo;
            ctrlPersonCard1.LoadPersonInfo(NationalNo);

            if (OnPersonSelectedEvent != null)
                OnPersonSelected(ctrlPersonCard1?.PersonID);
            _Person = ctrlPersonCard1.Person;
            _PersonID =_Person.PersonID;

        }

        private void DataBackEvent(int? PersonID)
        {
            cbFilter.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            _Person = ctrlPersonCard1.Person;
            _PersonID = _Person.PersonID;
        }

        private void FindNow()
        {
            if (!(cbFilter.SelectedIndex > -1))
            {
                errorProvider1.SetError(cbFilter, "You must choose how you want to search");
                return;
            }
            switch (cbFilter.Text.Trim())
            {
                case "Person ID":
                    if (!clsPerson.DoesPersonExist(int.Parse(txtFilterValue.Text)))
                    {
                        clsMessages.AddToSystem("Person");
                        return;
                    }
                    LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "NationalNo":
                    if (!clsPerson.isPersonExist(txtFilterValue.Text))
                    {
                        clsMessages.AddToSystem("Person");
                        return;
                    }
                    LoadPersonInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            _PersonID = _Person.PersonID;

        }

        public void FilterFocus() => txtFilterValue.Focus();

        private void btnFind_Click_1(object sender, EventArgs e) => FindNow();

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson();
            frmAddEditPerson.PersonIDBack += DataBackEvent;
            frmAddEditPerson.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
            //this will allow only digits if person id is selected
            if (cbFilter.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
