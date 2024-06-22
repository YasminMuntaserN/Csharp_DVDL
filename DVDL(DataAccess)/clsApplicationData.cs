using DVDL_HelperLayer_;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_DataAccess_
{
    public class clsApplicationData
    {
        public static bool GetApplicationInfoByID(int? ApplicationID, ref int? ApplicationPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int UserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Application where ApplicationID = @ApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", (object)ApplicationID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                ApplicationPersonID = (int)reader["ApplicationPersonID"];
                                ApplicationDate = (DateTime)reader["ApplicationDate"];
                                ApplicationTypeID = (int)reader["ApplicationTypeID"];
                                ApplicationStatus = (byte)reader["ApplicationStatus"];
                                LastStatusDate = (DateTime)reader["LastStatusDate"];
                                PaidFees = (decimal)reader["PaidFees"];
                                UserID = (int)reader["UserID"];
                            }
                            else
                            {
                                // The record was not found
                                IsFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;

                clsLogError.LogError(ex);
            }

            return IsFound;
        }

        public static int? AddNewApplication(int? ApplicationPersonID, DateTime ApplicationDate, int ?ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int UserID)
        {
            // This function will return the new person id if succeeded and null if not
            int? ApplicationID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into Application (ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, UserID)
                     values (@ApplicationPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @UserID)
                     select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
                        command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            ApplicationID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return ApplicationID;
        }

        public static bool UpdateApplication(int? ApplicationID, int? ApplicationPersonID, DateTime ApplicationDate, int? ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int UserID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update Application
                                     set ApplicationPersonID = @ApplicationPersonID,
                                     ApplicationDate = @ApplicationDate,
                                     ApplicationTypeID = @ApplicationTypeID,
                                     ApplicationStatus = @ApplicationStatus,
                                     LastStatusDate = @LastStatusDate,
                                     PaidFees = @PaidFees,
                                     UserID = @UserID
                                     where ApplicationID = @ApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", (object)ApplicationID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
                        command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return (RowAffected > 0);
        }

        public static bool DeleteApplication(int? ApplicationID)
        {
            return clsDataAccessHelper.Delete("delete Application where ApplicationID = @ApplicationID", "ApplicationID", ApplicationID);
        }

        public static bool DoesApplicationExist(int? ApplicationID)
        {
            return clsDataAccessHelper.Exists("select IsFound =1 from Application where ApplicationID = @ApplicationID", "ApplicationID", ApplicationID);
        }

        public static DataTable GetAllApplications()
        {
            return clsDataAccessHelper.All("select * from Application");
        }

        public static bool UpdateStatus(int? ApplicationID ,byte ApplicationStatus)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update Application
                                     set 
                                     ApplicationStatus = @ApplicationStatus
                                     where ApplicationID = @ApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", (object)ApplicationID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return (RowAffected > 0);
        }
    }
}
