using DVDL_DataAccess_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_BusinessLayer_
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? CountryID { get; set; }
        public string CountryName { get; set; }

        public static string CountryNameByID (int? countryID) => Find(countryID).CountryName;

        public clsCountry()
        {
            this.CountryID = null;
            this.CountryName = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsCountry(int? CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;

            Mode = enMode.Update;
        }

        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryData.AddNewCountry(this.CountryName);

            return (this.CountryID.HasValue);
        }

        private bool _UpdateCountry()
        {
            return clsCountryData.UpdateCountry(this.CountryID, this.CountryName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCountry();
            }

            return false;
        }

        public static clsCountry Find(int? CountryID)
        {
            string CountryName = string.Empty;

            bool IsFound = clsCountryData.GetCountryInfoByID(CountryID, ref CountryName);

            return (IsFound) ? (new clsCountry(CountryID, CountryName)) : null;
        }

        public static clsCountry Find(string CountryName)
        {
            int? CountryID = null;

            bool IsFound = clsCountryData.GetCountryInfoByName(CountryName, ref CountryID);

            return (IsFound) ? (new clsCountry(CountryID, CountryName)) : null;
        }

        public static bool DeleteCountry(int? CountryID)
        {
            return clsCountryData.DeleteCountry(CountryID);
        }

        public static bool DoesCountryExist(int? CountryID)
        {
            return clsCountryData.DoesCountryExist(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }

}
