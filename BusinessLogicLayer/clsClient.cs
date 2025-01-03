using DataAccessLAyer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsClient
    {
        enum EnMode { Addnew, Update }
       public int ClientID {  get; set; }
       public string AccountNumber {  get; set; }
       public string PinCode {  get; set; }
       public string ClientName {  get; set; }
       public string Phone {  get; set; }
       public decimal Balance {  get; set; }
       public string PicturePath {  get; set; }
        
        EnMode mode { get; set; }
        bool _AddNew()
        {
            ClientID = clsClientDataAccess.AddNewClient(AccountNumber, PinCode, ClientName, Phone,Balance, PicturePath);
            return ClientID != -1;
        }
        bool _Update()
        {
            return clsClientDataAccess.UpdateClient(ClientID,AccountNumber, PinCode, ClientName, Phone, Balance, PicturePath);
        }

        public clsClient()
        {
            ClientID = 0;
            AccountNumber = "";
            PinCode = string.Empty;
            ClientName = string.Empty;
            Phone = string.Empty;
            Balance = 0;
            PicturePath = string.Empty;
            mode = EnMode.Addnew;
        }

         clsClient(int clientID, string accountNumber, string pinCode, string clientName, string phone, decimal balance,string picturepath)
        {
            ClientID = clientID;
            AccountNumber = accountNumber;
            PinCode = pinCode;
            ClientName = clientName;
            Phone = phone;
            Balance = balance;
            PicturePath = picturepath;
            this.mode = EnMode.Update;
        }

        public static DataTable GetAllClients()
        {
            return clsClientDataAccess.ClientsList();
        }

        public static bool Delete(int clientID)
        {
            return clsClientDataAccess.DeleteClient(clientID);
        }


        public bool AddAmount(decimal amount)
        {
            this.Balance += amount;
            return this.Save();
        }

        public bool Delete()
        {
           
            clsTransaction.DeleteByClientID(this.ClientID);
            return (clsClientDataAccess.DeleteClient(ClientID));
        }

        public static clsClient Find(int clientID)
        {
            //int clientID = 0;

            string accountNumber = "";
            string pinCode = "";
            string clientName = "";
            string phone = "";
            decimal balance = 0;
            string picturepath = string.Empty;
            if (clsClientDataAccess.FindByID(clientID, ref accountNumber, ref pinCode, ref clientName, ref phone, ref balance,ref picturepath))
                return new clsClient(clientID, accountNumber, pinCode, clientName, phone, balance, picturepath);
            else
                return null;

        }

        public static clsClient Find(string accountNumber)
        {
            int clientID = 0;

             
            string pinCode = "";
            string clientName = "";
            string phone = "";
            decimal balance = 0;
            string picturepath = string.Empty;
            if (clsClientDataAccess.FindByAccountNumber(accountNumber, ref clientID, ref pinCode, ref clientName, ref phone, ref balance,ref picturepath))
                return new clsClient(clientID, accountNumber, pinCode, clientName, phone, balance, picturepath);
            else
                return null;

        }

        public DataTable AllTransactions()
        {
            return clsTransactionDataAccess.GetAllTransactionsOfClient(ClientID);
        }
        public bool Save()
        {
            switch(mode)
            {
                case EnMode.Addnew:mode=EnMode.Addnew; return _AddNew();
                case EnMode.Update:return _Update();
                default: return false;
            }
        }
    }
}
