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
    public partial class frmAddnewUser : Form
    {
        
        frmManageUsers _father;
        int Permissions = 0;
        clsUser _currentuser;
        public frmAddnewUser(frmManageUsers users, clsUser currentuser)
        {
            _father = users;
            InitializeComponent();
            _currentuser = currentuser;
        }
        bool _Isinfoready(TextBox text)
        {
            if (!string.IsNullOrEmpty(text.Text) && text.Text != text.Tag.ToString())
                return true;
            return false;
        }
        enum EnPermissions { AllPermissions = -1, ManageClient = 1, ManageUser = 2, Transactions = 4 }
        bool _CheckUserPermissions(EnPermissions enPermissions)
        {
            if (_currentuser.permissions == 0)
                return false;
            if (Convert.ToInt32(EnPermissions.AllPermissions) == _currentuser.permissions)
                return true;
            else if ((Convert.ToInt32(enPermissions) & _currentuser.permissions) == Convert.ToInt32(enPermissions))
                return true;
            else
                return false;
        }

        private void tbUserNAme_Enter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            pnlJumper.Top = text.Bottom;
            pnlJumper.Left = text.Left;
           
            if (text.Text == text.Tag.ToString())
                text.Text = string.Empty;
        }

        private void frmAddnewUser_Load(object sender, EventArgs e)
        {
            chFullAccess.Visible = false;
            chManagerClientAccess.Visible = false;
            chManageUsers.Visible = false;
            chTransactions.Visible = false;
            if (_CheckUserPermissions(EnPermissions.AllPermissions))
           {
                chFullAccess.Visible = true;
                chManagerClientAccess.Visible = true;
                chManageUsers.Visible = true;
                chTransactions.Visible = true;
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

        private void chManageUsers_CheckedChanged(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Isinfoready(tbPasword)&& _Isinfoready(tbUserNAme))
            {
                clsUser _user = clsUser.Find(tbUserNAme.Text);
                if (_user == null)
                {
                    _user = new clsUser();
                    _user.password = tbPasword.Text;
                    _user.username = tbUserNAme.Text;
                    _user.permissions = Permissions;
                    if (_user.Save())
                    {
                        frmMyMessageBox frm = new frmMyMessageBox("User Added Succefully", "ok");
                        frm.ShowDialog();
                        _father.btnAllClients_Click(_father.btnUsers, e);
                        this.Close();
                    }
                }
                else
                {
                    frmMyMessageBox frm = new frmMyMessageBox("this username taken !\r\n  try another one", "ok");
                    frm.ShowDialog();
                }
            }
            else
            {
                frmMyMessageBox frm = new frmMyMessageBox("Please Fill\r\n Some Neccessary inforamtions", "ok");
                frm.ShowDialog();
            }
        }

        private void butnCancel_Click(object sender, EventArgs e)
        {
            if (_Isinfoready(tbPasword)&& _Isinfoready(tbUserNAme))
            {
                frmMyMessageBox frm = new frmMyMessageBox("Do you want to exit ", "NO","YES");
                if(frm.ShowDialog() == DialogResult.Yes)
                {
                    _father.btnAllClients_Click(_father.btnUsers, e);
                    this.Close();
                }
            }
            else
            {
                _father.btnAllClients_Click(_father.btnUsers, e);
                this.Close();
            }
            
        }

        private void tbUserNAme_Leave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if(string.IsNullOrEmpty(text.Text) ) 
                text.Text = text.Tag.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
