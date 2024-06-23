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
    public class clsTestAppointmentData
    {
        public static bool GetTestAppointmentInfoByID(int? TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int? RetakeTestApplicationID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from TestAppointments where TestAppointmentID = @TestAppointmentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", (object)TestAppointmentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                TestTypeID = (int)reader["TestTypeID"];
                                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                                AppointmentDate = (DateTime)reader["AppointmentDate"];
                                PaidFees = (decimal)reader["PaidFees"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsLocked = (bool)reader["IsLocked"];
                                RetakeTestApplicationID = (reader["RetakeTestApplicationID"] != DBNull.Value) ? (int?)reader["RetakeTestApplicationID"] : null;
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

        public static int? AddNewTestAppointment(int TestTypeID, int? LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)
        {
            // This function will return the new person id if succeeded and null if not
            int? TestAppointmentID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                                  values (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID)
                                  select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", (object)RetakeTestApplicationID ?? DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            TestAppointmentID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment(int? TestAppointmentID, int TestTypeID, int? LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update TestAppointments
                                         set TestTypeID = @TestTypeID,
                                         LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                         AppointmentDate = @AppointmentDate,
                                         PaidFees = @PaidFees,
                                         CreatedByUserID = @CreatedByUserID,
                                         IsLocked = @IsLocked,
                                         RetakeTestApplicationID = @RetakeTestApplicationID
                                         where TestAppointmentID = @TestAppointmentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", (object)TestAppointmentID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", (object)RetakeTestApplicationID ?? DBNull.Value);

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

        public static bool DeleteTestAppointment(int? TestAppointmentID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete TestAppointments where TestAppointmentID = @TestAppointmentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", (object)TestAppointmentID ?? DBNull.Value);

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

        public static bool DoesTestAppointmentExist(int? TestAppointmentID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select found = 1 from TestAppointments where TestAppointmentID = @TestAppointmentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", (object)TestAppointmentID ?? DBNull.Value);

                        IsFound = (command.ExecuteScalar() != null);
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

        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from TestAppointments";

                    using (SqlCommand command = new SqlCommand(query, connection))
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

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsDataAccessHelper.All("SELECT TestAppointmentID, AppointmentDate,PaidFees, IsLocked FROM TestAppointments WHERE (TestTypeID = @TestTypeID) AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) order by TestAppointmentID desc;"
                , "LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID, "TestTypeID", TestTypeID);
        }
    }
}
