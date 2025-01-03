using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLAyer
{
    public class clsCurrenciesDataAccess
    {
          
        static public DataTable GetAllCurrenciesFromDb()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = "SELECT *FROM Currencies ORDER BY Country ASC";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally { connection.Close(); }
            return dt;
        }


        static public bool FindByID(int CurrencyID, ref string CurrencyName, ref string CurrencyCode, ref string Country, ref float Rate,ref string CountryPicturePath)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Currencies WHERE CurrencyID = @CurrencyID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    
                    CurrencyName = (string)reader["CurrencyName"];
                    CurrencyCode = (string)reader["CurrencyCode"];
                    Country = (string)reader["Country"];
                    CountryPicturePath = (string)reader["CountryPicturePath"];
                    Rate = (float)reader["Rate"];


                    res = true;
                }
                else
                    res = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }
        static public bool FindByCode(ref int CurrencyID, ref string CurrencyName,  string CurrencyCode, ref string Country, ref float Rate, ref string CountryPicturePath)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Currencies WHERE CurrencyCode = @CurrencyID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyCode);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {



                    CurrencyName = (string)reader["CurrencyName"];
                    CurrencyID = (int)reader["CurrencyID"];
                    Country = (string)reader["Country"];
                    CountryPicturePath = (string)reader["CountryPicturePath"];
                    Rate = (float)reader["Rate"];


                    res = true;
                }
                else
                    res = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }
        static public bool FindByCountry(string Country, ref string CurrencyName, ref string CurrencyCode, ref int CurrencyID, ref float Rate,ref string CountryPicturePath)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Currencies WHERE Country = @Country";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    CurrencyID = (int)reader["CurrencyID"];
                    CurrencyName = (string)reader["CurrencyName"];
                    CurrencyCode = (string)reader["CurrencyCode"];
                    CountryPicturePath = (string)reader["CountryPicturePath"];
                    
                    Rate = (float)reader["Rate"];


                    res = true;
                }
                else
                    res = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public bool FindByCurrencyname(string CurrencyName, ref int CurrencyID, ref string CurrencyCode, ref string Country, ref float Rate,ref string CountryPicturePath)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Currencies WHERE CurrencyName = @CurrencyName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    CurrencyID = (int)reader["CurrencyID"];
                    
                    CurrencyCode = (string)reader["CurrencyCode"];
                    Country = (string)reader["Country"];
                    CountryPicturePath = (string)reader["CountryPicturePath"];
                    Rate = (float)reader["Rate"];
                    res = true;
                }
                else
                    res = false;
                reader.Close();


            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public bool UpdateRate(int CurrencyID, float Rate)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = "UPDATE [dbo].[Currencies]\r\n   " +
                "SET \r\n     " +
                " [Rate] = @Rate\r\n " +
                "WHERE " +
                "CurrencyID = @CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Rate", Rate);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }


       


    }
}
