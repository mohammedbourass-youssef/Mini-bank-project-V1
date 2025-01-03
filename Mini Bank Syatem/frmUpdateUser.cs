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
    public partial class frmUpdateUser : Form
    {
        clsUser _user;
        frmManageUsers _father;
        int Permissions = 0;
        public frmUpdateUser(clsUser user,frmManageUsers father)
        {
            _user = user;
            _father = father;
            InitializeComponent();
        }
        enum EnPermissions { AllPermissions = -1, ManageClient = 1, ManageUser = 2, Transactions = 4 }
        bool _CheckUserPermissions(EnPermissions enPermissions)
        {
            if(_user.permissions==0)
                return false;   
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
                chFullAccess.Checked = true;

            }
            if (_CheckUserPermissions(EnPermissions.ManageClient))
            {
                chManagerClientAccess.Checked = true;
            }
            if (_CheckUserPermissions(EnPermissions.ManageUser))
            {
                chManageUsers.Checked = true;
            }
            if (_CheckUserPermissions(EnPermissions.Transactions))
            {
                chTransactions.Checked = true;
            }
        }

        void _InitialeControls()
        {
            tbPasword.Text = _user.password;
            tbUserNAme.Text = _user.username;
            lblUserId.Text = _user.userID.ToString();
            _Permistions();
        }

        void _GetNewInfo()
        {
            _user.password= tbPasword.Text ;
            _user.username = tbUserNAme.Text;
            _user.permissions = Permissions;
        }
        private void butnCancel_Click(object sender, EventArgs e)
        {
            _father.btnAllClients_Click(_father.btnUsers, e);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _GetNewInfo();
            _user.Save();
            _father.btnAllClients_Click(_father.btnUsers, e);
            this.Close() ;
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            _InitialeControls();
        }
        private void chFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                Permissions += Convert.ToInt32(box.Tag);
            }
            else
            {
                Permissions -= Convert.ToInt32(box.Tag);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pnltitle_Click(object sender, EventArgs e)
        {

        }

        private void tbUserNAme_Enter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            pnlJumper.Top = text.Bottom;
            pnlJumper.Left = text.Left;
        }
    }
}
