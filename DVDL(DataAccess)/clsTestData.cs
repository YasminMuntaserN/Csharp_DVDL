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
    public class clsTestData
    {
        public static bool GetTestInfoByID(int? TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Tests where TestID = @TestID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestID", (object)TestID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                TestAppointmentID = (int)reader["TestAppointmentID"];
                                TestResult = (bool)reader["TestResult"];
                                Notes = (reader["Notes"] != DBNull.Value) ? (string)reader["Notes"] : null;
                                CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int? AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            // This function will return the new person id if succeeded and null if not
            int? TestID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                    values (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)
                                    select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", TestResult);
                        command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            TestID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return TestID;
        }

        public static bool UpdateTest(int? TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update Tests
                                     set TestAppointmentID = @TestAppointmentID,
                                     TestResult = @TestResult,
                                     Notes = @Notes,
                                     CreatedByUserID = @CreatedByUserID
                                     where TestID = @TestID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestID", (object)TestID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", TestResult);
                        command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool DeleteTest(int? TestID)
        {
            return clsDataAccessHelper.Delete("delete Tests where TestID = @TestID", "TestID", TestID);
        }

        public static bool DoesTestExist(int? TestID)
        {
            return clsDataAccessHelper.Exists("select found = 1 from Tests where TestID = @TestID", "TestID", TestID);
        }

        public static DataTable GetAllTests()
        {
            return clsDataAccessHelper.All("select * from Tests");
        }

        public static int PassedTestCount(int? LocalDrivingLicenseApplicationID)
        {
            // This function will return the new person id if succeeded and null if not
            int PassedTestCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select count(TestID) from Tests Inner join TestAppointments 
                                     on Tests.TestAppointmentID =TestAppointments.TestAppointmentID 
                                     where TestAppointments.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID
                                     and  TestResult=1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            PassedTestCount = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return PassedTestCount;
        }
    }
}
