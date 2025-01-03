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
    public partial class frmUpdateCurrency : Form
    {
        int _Id = 0;
        clsCurrrency currrency;
        frmCurrencies _father;
        public frmUpdateCurrency(int Id,frmCurrencies father)
        {
            _father = father;
            this._Id = Id;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(tbAmount.Text != "")
            {
                currrency.Rate = Convert.ToSingle(tbAmount.Text);
                currrency.Save();
                frmMyMessageBox frm = new frmMyMessageBox("Rate Updated Succefully", "ok");
                _father.btnCurrencies_Click(_father.btnCurrencies, e);
                frm.ShowDialog();
                this.Close();
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c))
            {
                e.Handled = true;
            }
        }

        private void frmUpdateCurrency_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            currrency = clsCurrrency.FindByID(this._Id);
            lblRate.Text = currrency.Rate.ToString();
            pictureBox1.Image = Image.FromFile(currrency.flagPath);
        }

        private void frmUpdateCurrency_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _father.btnCurrencies_Click(_father.btnCurrencies, e);
            this.Close();
        }
    }
}
