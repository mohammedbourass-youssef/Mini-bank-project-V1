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
    public partial class frmUserInfocs : Form
    {
        Color _BackColor;
        clsUser _user;
       
        Size _childSize;
        frmManageUsers _users;
        public frmUserInfocs(Color color,clsUser user)
        {
            _BackColor = color;
            _user = user;
            InitializeComponent();
        }
        public frmUserInfocs(Color color, clsUser user,Size childSize, frmManageUsers users)
        {
            _users = users;
           
            _BackColor = color;
            _user = user;
            InitializeComponent();
            _childSize = childSize;
        }
       
        enum EnPermissions { AllPermissions = -1, ManageClient = 1, ManageUser = 2, Transactions = 4 }
        bool _CheckUserPermissions(EnPermissions enPermissions)
        {
            if (Convert.ToInt32(EnPermissions.AllPermissions) == _user.permissions)
                return true;
            else if ((Convert.ToInt32(enPermissions) & _user.permissions) == Convert.ToInt32(enPermissions))
                return true;
            else
                return false;
        }

     

        void _Permistions()
        {
            if (_CheckUserPermissions(EnPermissions.AllPermissions))
            {
                chFullAccess.Visible = true;

            }
            else
            {
                if (_CheckUserPermissions(EnPermissions.ManageClient))
                {

                    chManagerClientAccess.Visible = true;
                }
                if (_CheckUserPermissions(EnPermissions.ManageUser))
                {

                    chManageUsers.Visible = true;
                }
                if (_CheckUserPermissions(EnPermissions.Transactions))
                {

                    chTransactions.Visible = true;
                }
            }
           
        }

        void _LoadInformation()
        {
            lblPassword.Text = _user.password;
            lblUserId.Text = _user.userID.ToString();
            lblUserName.Text = _user.username;
            _Permistions();
        }
        private void frmUserInfocs_Load(object sender, EventArgs e)
        {
            if(_user ==  null)
            {
                this.Close();
                MessageBox.Show("an expected error !!!");
            }
            this.BackColor = _BackColor;
            pnltitle.BackColor = _BackColor;
            groupBox1.BackColor = _BackColor;
            groupBox2.BackColor = _BackColor;
            this.Dock = DockStyle.Right;
           
            _users.BackColor = _BackColor;
            _LoadInformation();
        }

        private void butnCancel_Click(object sender, EventArgs e)
        {

             
                _users.btnAllClients_Click(_users.btnUsers, e);
                this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chTransactions_Click(object sender, EventArgs e)
        {

        }

        private void chTransactions_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
