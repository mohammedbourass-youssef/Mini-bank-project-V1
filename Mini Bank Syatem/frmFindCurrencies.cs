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
    public partial class frmFindCurrencies : Form
    {
        enum enMode {enCode,enName,enCountry }
        frmCurrencies _father= null;    
        public frmFindCurrencies()
        {
            InitializeComponent();
        }
        public frmFindCurrencies(frmCurrencies father)
        {
            _father = father;
            InitializeComponent();
        }
        enMode _Mode;
        void _GetMode()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: _Mode = enMode.enCountry; break;
                case 1: _Mode = enMode.enCode; break;
                case 2: _Mode = enMode.enName; break;
            }


        }

        clsCurrrency _FindCurrency()
        {
            _GetMode();
            if(_Mode == enMode.enCode)
            {
                return clsCurrrency.FindByCode(tbSearch.Text);
            }
            else if(_Mode == enMode.enName)
            {
                return clsCurrrency.FindByCurrencyName(tbSearch.Text);
            }
            else if(_Mode==enMode.enCountry) 
                return clsCurrrency.FindByCountry(tbSearch.Text);
            return null;
        }

        void _GetInfo()
        {
            clsCurrrency currrency = _FindCurrency();
            if(currrency == null)
            {
                pnlChild.Controls.Clear();
                pnlChild.Controls.Add(label1);
                label1.Text = "This Currency Not Found";
                label1.BackColor = Color.Red;
            }
            else
            {
                pnlChild.Controls.Clear();
                
                usCurrencyPrprties us = new usCurrencyPrprties(currrency.CurrencyID,currrency.Country,currrency.CurrencyName,currrency.CurrencyCode,currrency.flagPath,currrency.Rate);
                pnlChild.Controls.Add(us);
                pnlChild.Size = us.Size;
                
                us.Dock = DockStyle.Fill;
            }
        }
        private void frmFindCurrencies_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbSearch.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbSearch.Text.Length != 0)
            {
                _GetInfo();
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if(tbSearch.Text == tbSearch.Tag.ToString())
            {
                tbSearch.Text = string.Empty;
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if(tbSearch.Text == string.Empty)
            {
                tbSearch.Text = tbSearch.Tag.ToString();
            }
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
              
        }

        private void frmFindCurrencies_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            if (_father == null)
            {
                button1.Visible = false;
            }
        }

        private void pnlChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _father.Tag = _FindCurrency();
            this.Close();
        }
    }
}
