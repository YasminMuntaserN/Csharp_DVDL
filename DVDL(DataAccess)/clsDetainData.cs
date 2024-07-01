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
    public class clsDetainData
    {
        public static bool GetDetainInfoByID(int? DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from DetainedLicenses where DetainID = @DetainID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", (object)DetainID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = (decimal)reader["FineFees"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];
                                ReleaseDate = (reader["ReleaseDate"] != DBNull.Value) ? (DateTime?)reader["ReleaseDate"] : null;
                                ReleasedByUserID = (reader["ReleasedByUserID"] != DBNull.Value) ? (int?)reader["ReleasedByUserID"] : null;
                                ReleaseApplicationID = (reader["ReleaseApplicationID"] != DBNull.Value) ? (int?)reader["ReleaseApplicationID"] : null;
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

        public static bool GetDetainInfoByLicenseID(int? LicenseID, ref int? DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from DetainedLicenses where LicenseID = @LicenseID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", (object)LicenseID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                DetainID = (int)reader["DetainID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = (decimal)reader["FineFees"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];
                                ReleaseDate = (reader["ReleaseDate"] != DBNull.Value) ? (DateTime?)reader["ReleaseDate"] : null;
                                ReleasedByUserID = (reader["ReleasedByUserID"] != DBNull.Value) ? (int?)reader["ReleasedByUserID"] : null;
                                ReleaseApplicationID = (reader["ReleaseApplicationID"] != DBNull.Value) ? (int?)reader["ReleaseApplicationID"] : null;
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

        public static int? AddNewDetain(int? LicenseID, DateTime DetainDate, decimal FineFees, int? CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            // This function will return the new person id if succeeded and null if not
            int? DetainID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                                     values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID)
                                     select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);
                        command.Parameters.AddWithValue("@ReleaseDate", (object)ReleaseDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReleasedByUserID", (object)ReleasedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", (object)ReleaseApplicationID ?? DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            DetainID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return DetainID;
        }

        public static bool UpdateDetain(int? DetainID, int? LicenseID, DateTime DetainDate, decimal FineFees, int? CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update DetainedLicenses
                                     set LicenseID = @LicenseID,
                                     DetainDate = @DetainDate,
                                     FineFees = @FineFees,
                                     CreatedByUserID = @CreatedByUserID,
                                     IsReleased = @IsReleased,
                                     ReleaseDate = @ReleaseDate,
                                     ReleasedByUserID = @ReleasedByUserID,
                                     ReleaseApplicationID = @ReleaseApplicationID
                                     where DetainID = @DetainID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", (object)DetainID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);
                        command.Parameters.AddWithValue("@ReleaseDate", (object)ReleaseDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReleasedByUserID", (object)ReleasedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", (object)ReleaseApplicationID ?? DBNull.Value);

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

        public static bool DeleteDetain(int? DetainID)
        {
            return clsDataAccessHelper.Delete("delete DetainedLicenses where DetainID = @DetainID", "DetainID", DetainID);
        }

        public static bool DoesDetainExist(int? DetainID)
        {
            return clsDataAccessHelper.Exists("select found = 1 from DetainedLicenses where DetainID = @DetainID", "DetainID", DetainID);
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDataAccessHelper.All("select * from DetainedLicensesInfo");

        }

        public static bool IsLicenseDetained(int? LicenseID)
        {
            bool IsDetained = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select IsDetained=1 
                            from detainedLicenses 
                            where 
                            LicenseID=@LicenseID 
                            and IsReleased=0;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LicenseID", (object)LicenseID ?? DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            IsDetained = Convert.ToBoolean(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }
            return IsDetained;

        }

        public static bool ReleaseDetainedLicense(int? DetainID,
          int ?ReleasedByUserID, int ?ReleaseApplicationID)
        {

            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"UPDATE dbo.DetainedLicenses
                              SET IsReleased = 1, 
                              ReleaseDate = @ReleaseDate, 
                              ReleaseApplicationID = @ReleaseApplicationID   
                              WHERE DetainID=@DetainID;";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DetainID", DetainID);
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
                        command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
                return false;
            }
            return (rowsAffected > 0);
        }
    }
}
