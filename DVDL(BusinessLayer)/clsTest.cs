using DVDL_DataAccess_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_BusinessLayer_
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()
        {
            this.TestID = null;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = null;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsTest(int? TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID.HasValue);
        }

        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTest();
            }

            return false;
        }

        public static clsTest Find(int? TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = null;
            int CreatedByUserID = -1;

            bool IsFound = clsTestData.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);

            return (IsFound) ? (new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID)) : null;
        }

        public static bool DeleteTest(int? TestID)
        {
            return clsTestData.DeleteTest(TestID);
        }

        public static bool DoesTestExist(int? TestID)
        {
            return clsTestData.DoesTestExist(TestID);
        }

        public static DataTable GetAllTests()
        {
            return clsTestData.GetAllTests();
        }

        public static int PassedTestCount(int? LocalDrivingID)
        {
           return clsTestData.PassedTestCount(LocalDrivingID);
        }

    }

}
