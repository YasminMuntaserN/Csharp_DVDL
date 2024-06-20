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
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int? CountryID, ref string CountryName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Countries where CountryID = @CountryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                CountryName = (string)reader["CountryName"];
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

        public static bool GetCountryInfoByName( string CountryName , ref int? CountryID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Countries where CountryName = @CountryName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("CountryName", CountryName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                CountryID = (int)reader["CountryID"];
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

        public static int? AddNewCountry(string CountryName)
        {
            // This function will return the new person id if succeeded and null if not
            int? CountryID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into Countries (CountryName)
                                     values (@CountryName)
                                     select scope_identity()";
                                     
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryName", CountryName);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            CountryID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return CountryID;
        }

        public static bool UpdateCountry(int? CountryID, string CountryName)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update Countries
                                      set CountryName = @CountryName
                                      where CountryID = @CountryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CountryName", CountryName);

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

        public static bool DeleteCountry(int? CountryID)
        {
            return clsDataAccessHelper.Delete("delete Countries where CountryID = @CountryID", "CountryID", CountryID);
        }

        public static bool DoesCountryExist(int? CountryID)
        {
            return clsDataAccessHelper.Exists("select found = 1 from Countries where CountryID = @CountryID", "CountryID", CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsDataAccessHelper.All("select * from Countries");
        }
    }
}
