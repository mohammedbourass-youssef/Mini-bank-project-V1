using DataAccessLAyer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsCurrrency
    {
        public int CurrencyID { get; }
        public string CurrencyName { get; }
        public string CurrencyCode { get; }
        public string Country { get; }
        public float Rate { get; set; }

        public string flagPath { get; set; }
        clsCurrrency(int currencyID, string currencyName, string currencyCode, string country, float rate, string flagPath)
        {
            CurrencyID = currencyID;
            CurrencyName = currencyName;
            CurrencyCode = currencyCode;
            Country = country;
            Rate = rate;
            this.flagPath = flagPath;
        }


        public static DataTable AllCurrencies()
        {
            return clsCurrenciesDataAccess.GetAllCurrenciesFromDb();
        }

        public static clsCurrrency FindByID(int ID)
        {
            //int currencyID = 0;
            string currencyName = "";
            string currencyCode = "";
            string country = "";
            string Path = string.Empty; 
            float rate = 0;
            if (clsCurrenciesDataAccess.FindByID(ID, ref currencyName, ref currencyCode, ref country, ref rate,ref Path))
                return new clsCurrrency(ID, currencyName, currencyCode, country, rate, Path );
            else
                return null;
        }
        public static clsCurrrency FindByCode(string currencyCode)
        {
            int currencyID = 0;
            string currencyName = "";
            //string currencyCode = "";
            string country = "";
            string Path = string.Empty;
            float rate = 0;
            if (clsCurrenciesDataAccess.FindByCode(ref currencyID, ref currencyName,currencyCode, ref country, ref rate, ref Path))
                return new clsCurrrency(currencyID, currencyName, currencyCode, country, rate, Path);
            else
                return null;
        }

        public static clsCurrrency FindByCountry(string country)
        {
            int currencyID = 0;
            string currencyName = "";
            string currencyCode = "";
            string Path = string.Empty;
            //string country = "";
            float rate = 0;
            if (clsCurrenciesDataAccess.FindByCountry(country,ref currencyName, ref currencyCode, ref currencyID, ref rate,ref Path))
                return new clsCurrrency(currencyID, currencyName, currencyCode, country, rate,Path);
            else
                return null;
        }

        public static clsCurrrency FindByCurrencyName(string currencyname)
        {
            int currencyID = 0;
            //string currencyname = "";
            string currencyCode = "";
            string country = "";
            float rate = 0;
            string Path = string.Empty;
            if (clsCurrenciesDataAccess.FindByCurrencyname(currencyname,ref currencyID, ref currencyCode, ref country, ref rate, ref Path ))
                return new clsCurrrency(currencyID, currencyname, currencyCode, country, rate, Path );
            else
                return null;
        }

        public bool Save()
        {
            return clsCurrenciesDataAccess.UpdateRate(CurrencyID,Rate);
        }

        double ExchangeToUsd(clsCurrrency currrency,double amount)
        {
            return amount/currrency.Rate;
        }
        double ExchangeFromUsd(clsCurrrency currrency,double amount)
        {
            return amount * currrency.Rate;
        }
        public  double ExchangeThisTo(clsCurrrency currrency,double amount)
        {
            amount = ExchangeToUsd(this,amount);
            return ExchangeFromUsd((clsCurrrency)currrency,amount);
        }
    }
}
