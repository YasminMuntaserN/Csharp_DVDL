using DVDL_DataAccess_;
using DVDL_HelperLayer_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVDL_BusinessLayer_
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? PersonID { get; set; }
        public bool IsActive { get; set; }

        public clsPerson PersonInfo => clsPerson.Find(PersonID);

        public clsUser()
        {
            this.UserID = null;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.PersonID = null;
            this.IsActive = false;

            Mode = enMode.AddNew;
        }

        private clsUser(int? UserID, string UserName, string Password, int? PersonID, bool IsActive)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.PersonID = PersonID;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.UserName, this.Password, this.PersonID, this.IsActive);

            return (this.UserID.HasValue);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.UserName, this.Password, this.PersonID, this.IsActive);
        }

        public bool Save()
        {
            this.Password = clsBusinessLayerHelper.ComputeHash(this.Password);
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static clsUser Find(int? UserID)
        {
            string UserName = string.Empty;
            string Password = string.Empty;
            int? PersonID = null;
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByID(UserID, ref UserName, ref Password, ref PersonID, ref IsActive);

            return (IsFound) ? (new clsUser(UserID, UserName, Password, PersonID, IsActive)) : null;
        }

        public static clsUser Find(string UserName)
        {
            int? UserID = null;
            string Password = string.Empty;
            int? PersonID = null;
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUserName(ref UserName, UserID, ref Password, ref PersonID, ref IsActive);

            return (IsFound) ? (new clsUser(UserID, UserName, Password, PersonID, IsActive)) : null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            int? UserID = null;
            int? PersonID = null;
            bool IsActive = false;
            bool IsFound = clsUserData.GetUserInfoByUserNameAndPassword(ref UserID, UserName, Password, ref PersonID, ref IsActive);

            return (IsFound) ? (new clsUser(UserID, UserName, Password, PersonID, IsActive)) : null;
        }

        public static bool DeleteUser(int? UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool DoesUserExist(int? UserID)
        {
            return clsUserData.DoesUserExist(UserID);
        }

        public static bool DoesUserExistByPersonID(int? PersonID)
        {
            return clsUserData.DoesUserExistByPersonID(PersonID);
        }

        public static bool DoesUserExist(string Username)
        {
            return clsUserData.DoesUserExist(Username);
        }

        public static bool DoesUserExist(string Username, string Password)
        {
            return clsUserData.DoesUserExist(Username, Password);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

    }
}

