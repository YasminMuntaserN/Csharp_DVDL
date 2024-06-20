using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDL_DataAccess_;

namespace DVDL_HelperLayer_
{
    public class clsDataAccessHelper
    {
        public static DataTable All(string storedProcedureName)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return dt;
        }

        public static DataTable All<T>(string storedProcedureName, string parameterName, T value)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.Parameters.AddWithValue($"@{parameterName}", (object)value ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return dt;
        }

        public static bool Delete<T>(string storedProcedureName, string parameterName, T value)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        //command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue($"@{parameterName}", (object)value ?? DBNull.Value);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return (rowAffected > 0);
        }

        public static bool Exists<T>(string storedProcedureName, string parameterName, T value)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {

                        command.Parameters.AddWithValue($"@{parameterName}", (object)value ?? DBNull.Value);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsLogError.LogError(ex);
            }

            return isFound;
        }

        public static bool Exists<T1, T2>(string storedProcedureName, string parameterName1, T1 value1, string parameterName2, T2 value2)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {

                        command.Parameters.AddWithValue($"@{parameterName1}", (object)value1 ?? DBNull.Value);
                        command.Parameters.AddWithValue($"@{parameterName2}", (object)value2 ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsLogError.LogError(ex);
            }

            return isFound;
        }

        public static int Count(string storedProcedureName)
        {
            int countNum = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            countNum = insertedID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }
            return countNum;
        }
    }
}
