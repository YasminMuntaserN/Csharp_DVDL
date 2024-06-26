﻿using DVDL_BusinessLayer_;
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

namespace Project_4_DVDL_System_.Tests.TestAppointments
{
    public partial class ctrlScheduledTest : UserControl
    {

        private clsTestType.enTestType _TestTypeID;
        private int? _TestID = -1;

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public clsTestType.enTestType TestTypeID
        {
            get => _TestTypeID;

            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestType.enTestType.VisionTest:
                        {
                            gbTestType.Text = "Vision Test";
                            pbTestTypeImage.Image = Resources.eye_care;
                            break;
                        }

                    case clsTestType.enTestType.WrittenTest:
                        {
                            gbTestType.Text = "Written Test";
                            pbTestTypeImage.Image = Resources.Written_Test_32_Sechdule;
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            gbTestType.Text = "Street Test";
                            pbTestTypeImage.Image = Resources.Street_Test_32;
                            break;


                        }
                }
            }
        }

        public int? TestAppointmentID => _TestAppointmentID;

        public int? TestID => _TestID;


        private int? _TestAppointmentID = -1;
        private int? _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppointment _TestAppointment;
    
        public ctrlScheduledTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int? TestAppointmentID)
        {

            _TestAppointmentID = TestAppointmentID;


            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            //incase we did not find any appointment .
            if (_TestAppointment == null)
            {
                clsMessages.NotFound("Appointment", _TestAppointmentID);
                _TestAppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID;

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                clsMessages.NotFound("Local Driving License Application ", _LocalDrivingLicenseApplicationID);
                return;
            }

            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplication.ApplicationInfo.PersonName;


            //this will show the trials for this test before 
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();



            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTestID.Text = (_TestAppointment.TestAppointmentID == -1) ? "Not Taken Yet" : _TestAppointment.TestAppointmentID.ToString();

        }
    }
}
