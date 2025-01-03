using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLAyer
{
    public class clsUserDataaccessLayer
    {
        static public int AddNewUserToDataBase(string UserName,string Password,int Permissions)
        {
            int CurrentID;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "INSERT INTO [dbo].[Users]\r\n  " +
                "         ([UserName]\r\n           " +
                ",[Password]\r\n          " +
                " ,[Permissions])\r\n    " +
                " VALUES\r\n       " +
                "    (@UserName,@Password,@Permissions)"
                + "\nselect SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
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
                CurrentID = -1;
            }
            finally { connection.Close(); }
            return CurrentID;
        }
        static public bool UpdateUserToDataBase(int UserID, string UserName, string Password, int Permissions) 
        {
            bool res=false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "UPDATE [dbo].[Users]\r\n   SET" +
                " [UserName] = @UserName\r\n  " +
                "    ,[Password] = @Password\r\n  " +
                "    ,[Permissions] = @Permissions\r\n" +
                " WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                res = command.ExecuteNonQuery() > 0;


            }
            catch (Exception ex)
            {
                // msj = ex.Message;
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public bool DeleteUserToDataBase(int UserID) 
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = "DELETE FROM [dbo].[Users]\r\n      WHERE Users.UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                res = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                res = false;
            }
            finally { connection.Close(); }
            return res;
        }

        static public DataTable GetAllUsersFromDb()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = "SELECT *FROM Users";
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

        static public bool FindByID(int UserID,ref string UserName,ref string Password,ref int Permissions)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
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

        static public bool FindByUserName(ref int UserID,string UserName, ref string Password, ref int Permissions)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string Query = "SELECT *FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
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
