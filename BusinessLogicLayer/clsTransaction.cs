using DataAccessLAyer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsTransaction
    {
        
        public int TransactionID { get; set; }
        public int TransactionTypeID { get; set; }
        public int clientID { get; set; }
        public int userID { get; set; }
        public double amount { get; set; }



        public clsTransaction()
        {
            TransactionID = 0;
            TransactionTypeID = 0;
            clientID = 0;
            userID = 0;
            amount = 0;
        }

        clsTransaction(int transactionID, int transactionTypeID, int clientID, int userID, double amount)
        {
            TransactionID = transactionID;
            TransactionTypeID = transactionTypeID;
            this.clientID = clientID;
            this.userID = userID;
            this.amount = amount;
        }

        public bool Save()
        {
            TransactionID = clsTransactionDataAccess.ADDNewTransaction(clientID, userID, TransactionTypeID, amount);
            return TransactionID != -1;
        }

        public static DataTable GetAllTransactions()
        {
            return clsTransactionDataAccess.GetAllTransactionsFromDb();
        }

        public DataTable GetAllTransactionsOfUser()
        {
            return clsTransactionDataAccess.GetAllTransactionsByUser(userID);
        }

        public static clsTransaction Find(int TransID)
        {
           //int  transactionID;
           int transactionTypeID=0;
           int  clientID  =0  ;
           int  userID =0   ;
           double amount = 0;

            if (clsTransactionDataAccess.FindByID(TransID, ref clientID, ref userID,ref transactionTypeID,ref amount))
                return new clsTransaction(TransID, transactionTypeID, clientID, userID, amount);
            else
                return null;
        }

        public static clsTransaction FindByClientID(int clientID)
        {
            //int  transactionID;
            int transactionTypeID = 0;
            int TransID = 0;
            int userID = 0;
            double amount = 0;

            if (clsTransactionDataAccess.FindByClientID(ref TransID,  clientID, ref userID, ref transactionTypeID, ref amount))
                return new clsTransaction(TransID, transactionTypeID, clientID, userID, amount);
            else
                return null;
        }
        public static clsTransaction FindByUserID(int userID)
        {
            //int  transactionID;
            int transactionTypeID = 0;
            int TransID = 0;
            int clientID = 0;
            double amount = 0;

            if (clsTransactionDataAccess.FindByUserID(ref TransID,ref clientID,  userID, ref transactionTypeID, ref amount))
                return new clsTransaction(TransID, transactionTypeID, clientID, userID, amount);
            else
                return null;
        }

        static public bool DeleteByUserID(int userID)
        {
            
                
                return clsTransactionDataAccess.DeleteByUserIDID(userID);
        }
        static public bool DeleteByClientID(int clientID)
        {


            return clsTransactionDataAccess.DeleteByUserIDID(clientID);
        }

    }
}
