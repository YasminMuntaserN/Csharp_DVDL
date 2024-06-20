using DVDL_DataAccess_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_BusinessLayer_
{
    public class clsApplicationType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsApplicationType()
        {
            this.ApplicationTypeID = null;
            this.ApplicationTypeTitle = string.Empty;
            this.ApplicationFees = -1;

            Mode = enMode.AddNew;
        }

        private clsApplicationType(int? ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;

            Mode = enMode.Update;
        }

        private bool _AddNewApplicationType()
        {
            this.ApplicationTypeID = clsApplicationTypeData.AddNewApplicationType(this.ApplicationTypeTitle, this.ApplicationFees);

            return (this.ApplicationTypeID.HasValue);
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateApplicationType();
            }

            return false;
        }

        public static clsApplicationType Find(int? ApplicationTypeID)
        {
            string ApplicationTypeTitle = string.Empty;
            decimal ApplicationFees = -1;

            bool IsFound = clsApplicationTypeData.GetApplicationTypeInfoByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees);

            return (IsFound) ? (new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees)) : null;
        }

        public static bool DeleteApplicationType(int? ApplicationTypeID)
        {
            return clsApplicationTypeData.DeleteApplicationType(ApplicationTypeID);
        }

        public static bool DoesApplicationTypeExist(int? ApplicationTypeID)
        {
            return clsApplicationTypeData.DoesApplicationTypeExist(ApplicationTypeID);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationTypes();
        }

    }

}
