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
    public partial class FrmAllCurrencies : Form
    {
        Color _CurrentColor = Color.White;
        Size _formSize;
        frmCurrencies _father;
        List<clsCircularPictureButton> _currencies;
        public FrmAllCurrencies(Color color, Size size, frmCurrencies father, List<clsCircularPictureButton> currencies)
        {
            _CurrentColor = color;
            _formSize = size;
            _father = father;
            InitializeComponent();
            _currencies = currencies;
        }

        //void _LoadAllCurrencies()
        //{
        //    pnlBody.Controls.Clear();

        //    DataTable data = clsCurrrency.AllCurrencies();
        //    List<usCurrencyPrprties> currencyItems = new List<usCurrencyPrprties>();
        //    int i = 0;
        //    foreach (DataRow row in data.Rows)
        //    {
        //        var us = new usCurrencyPrprties(Convert.ToInt32(row["CurrencyID"]), Convert.ToString(row["Country"]), Convert.ToString(row["CurrencyName"]), Convert.ToString(row["CurrencyCode"]), Convert.ToString(row["CountryPicturePath"]), Convert.ToDouble(row["Rate"]), contextMenuStrip1);
        //        currencyItems.Add(us);



        //    }
        //    foreach(var us in currencyItems)
        //    {
        //        us.Dock = DockStyle.Top;
        //        us.ContextMenuStrip = contextMenuStrip1;
        //        pnlBody.Controls.Add(us);
        //    }

        //}
        void _LoadAllCurrencies()
        {
            pnlBody.Controls.Clear();
            
            pnlBody.AutoScroll = true;
            foreach (clsCircularPictureButton cur in _currencies)
            {
                pnlBody.Controls.Add(cur);
                cur.Dock = DockStyle.Top;
            }
        }
        private void FrmAllCurrencies_Load(object sender, EventArgs e)
        {
            _LoadAllCurrencies();
            this.Dock = DockStyle.Right;
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCurrency frm = new frmUpdateCurrency(Convert.ToInt32(contextMenuStrip1.Tag),_father);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void pnlBody_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(label2.BackColor == Color.White)
                label2.BackColor = Color.Blue;
            else
                label2.BackColor = Color.White;
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
