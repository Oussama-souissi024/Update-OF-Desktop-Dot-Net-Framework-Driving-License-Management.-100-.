using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccessLayer
{
    public class clsLicensesDataAccess
    {
        public static bool GetLicenseInfoByID(int LicenseID, ref int applicationID, ref int driverID, ref int licenseClass, ref DateTime issueDate, ref DateTime expirationDate,
                                               ref string notes, ref decimal paidFees, ref bool isActive, ref int issueReason, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            //command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int)).Value = PresonID;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found

                    applicationID = (int)Convert.ToInt32(reader["applicationID"]);
                    driverID = (int)Convert.ToInt32(reader["driverID"]);
                    licenseClass = (int)Convert.ToInt32(reader["licenseClass"]);
                    issueDate = (DateTime)reader["issueDate"];
                    expirationDate = (DateTime)reader["expirationDate"];

                    if (reader["notes"] != DBNull.Value)
                    {
                        notes = (string)reader["notes"];
                    }
                    else
                        notes = ""; 
                    paidFees = (decimal)reader["paidFees"];
                    isActive = (bool)Convert.ToBoolean(reader["isActive"]);
                    issueReason = (int)Convert.ToInt32(reader["issueReason"]);
                    createdByUserID = (int)Convert.ToInt32(reader["createdByUserID"]);

                    isFound = true;
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool IsLicenseExist(int LicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static string GetLicenceDriverNameByLicenseID(int LicenseID)
        {
            string FullName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT FirstName,SecondName,ThirdName,LastName  FROM " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FullName += (string)reader["FirstName"];
                    FullName += " " + (string)reader["SecondName"];
                    FullName += " " + (string)reader["ThirdName"];
                    FullName += (string)reader["LastName"];
                }
                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return FullName;
        }

        public static string GetLicenseDriverNationalNoByLicenseID(int LicenseID)
        {
            string DriverNationalNo = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT NationalNo  FROM " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverNationalNo += (string)reader["NationalNo"];
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return DriverNationalNo;
        }

        public static string GetLicenseDriverGendorByLicenceID(int LicenseID)
        {
            string DriverGendor = "";
            int Result = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Gendor  FROM  " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Result = (int)Convert.ToInt32(reader["Gendor"]);
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (Result == 1)
                DriverGendor = "Male";
            else if (Result == 0)
                DriverGendor = "Female";
            else
                DriverGendor = "";

            return DriverGendor;
        }

        public static DateTime GetLicenseDriverDateOfBirthByLicenseID(int LicenseID)
        {
            DateTime DriverDateOfBirth = DateTime.Now;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT DateOfBirth FROM " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverDateOfBirth = (DateTime)reader["DateOfBirth"]; 
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return DriverDateOfBirth;
        }

        public static string  GetLicenseDriverImagePathByLicenseID(int LicenseID)
        {
            string DriverImagePath = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT People.ImagePath  FROM  " +
                " People INNER JOIN Drivers ON People.PersonID = Drivers.PersonID " +
                " INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID" +
                " Where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverImagePath = (string)(reader["ImagePath"]);
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return DriverImagePath;
        }

        public static bool IsDriverIDHaveThisLicense(int DriverID, int LicenseClass)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Licenses WHERE DriverID = @DriverID and LicenseClass = @LicenseClass";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetDriverLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT     
                           Licenses.LicenseID,
                           ApplicationID,
		                   LicenseClasses.ClassName, Licenses.IssueDate, 
		                   Licenses.ExpirationDate, Licenses.IsActive
                           FROM Licenses INNER JOIN
                                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where DriverID=@DriverID
                            Order By IsActive Desc, ExpirationDate Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                              INSERT INTO Licenses
                               (ApplicationID,
                                DriverID,
                                LicenseClass,
                                IssueDate,
                                ExpirationDate,
                                Notes,
                                PaidFees,
                                IsActive,IssueReason,
                                CreatedByUserID)
                         VALUES
                               (
                               @ApplicationID,
                               @DriverID,
                               @LicenseClass,
                               @IssueDate,
                               @ExpirationDate,
                               @Notes,
                               @PaidFees,
                               @IsActive,@IssueReason, 
                               @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);

            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes == "")
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return LicenseID;

        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
             DateTime IssueDate, DateTime ExpirationDate, string Notes,
             decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Licenses
                           SET ApplicationID=@ApplicationID, DriverID = @DriverID,
                              LicenseClass = @LicenseClass,
                              IssueDate = @IssueDate,
                              ExpirationDate = @ExpirationDate,
                              Notes = @Notes,
                              PaidFees = @PaidFees,
                              IsActive = @IsActive,IssueReason=@IssueReason,
                              CreatedByUserID = @CreatedByUserID
                         WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes == "")
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT        Licenses.LicenseID
                            FROM Licenses INNER JOIN
                                                     Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE  
                             
                             Licenses.LicenseClass = @LicenseClass 
                              AND Drivers.PersonID = @PersonID
                              And IsActive=1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return LicenseID;
        }

        public static int GetDriverIDByLicenseID(int LicenseID)
        {
            int  DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT  DriverID FROM Licenses  where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverID = (int)reader["DriverID"];
                }

                reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return DriverID;
        }

        public static bool IsExpired(int LicenseID)

        {
            bool isExpired = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT ExpirationDate FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime ResponceQueryDate = (DateTime)reader["ExpirationDate"];
                    if (ResponceQueryDate < DateTime.Now)
                        isExpired = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isExpired = false;
            }
            finally
            {
                connection.Close();
            }

            return isExpired;
        }

        public static bool DeactivateLicense(int LicenseID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Licenses
                           SET 
                              IsActive = 0
                             
                         WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}

