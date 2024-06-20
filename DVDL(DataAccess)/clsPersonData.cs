using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDL_HelperLayer_;

namespace DVDL_DataAccess_
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int? PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from People where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : null;
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null;
                                NationalityCountryID = (int)reader["NationalityCountryID"];
                                ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;
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

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int? PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from People where NationalNo = @NationalNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", (object)NationalNo ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : null;
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null;
                                NationalityCountryID = (int)reader["NationalityCountryID"];
                                ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : null;
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

        public static int? AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int? NationalityCountryID, string ImagePath)
        {
            // This function will return the new person id if succeeded and null if not
            int? PersonID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"insert into People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
                                    values (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath)
                                     select scope_identity()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertID))
                        {
                            PersonID = InsertID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError(ex);
            }

            return PersonID;
        }

        public static bool UpdatePerson(int? PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int? NationalityCountryID, string ImagePath)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update People
                                         set NationalNo = @NationalNo,
                                         FirstName = @FirstName,
                                         SecondName = @SecondName,
                                         ThirdName = @ThirdName,
                                         LastName = @LastName,
                                         DateOfBirth = @DateOfBirth,
                                         Gender = @Gender,
                                         Address = @Address,
                                         Phone = @Phone,
                                         Email = @Email,
                                         NationalityCountryID = @NationalityCountryID,
                                         ImagePath = @ImagePath
                                         where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", (object)ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", (object)ImagePath ?? DBNull.Value);

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

        public static bool DeletePerson(int? PersonID)
        {
            return clsDataAccessHelper.Delete("delete People where PersonID = @PersonID", "PersonID", PersonID);
        }

        public static bool DoesPersonExist(int? PersonID)
        {
            return clsDataAccessHelper.Exists("select found = 1 from People where PersonID = @PersonID", "PersonID", PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsDataAccessHelper.All("select * from peopleInfo");
        }

        public static bool PersonExistsWithNationalNo(string NationalNo)
        {
            return clsDataAccessHelper.Exists("Select isFound =1 from People where NationalNo=@NationalNo ", "NationalNo", NationalNo);
        }
    }
}
