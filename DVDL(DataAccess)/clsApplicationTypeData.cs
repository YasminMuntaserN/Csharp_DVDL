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
    public class clsApplicationTypeData
    {
        public static bool GetApplicationTypeInfoByID(int? ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationTypeFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID", (object)ApplicationTypeID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                                ApplicationTypeFees = (decimal)reader["ApplicationTypeFees"];
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
            catch (SqlException ex)
            {
                IsFound = false;

                clsLogError.LogError(ex);
            }

            return IsFound;
        }

        public static int? AddNewApplicationType(string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            // This function will return the new person id if succeeded and null if not
            int? ApplicationTypeID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into ApplicationTypes (ApplicationTypeTitle, ApplicationTypeFees)
                                         values (@ApplicationTypeTitle, @ApplicationTypeFees)
                                         select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                        command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            ApplicationTypeID = InsertID;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogError.LogError(ex);
            }

            return ApplicationTypeID;
        }

        public static bool UpdateApplicationType(int? ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update ApplicationTypes
                                         set ApplicationTypeTitle = @ApplicationTypeTitle,
                                         ApplicationTypeFees = @ApplicationTypeFees
                                         where ApplicationTypeID = @ApplicationTypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID", (object)ApplicationTypeID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                        command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogError.LogError(ex);
            }

            return (RowAffected > 0);
        }

        public static bool DeleteApplicationType(int? ApplicationTypeID)
        {
           return clsDataAccessHelper.Delete("delete ApplicationTypes where ApplicationTypeID = @ApplicationTypeID" , "ApplicationTypeID", ApplicationTypeID);
        }

        public static bool DoesApplicationTypeExist(int? ApplicationTypeID)
        {
           return  clsDataAccessHelper.Exists("select found = 1 from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID", "ApplicationTypeID", ApplicationTypeID);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsDataAccessHelper.All("select * from ApplicationTypes");
        }
    }
}
