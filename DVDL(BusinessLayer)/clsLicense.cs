using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_BusinessLayer_
{
    public class clsLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public int? LicenseID { get; set; }
        public int? ApplicationID { get; set; }
        public int? DriverID { get; set; }
        public int? LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedByUserID { get; set; }
        public enIssueReason IssueReason { set; get; }
        public string IssueReasonText => GetIssueReasonText(this.IssueReason);

        public clsLicenseClass LicenseClassInfo => clsLicenseClass.Find(LicenseClass);

        public clsDriver DriverInfo => clsDriver.Find(DriverID);

        public clsDetain DetainInfo =>clsDetain.FindByLicenseID(LicenseID);

        public clsLicense()
        {
            this.LicenseID = null;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = null;
            this.PaidFees = -1M;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsLicense(int? LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = (enIssueReason)IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }

        public Boolean IsLicenseExpired => this.ExpirationDate < DateTime.Now;

        public bool IsDetained => clsDetain.IsLicenseDetained(this.LicenseID);

        public static string GetIssueReasonText(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

            return (this.LicenseID.HasValue);
        }

        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLicense();
            }

            return false;
        }

        public static clsLicense Find(int? LicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = null;
            decimal PaidFees = -1M;
            bool IsActive = false;
            byte IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = clsLicenseData.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            return (IsFound) ? (new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)) : null;
        }

        public static bool DeleteLicense(int? LicenseID)
        {
            return clsLicenseData.DeleteLicense(LicenseID);
        }

        public static bool DoesLicenseExist(int? LicenseID)
        {
            return clsLicenseData.DoesLicenseExist(LicenseID);
        }

        public static DataTable GetAllLicenses()
        {
            return clsLicenseData.GetAllLicenses();
        }

        public static int GetActiveLicenseIDByPersonID(int? PersonID, int? LicenseClassID)
        {

            return clsLicenseData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }

        public bool DeactivateCurrentLicense()
        {
            return (clsLicenseData.DeactivateLicense(this.LicenseID));
        }

        public clsLicense RenewLicense(string Notes, int? CreatedByUserID)
        {

            //First Create Application 
            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RenewDrivingLicense;
            Application.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;

            int DefaultValidityLength = LicenseClassInfo.DefaultValidityLength;

            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;


            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;
        }

        public clsLicense Replace(enIssueReason IssueReason, int ?CreatedByUserID)
        {
            //First Create Application 
            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;

            Application.ApplicationTypeID = (IssueReason == enIssueReason.DamagedReplacement) ?
                (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense :
                (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;

            Application.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find(Application.ApplicationTypeID).ApplicationFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = this.ExpirationDate;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = 0;// no fees for the license because it's a replacement.
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReason;
            NewLicense.CreatedByUserID = CreatedByUserID;



            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;
        }

        public static DataTable GetDriverLicenses(int? DriverID)
        {
            return clsLicenseData.GetDriverLicenses(DriverID);
        }

        public int? Detain(float FineFees, int? CreatedByUserID)
        {
            clsDetain detainedLicense = new clsDetain();
            detainedLicense.LicenseID = this.LicenseID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = Convert.ToDecimal(FineFees);
            detainedLicense.CreatedByUserID = CreatedByUserID;

            if (!detainedLicense.Save())
            {

                return -1;
            }

            return detainedLicense.DetainID;

        }

        public bool ReleaseDetainedLicense(int? ReleasedByUserID, ref int? ApplicationID)
        {

            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense;
            Application.ApplicationStatus = (byte)clsApplication.enStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).ApplicationFees;
            Application.CreatedByUserID = ReleasedByUserID;

            if (!Application.Save())
            {
                ApplicationID = -1;
                return false;
            }

            ApplicationID = Application.ApplicationID;


            return this.DetainInfo.ReleaseDetainedLicense(ReleasedByUserID, Application.ApplicationID);

        }
    }

}
