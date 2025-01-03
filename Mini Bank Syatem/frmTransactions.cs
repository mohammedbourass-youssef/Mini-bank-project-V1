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
    public partial class frmTransactions : Form
    {
        Color _headercolor= Color.White;
        Size smallsize = new Size(67, 66);
        Size biglsize = new Size(295, 66);
        bool issmall = true;
        bool isoptionsclicked = false;
        Size _childSize = new Size(880, 628);
        clsUser _user;
        public frmTransactions(Color color,clsUser user)
        {
            _user = user;
            _headercolor = color;
            InitializeComponent();
        }
        void _LightJumperPAnel(object sender)
        {
            Button btn = (Button)sender;
            pnlJumper.BackColor = Color.White;
            btn.Left = pnlJumper.Right;
            pnlJumper.Top = btn.Top;    // Align the top of pnlJumper with the button

        }
        void _GiveButtonsSmallSize()
        {
            pnlMenu.Size = smallsize;
            btmOptions.Size = smallsize;
            btmOptions.Text = string.Empty;
            btnAllClientsWithTotalBalance.Size = smallsize;
            btnAllClientsWithTotalBalance.Text = string.Empty;
            btnDeposit.Size = smallsize;
            btnDeposit.Text = string.Empty;
            btnTransactions.Size = smallsize;
            btnTransactions.Text = string.Empty;
            btnWithdraw.Size = smallsize;
            btnWithdraw.Text = string.Empty;
            issmall = true;
            isoptionsclicked = false;
        }
        void _GiveButtonsBigSize()
        {
            pnlMenu.Size = biglsize;
            btmOptions.Size = biglsize;
            btmOptions.Text = btmOptions.Tag.ToString();
            btnAllClientsWithTotalBalance.Size = biglsize;
            btnAllClientsWithTotalBalance.Text = btnAllClientsWithTotalBalance.Tag.ToString();
            btnDeposit.Size = biglsize;
            btnDeposit.Text = btnDeposit.Tag.ToString();
            btnWithdraw.Size = biglsize;
            btnWithdraw.Text = btnWithdraw.Tag.ToString();
            btnTransactions.Size = biglsize;
            btnTransactions.Text = btnTransactions.Tag.ToString();
            issmall = false;
        }
        private void frmTransactions_Load(object sender, EventArgs e)
        {
            _GiveButtonsSmallSize();
            this.btnAllClientsWithTotalBalance_Click(btnAllClientsWithTotalBalance, e);
        }

        private void btnAllClientsWithTotalBalance_MouseEnter(object sender, EventArgs e)
        {
         
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(125, 123, 103);
        }

        private void btnAllClientsWithTotalBalance_MouseLeave(object sender, EventArgs e)
        {

               Button btn = (Button)sender;
               btn.BackColor = _headercolor;
               
            
        }

        private void btmOptions_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            isoptionsclicked = true;
            if (issmall)
                _GiveButtonsBigSize();
            else
                _GiveButtonsSmallSize();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        public void btnAllClientsWithTotalBalance_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            _GiveButtonsSmallSize();
            pnlBody.Controls.Clear();
            frmTotalBalance frm = new frmTotalBalance(this,_user,_headercolor);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            _GiveButtonsSmallSize();
            pnlBody.Controls.Clear();
            frmWithdrawDeposit frm = new frmWithdrawDeposit(_headercolor,this,clsTransactionType.Withdraw,_user);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            _GiveButtonsSmallSize();
            pnlBody.Controls.Clear();
            frmWithdrawDeposit frm = new frmWithdrawDeposit(_headercolor, this, clsTransactionType.Deposit, _user);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            _GiveButtonsSmallSize();
            pnlBody.Controls.Clear();
            frmAllTransactions frm = new frmAllTransactions(_headercolor, this,_user);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();

        }
    }
}
