using DataAccessLAyer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsUser
    {
        //URGENT IMPORTANT INFO :  after Save method Excuted , the last identity(the ID For the user just added ) given to userID . You can use it withoout problem  
        /*Presentation layer script for Permissions : 
         *  enum EnPermissions { AllPermissions = -1, ManageClient = 0, ManageUser = 2, Transactions = 4 }
         bool _CheckUserPermissions(EnPermissions enPermissions)
         {
             if(Convert.ToInt32(EnPermissions.AllPermissions) == _CurrentUser.permissions)
                 return true;
             else if((Convert.ToInt32(enPermissions)&_CurrentUser.permissions)== Convert.ToInt32(enPermissions))
                 return true;
             else
                 return false;
         }*/

        enum EnMode { Addnew , Update}
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int permissions { get; set; }
        EnMode mode { get; set; }
        bool _AddNew()
        {
            userID = clsUserDataaccessLayer.AddNewUserToDataBase(username, password, permissions);
            return  userID!= -1;
        }
        bool _Update()
        {
            return clsUserDataaccessLayer.UpdateUserToDataBase(userID, username, password, permissions);
        }
       
       
        public clsUser()  { 
            userID = -1;
            username = string.Empty;
            password = string.Empty;
            permissions = -100;
            mode = EnMode.Addnew;
        }
       
        clsUser(int userid,string username,string password,int permissions)
        {
            this.userID = userid;
            this.username = username;
            this.password = password;
            this.permissions = permissions;
            mode = EnMode.Update;
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataaccessLayer.GetAllUsersFromDb();
        }
        
        public static double TotaleBalance()
        {
            DataTable dataTable = clsClient.GetAllClients();
            double balance = 0;
            foreach(DataRow row in dataTable.Rows)
            {
                balance += Convert.ToInt32(row["Balance"]);
            }
            return balance;
        }

        static public bool Delete(int UserID)
        {
            return clsUserDataaccessLayer.DeleteUserToDataBase(UserID);
        }
       
        public bool Delete()
        {
            clsTransaction.DeleteByUserID(userID);
            return clsUserDataaccessLayer.DeleteUserToDataBase(userID);
        } 
       
        static public clsUser Find(int userID)
        {
            //int userID = 0;
            string username = "";
            string password = "";
            int permissions = 0;
       
            if (clsUserDataaccessLayer.FindByID(userID, ref username, ref password, ref permissions))
                return new clsUser(userID, username, password, permissions);
            else
               return  null;
       
        }
       
        static public clsUser Find(string username)
        {
            int userID = 0;
            //string username = "";
            string password = "";
            int permissions = 0;
       
            if (clsUserDataaccessLayer.FindByUserName(ref userID,username, ref password, ref permissions))
                return new clsUser(userID, username, password, permissions);
            else
                return null;
       
        }
       
        public bool Save()
        {
            switch(mode)
            {
                case EnMode.Update:return _Update();
                case EnMode.Addnew: mode = EnMode.Update;return _AddNew();
                default: return false;
            }
        }
       
       
       }
       }
