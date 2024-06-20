using DVDL_BusinessLayer_;
using Project_4_DVDL_System_.Global_Classes;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsCountry Country = new clsCountry();
            Country.CountryName = guna2TextBox1.Text;
            if (Country.Save())
            {
                clsMessages.OperationDoneSuccessfully("Save");
            }
        }
    }
}
