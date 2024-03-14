using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsLicenseClassesDataAccess
    {

        public static string GetLicenseClassNameByLicenseClassID(int LicenseClassID)
        {
            string LicenseClassName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    LicenseClassName = (string)reader["ClassName"];
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

            return LicenseClassName;
        }

        public static bool IsPersonHaveMinimumLicenseAge(int PersonAge, int LicenseClassID)
        {
            bool IsPersonHaveMinimumLicenseAge = false;
            int MinimumAllowedAge = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT MinimumAllowedAge FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    MinimumAllowedAge = (int)Convert.ToInt32(reader["MinimumAllowedAge"]);
                    if (MinimumAllowedAge <= PersonAge)
                        IsPersonHaveMinimumLicenseAge = true;
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
            return IsPersonHaveMinimumLicenseAge;
        }

        public static bool GetLicenseClassInfoByID(int LicenseClassID,
             ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge,
             ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToDecimal(reader["ClassFees"]);

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
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
