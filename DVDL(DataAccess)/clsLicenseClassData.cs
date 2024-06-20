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
    public class clsLicenseClassData
    {
        public static bool GetLicenseClassInfoByID(int? LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from LicenseClasses where LicenseClassID = @LicenseClassID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", (object)LicenseClassID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = (decimal)reader["ClassFees"];
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

        public static bool GetLicenseClassInfoByName( string ClassName, ref int? LicenseClassID,ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from LicenseClasses where ClassName = @ClassName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", ClassName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = (decimal)reader["ClassFees"];
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

        public static int? AddNewLicenseClass(string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            // This function will return the new person id if succeeded and null if not
            int? LicenseClassID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into LicenseClasses (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                                    values (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees)
                                    select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            LicenseClassID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return LicenseClassID;
        }

        public static bool UpdateLicenseClass(int? LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update LicenseClasses
                                     set ClassName = @ClassName,
                                     ClassDescription = @ClassDescription,
                                     MinimumAllowedAge = @MinimumAllowedAge,
                                     DefaultValidityLength = @DefaultValidityLength,
                                     ClassFees = @ClassFees
                                     where LicenseClassID = @LicenseClassID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", (object)LicenseClassID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);

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

        public static bool DeleteLicenseClass(int? LicenseClassID)
        {
            return clsDataAccessHelper.Delete("delete LicenseClasses where LicenseClassID = @LicenseClassID", "LicenseClassID", LicenseClassID);
        }
        public static DataTable GetAllLicenseClasses()
        {
            return clsDataAccessHelper.All("select * from LicenseClasses");
        }

    }
}
