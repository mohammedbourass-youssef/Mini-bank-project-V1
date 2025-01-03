using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsTransactionType
    {
       static public int Withdraw = 2;
       static public int Deposit = 1;
       static public string WithdrawName = "WITHDRAW";
       static public string DepositName = "DEPOSIT";

       static public string GetNAmeUsingID(int type)
        {
            if (type == Withdraw) return WithdrawName;
            else return DepositName;
        }
    }
}
