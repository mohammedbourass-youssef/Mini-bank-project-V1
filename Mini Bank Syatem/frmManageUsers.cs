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
    public partial class frmManageUsers : Form
    {
        Color _headercolor= Color.White;
        Size smallsize = new Size(67, 66);
        Size biglsize = new Size(295, 66);
        bool issmall = true;
        bool isoptionsclicked = false;
        Size _childSize = new Size(880, 628);
        clsUser _CurentUser;
        void _LightJumperPAnel(object sender)
        {
            Button btn = (Button)sender;
            pnlJumper.BackColor = Color.White;
            btn.Left = pnlJumper.Right;
            pnlJumper.Top = btn.Top;    // Align the top of pnlJumper with the button

        }
        void _GiveButtonsSmallSize()
        {
            pnlButtonslesf.Size = smallsize;
            btmOptions.Size = smallsize;
            btmOptions.Text = string.Empty;
            btnAddnewUser.Size = smallsize;
            btnAddnewUser.Text = string.Empty;
            btnUsers.Size = smallsize;
            btnUsers.Text = string.Empty;
            
            issmall = true;
            isoptionsclicked = false;
        }
        void _GiveButtonsBigSize()
        {
            pnlButtonslesf.Size = biglsize;
            btmOptions.Size = biglsize;
            btmOptions.Text = btmOptions.Tag.ToString();
            btnAddnewUser.Size = biglsize;
            btnAddnewUser.Text = btnAddnewUser.Tag.ToString();
            btnUsers.Size = biglsize;
            btnUsers.Text = btnUsers.Tag.ToString();
            
            issmall = false;
        }
        public frmManageUsers(Color color,clsUser user)
        {
            _CurentUser = user;
            _headercolor = color;
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            this.BackColor = _headercolor;
            pnlBody.BackColor = _headercolor ;
            pnlButtonslesf.BackColor = _headercolor ;
            
            _GiveButtonsSmallSize();     
            _LightJumperPAnel(btnUsers);
            frmAllUsers frm = new frmAllUsers(_headercolor, _childSize,this);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

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

        private void btmOptions_MouseEnter(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(125, 123, 103);

        }

        private void btmOptions_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = _headercolor;

        }

        private void btnAddnewClient_MouseEnter(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(125, 123, 103);
        }

        private void btnAddnewClient_MouseLeave(object sender, EventArgs e)
        {
           
               
            Button btn = (Button)sender;
            btn.BackColor = _headercolor;
            _GiveButtonsSmallSize();


        }

        public void btnAllClients_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            frmAllUsers frm = new frmAllUsers(_headercolor, _childSize,this);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();

        }

        private void pnlButtonslesf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddnewClient_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            pnlBody.Controls.Clear();
            frmAddnewUser frm = new frmAddnewUser(this,_CurentUser);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        private void pnlBody_Click(object sender, EventArgs e)
        {
            _GiveButtonsSmallSize();
        }

        private void pnlButtonslesf_Click(object sender, EventArgs e)
        {
            _GiveButtonsSmallSize();
        }
    }
}
