using BusinessLogicLayer;
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
    public partial class frmEchange : Form
    {
        frmCurrencies _father;
        clsCurrrency currrencyto;
        clsCurrrency currrency;
        public frmEchange(frmCurrencies father)
        {
            InitializeComponent();
            _father = father;
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c))
            {
                e.Handled = true;
            }
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            object obj = _father.Tag;
            frmFindCurrencies frm = new frmFindCurrencies(_father);
           
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            
            gbfrom.Controls.Clear();
             currrency = _father.Tag as clsCurrrency;
            if(currrency != null)
            {
                usCurrencyPrprties us = new usCurrencyPrprties(currrency.CurrencyID, currrency.Country, currrency.CurrencyName, currrency.CurrencyCode, currrency.flagPath, currrency.Rate);
                us.Dock = DockStyle.Top;
                gbfrom.Controls.Add(us);
                us.Size = gbfrom.Size;
                lblFirstCurrencyCode.Text = currrency.CurrencyCode;
            }

            _father.Tag = obj;
        }

        private void btnto_Click(object sender, EventArgs e)
        {
            object obj = _father.Tag;
            frmFindCurrencies frm = new frmFindCurrencies(_father);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            gbto.Controls.Clear();
             currrencyto = _father.Tag as clsCurrrency;
            if (currrencyto != null)
            {
                usCurrencyPrprties us = new usCurrencyPrprties(currrencyto.CurrencyID, currrencyto.Country, currrencyto.CurrencyName, currrencyto.CurrencyCode, currrencyto.flagPath, currrencyto.Rate);
                us.Dock = DockStyle.Top;
                gbto.Controls.Add(us);
                us.Size = gbto.Size;
                lblSecondCurrencyCode.Text = currrencyto.CurrencyCode;
            }

            _father.Tag = obj;
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if(currrencyto != null&&currrencyto!=null)
            {
                if (tbAmount.Text.Length > 0)
                {
                    double amount = Convert.ToDouble(tbAmount.Text);
                    double amount2 = currrency.ExchangeThisTo(currrencyto, amount);
                    tbFinalResult.Text = amount2.ToString();
                }
            }
        }
    }
}
