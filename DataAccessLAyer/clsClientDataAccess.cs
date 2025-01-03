using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLAyer
{
    public class clsClientDataAccess
    {
        static public DataTable ClientsList()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = "select * from Clients";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dtClients.Load(reader);
                }

                reader.Close();

            }

            catch(Exception ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return dtClients;

        }

        static public bool FindByID(int ClientID, ref string AccountNumber, ref string PinCode, ref string ClientName, ref string Phone,
                                    ref decimal Balance,ref string PicturePath)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = @"select * from Clients
                             where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];
                    ClientName = (string)reader["ClientName"];
                    Phone = (string)reader["Phone"];
                    if (reader["picturepath"] != DBNull.Value)
                        PicturePath = (string)reader["picturepath"];
                    else
                        PicturePath = "";
                    Balance = Convert.ToDecimal(reader["Balance"]);
                    res= true;
                }
                else
                    res = false;

                reader.Close();
            
            }

            catch(Exception ex)
            {
                //error message
                res = false;
            }

            finally
            {
                connection.Close();
            }
            return res;
        }

        static public bool FindByAccountNumber(string AccountNumber, ref int ClientID, ref string PinCode, ref string ClientName, ref string Phone,
                                    ref decimal Balance,ref string PicturePath)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = @"select * from Clients
                             where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ClientID = (int)reader["ClientID"];
                    PinCode = (string)reader["PinCode"];
                    ClientName = (string)reader["ClientName"];
                    Phone = (string)reader["Phone"];
                    Balance = Convert.ToDecimal(reader["Balance"]);
                    if (reader["picturepath"] != DBNull.Value)
                        PicturePath = (string)reader["picturepath"];
                    else
                        PicturePath = "";
                    res = true;
                }
                

                reader.Close();

            }

            catch (Exception ex)
            {
                //error message
                res= false;
            }

            finally
            {
                connection.Close();
            }
            return res;
        }

        static public int AddNewClient(string AccountNumber, string PinCode, string ClientName, string Phone, decimal Balance,string PicturePath)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = @"INSERT INTO Clients
                             values (@AccountNumber, @PinCode, @ClientName, @Phone, @Balance,@picturepath)
                             select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@ClientName", ClientName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Balance", Balance);
            if (!string.IsNullOrEmpty(PicturePath))
                command.Parameters.AddWithValue("@picturepath", PicturePath);
            else
                command.Parameters.AddWithValue("@picturepath", DBNull.Value);

            int NewClientID = -1;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                NewClientID = Convert.ToInt16(result);

            }

            catch(Exception ex)
            {
                //error message
                Console.WriteLine(ex.Message);
            }

            finally

            {
                connection.Close();
            }

            return NewClientID;

        }

        static public bool UpdateClient(int ClientID, string AccountNumber, string PinCode, string ClientName, string Phone, decimal Balance, string PicturePath)   
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = @"UPDATE Clients
                             SET AccountNumber = @AccountNumber,
                                 PinCode = @PinCode,
                                 ClientName = @ClientName,
                                 Phone = @Phone,
                                 Balance = @Balance,
                                 picturepath=@picturepath
                             WHERE ClientID = @ClientID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@ClientName", ClientName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Balance", Balance);
            if (!string.IsNullOrEmpty(PicturePath))
                command.Parameters.AddWithValue("@picturepath", PicturePath);
            else
                command.Parameters.AddWithValue("@picturepath", DBNull.Value);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                
            }

            catch(SqlException ex)
            {
                //error message
            }

            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        static public bool DeleteClient(int ClientID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = @"delete from Clients
                             where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            int rowsAffected = 0;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
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
