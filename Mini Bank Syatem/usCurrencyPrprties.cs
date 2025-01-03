using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Bank_Syatem
{
    public partial class usCurrencyPrprties : UserControl
    {
        int CurrencyID = 0;
        string Country = "";
        string CuuName = "";
        string CurCode = "";
        string flagPAth = "";
        double Rate = 0;
        //ContextMenuStrip strip;
        public usCurrencyPrprties(int CurrencyID,string Country,string CuuName,string CurCode,string flagPAth,double Rate )
        {
            this.CurrencyID = CurrencyID;
            this.Country = Country;
            this.CuuName = CuuName;
            this.CurCode = CurCode;
            this.Rate = Rate;
            this.flagPAth = flagPAth;
            
            InitializeComponent();
        }

        private void usCurrencyPrprties_Load(object sender, EventArgs e)
        {
            lblCode.Text = CurCode;
            lblCountry.Text = Country;
            lblCurrencyID.Text = CurrencyID.ToString();
            lblNAme.Text = CuuName;
            lblRate.Text = Rate.ToString();
            if (flagPAth != "")
            {
                pbFlag.Image = Image.FromFile(flagPAth);
            }
        }

        private void usCurrencyPrprties_MouseEnter(object sender, EventArgs e)
        {
           

        }
    }
}
