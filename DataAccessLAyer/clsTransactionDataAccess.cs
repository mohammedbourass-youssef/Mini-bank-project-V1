using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLAyer
{
    public class clsTransactionDataAccess
    {
        static public int ADDNewTransaction(int clientID, int userID, int transactiontypeID,double amount)
        {
            int CurrentID;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "INSERT INTO [dbo].[Transactions]\r\n        " +
                "   ([ClientID]\r\n           ,[UserID]\r\n           ,[TransactionTypeID]\r\n           ,[Amount])\r\n   " +
                "  VALUES\r\n        " +
                "   (@ClientID\r\n           ,@UserID\r\n           ,@TransactionTypeID\r\n           ,@Amount)"
                + "\nselect SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", clientID);
            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@TransactionTypeID", transactiontypeID);
            command.Parameters.AddWithValue("@Amount", (SqlMoney)amount);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    CurrentID = ID;
                else
                    CurrentID = -1; 


            }
            catch (Exception ex)
            {
                // msj = ex.Message;
                Console.WriteLine(ex.Message);
                CurrentID = -1;
            }
            finally { connection.Close(); }
            return CurrentID;
        }

       

        //Delete Function Haven't to
        static public DataTable GetAllTransactionsFromDb()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = "SELECT *FROM Transactions";
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

        static public DataTable GetAllTransactionsByUser(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = "SELECT *FROM Transactions WHERE UserID = @UserID";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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

        static public DataTable GetAllTransactionsOfClient(int ClientID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = "SELECT *FROM Transactions WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ClientID);
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

        static public bool FindByID(int transactionID,ref int clientID,ref int userID,ref int transactiontypeID,ref double amount)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Transactions WHERE TransactionID = @TransactionID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TransactionID", transactionID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    
                    clientID = (int)reader["ClientID"];
                    userID = (int)reader["UserID"];
                    transactiontypeID = (int)reader["TransactionTypeID"];
                    amount = (double)reader["Amount"];
                   

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

        static public bool FindByClientID( ref int transactionID,  int clientID, ref int userID, ref int transactiontypeID, ref double amount)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Transactions WHERE ClientID = @ClientID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", clientID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    transactionID = (int)reader["TransactionID"];
                    userID = (int)reader["UserID"];
                    transactiontypeID = (int)reader["TransactionTypeID"];
                    amount = (double)reader["Amount"];


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
        static public bool DeleteByUserIDID(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = @"Delete from Transactions WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", UserID);

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

        static public bool DeleteByClientID(int ClientID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);

            string query = @"Delete from Transactions WHERE ClientID = @ClientID";

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

        static public bool FindByUserID(ref int transactionID,ref int clientID,  int userID, ref int transactiontypeID, ref double amount)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Transactions WHERE UserID  = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", userID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    transactionID = (int)reader["TransactionID"];
                    clientID = (int)reader["ClientID"];
                    transactiontypeID = (int)reader["TransactionTypeID"];
                    amount = (double)reader["Amount"];


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
    }
}
