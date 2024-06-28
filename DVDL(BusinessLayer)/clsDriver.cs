using DVDL_DataAccess_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_BusinessLayer_
{
    public class clsDriver
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? DriverID { get; set; }
        public int? PersonID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {
            this.DriverID = null;
            this.PersonID = null;
            this.CreatedByUserID = null;
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsDriver(int? DriverID, int? PersonID, int? CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return (this.DriverID.HasValue);
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDriver();
            }

            return false;
        }

        public static clsDriver Find(int? DriverID)
        {
            int? PersonID = null;
            int? CreatedByUserID = null;
            DateTime CreatedDate = DateTime.Now;

            bool IsFound = clsDriverData.GetDriverInfoByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate);

            return (IsFound) ? (new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate)) : null;
        }

        public static clsDriver FindByPersonID(int? PersonID)
        {
            int? DriverID = null;
            int? CreatedByUserID = null;
            DateTime CreatedDate = DateTime.Now;

            bool IsFound = clsDriverData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate);

            return (IsFound) ? (new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate)) : null;
        }

        public static bool DeleteDriver(int? DriverID)
        {
            return clsDriverData.DeleteDriver(DriverID);
        }

        public static bool DoesDriverExist(int? DriverID)
        {
            return clsDriverData.DoesDriverExist(DriverID);
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }

    }
}
