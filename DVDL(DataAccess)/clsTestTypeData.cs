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
    public class clsTestTypeData
    {
        public static bool GetTestTypeInfoByID(int? TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from TestTypes where TestTypeID = @TestTypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", (object)TestTypeID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                TestTypeTitle = (string)reader["TestTypeTitle"];
                                TestTypeDescription = (string)reader["TestTypeDescription"];
                                TestTypeFees = (decimal)reader["TestTypeFees"];
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
                clsLogError.LogError(ex);
            }

            return IsFound;
        }

        public static int? AddNewTestType(string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            // This function will return the new person id if succeeded and null if not
            int? TestTypeID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into TestTypes (TestTypeTitle, TestTypeDescription, TestTypeFees)
                                     values (@TestTypeTitle, @TestTypeDescription, @TestTypeFees)
                                     select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            TestTypeID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return TestTypeID;
        }

        public static bool UpdateTestType(int? TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update TestTypes
                                     set TestTypeTitle = @TestTypeTitle,
                                     TestTypeDescription = @TestTypeDescription,
                                     TestTypeFees = @TestTypeFees
                                     where TestTypeID = @TestTypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", (object)TestTypeID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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

        public static bool DeleteTestType(int? TestTypeID)
        {
            return clsDataAccessHelper.Delete("delete TestTypes where TestTypeID = @TestTypeID", "TestTypeID", TestTypeID);
        }

        public static bool DoesTestTypeExist(int? TestTypeID)
        {
            return clsDataAccessHelper.Exists("select found = 1 from TestTypes where TestTypeID = @TestTypeID", "TestTypeID", TestTypeID);

        }

        public static DataTable GetAllTestTypes()
        {
            return clsDataAccessHelper.All("select * from TestTypes");
        }
    }
}
