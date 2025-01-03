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
    public partial class frmWithdrawDeposit : Form
    {
        Color _color;
        frmTransactions _father;
        int _type = 0;
        clsClient _senderClient;
        clsUser _user;
        public frmWithdrawDeposit(Color color ,frmTransactions father , int Type,clsUser user)
        {
            _user = user;
            _type = Type;
            _color = color;
            _father = father;
            InitializeComponent();
        }

        public frmWithdrawDeposit(Color color, frmTransactions father, int Type,clsClient client,clsUser user)
        {
            _user= user;
            _senderClient = client;
            _type = Type;
            _color = color;
            _father = father;
            InitializeComponent();
        }

     

        void _GiveFormName()
        {

            if (_type == clsTransactionType.Withdraw)
                lblName.Text = clsTransactionType.WithdrawName;
            else
                lblName.Text = clsTransactionType.DepositName;
        }

        void _initialeColtrols()
        {
            cmClients.Items.Clear();
            
            if (_senderClient == null)
            {
                DataTable dt = clsClient.GetAllClients();
                foreach (DataRow dr in dt.Rows)
                {
                    cmClients.Items.Add(dr["ClientName"].ToString());
                }
                butnCancel.Visible = false;
            }
            else
            {
                cmClients.Items.Clear();
                cmClients.Items.Add(_senderClient.ClientName);
                cmClients.SelectedIndex = 0;
                _reloadClientInfo();
            }
            _GiveFormName();
        }

        void _reloadClientInfo()
        {
            if (_senderClient.PicturePath != string.Empty)
                PbProfile.Image = Image.FromFile(_senderClient.PicturePath);
            else
                PbProfile.Image = Image.FromFile("C:\\Users\\USER\\source\\repos\\Mini Bank Syatem\\EmtyPicture.png");
            lblaccountnumber.Text = _senderClient.AccountNumber;
            lblbalance.Text = _senderClient.Balance.ToString();
            lblName.Text = _senderClient.ClientName;
            lblphone.Text = _senderClient.Phone.ToString();
        }
        private void frmWithdra_Load(object sender, EventArgs e)
        {
            _initialeColtrols();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c))
            {
                e.Handled = true;
            }
        }

        private void cmClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = 0;
            DataTable dt = clsClient.GetAllClients();
            string name = "";
            foreach(DataRow row in dt.Rows)
            {
                name = (string)row["ClientName"];
                if (name.Trim()== cmClients.SelectedItem.ToString())
                {
                    ID = (int)row["ClientID"];
                }
            }
            _senderClient = clsClient.Find(ID);
            _reloadClientInfo();
        }

        private void butnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAmount.Text))
            {
                _father.btnAllClientsWithTotalBalance_Click(_father.btnAllClientsWithTotalBalance,e);
                this.Close();
            }
            else
            {
                frmMyMessageBox box = new frmMyMessageBox("Do you want to exit", "NO", "YES");
                if(box.ShowDialog() == DialogResult.Yes)
                {
                    _father.btnAllClientsWithTotalBalance_Click(_father.btnAllClientsWithTotalBalance, e);
                    this.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbAmount.Text))
            {
               
                frmMyMessageBox box = new frmMyMessageBox("Amount inacceptable !!", "Ok");
                box.ShowDialog();
            }
            else
            {
                double CurrentBalance = (double)_senderClient.Balance;
                double amount = Convert.ToDouble(tbAmount.Text);
                if (_type == clsTransactionType.Withdraw)
                {
                    if (CurrentBalance >= amount)
                    {
                        amount = -1 * amount;
                        _senderClient.AddAmount((decimal)amount);
                        amount = -1 * amount;
                        clsTransaction newTran = new clsTransaction();
                        newTran.amount = amount;
                        newTran.TransactionTypeID = clsTransactionType.Withdraw;
                        newTran.clientID = _senderClient.ClientID;
                        newTran.userID = _user.userID;
                        if (newTran.Save())
                        {
                            frmMyMessageBox box = new frmMyMessageBox("Transactions Succesed!!", "Ok");
                            box.ShowDialog();
                            _father.btnAllClientsWithTotalBalance_Click(_father.btnAllClientsWithTotalBalance, e);
                            this.Close();
                        }
                        else
                        {
                            frmMyMessageBox box = new frmMyMessageBox("Transactions Failled!!", "Ok");
                            box.ShowDialog();
                        }
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    _senderClient.AddAmount((decimal)amount);
                    clsTransaction newTran = new clsTransaction();
                    newTran.amount = amount;
                    newTran.TransactionTypeID = clsTransactionType.Withdraw;
                    newTran.clientID = _senderClient.ClientID;
                    newTran.userID = _user.userID;
                    if (newTran.Save())
                    {
                        frmMyMessageBox box = new frmMyMessageBox("Transactions Succesed!!", "Ok");
                        box.ShowDialog();
                        _father.btnAllClientsWithTotalBalance_Click(_father.btnAllClientsWithTotalBalance, e);
                        this.Close();
                    }
                    else
                    {
                        frmMyMessageBox box = new frmMyMessageBox("Transactions Failled!!", "Ok");
                        box.ShowDialog();
                    }

                }
                

            }
        }

        private void frmWithdrawDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.btnSave_Click(btnSave, e);
            }
        }
    }
}
