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
    public partial class frmBankSystem : Form
    {
        clsUser _CurrentUser= null;  
       
        public frmBankSystem(clsUser clsUser)
        {
            _CurrentUser = clsUser;
            InitializeComponent();
        }
        enum EnPermissions { AllPermissions = -1, ManageClient = 1, ManageUser = 2, Transactions = 4 }
        bool _CheckUserPermissions(EnPermissions enPermissions)
        {
            if(Convert.ToInt32(EnPermissions.AllPermissions) == _CurrentUser.permissions)
                return true;
            else if((Convert.ToInt32(enPermissions) & _CurrentUser.permissions)== Convert.ToInt32(enPermissions))
                return true;
            else
                return false;
        }
        void _EnableAllButtons()
        {
            btnCurrencies.Enabled = true;
            btnManageClients.Enabled = true;
            btnManageUsers.Enabled = true;
            btnTransactions.Enabled = true;
        }
        private void btnManageClients_Click(object sender, EventArgs e)
        {
            _EnableAllButtons();
            _ButtonsChangeColor(sender);
            if (_CheckUserPermissions(EnPermissions.ManageClient)){
                pnlChildProgram.Controls.Clear();
                frmManageClients frmanageclients = new frmManageClients(btnManageClients.BackColor);
                frmanageclients.TopLevel = false;
                pnlChildProgram.Controls.Add(frmanageclients);
                frmanageclients.Dock = DockStyle.Fill;
                frmanageclients.Show();
                btnManageClients.Enabled = false;
            }
            else
            {
                pnlChildProgram.Controls.Clear();
                pnlChildProgram.Controls.Add(lblAccessDenied);
                lblAccessDenied.Visible = true;
               
            }
            
        }
        
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            _EnableAllButtons();
            _ButtonsChangeColor(sender);
            if (_CheckUserPermissions(EnPermissions.ManageUser))
            {
                
                pnlChildProgram.Controls.Clear();
                frmManageUsers frm = new frmManageUsers(btnManageUsers.BackColor,_CurrentUser);
                frm.TopLevel = false;
                pnlChildProgram.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                btnManageUsers.Enabled = false;
            }
            else
            {
                pnlChildProgram.Controls.Clear();
                pnlChildProgram.Controls.Add(lblAccessDenied);
                lblAccessDenied.Visible = true;

            }
        }
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            _EnableAllButtons();
            _ButtonsChangeColor(sender);
            if (_CheckUserPermissions(EnPermissions.Transactions))
            {
                pnlChildProgram.Controls.Clear();
                frmTransactions frmanageclients = new frmTransactions(btnTransactions.BackColor,_CurrentUser);
                frmanageclients.TopLevel = false;
                pnlChildProgram.Controls.Add(frmanageclients);
                frmanageclients.Dock = DockStyle.Fill;
                frmanageclients.Show();
                btnTransactions.Enabled = false;
            }
            else
            {
                pnlChildProgram.Controls.Clear();
                pnlChildProgram.Controls.Add(lblAccessDenied);
                lblAccessDenied.Visible = true;

            }

        }
        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            _EnableAllButtons();
            _ButtonsChangeColor(sender);
            
                pnlChildProgram.Controls.Clear();
                frmCurrencies frmanageclients = new frmCurrencies(btnCurrencies.BackColor,_CurrentUser);
                frmanageclients.TopLevel = false;
                pnlChildProgram.Controls.Add(frmanageclients);
                frmanageclients.Dock = DockStyle.Fill;
                frmanageclients.Show();
                btnCurrencies.Enabled = false;
       
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMyMessageBox message = new frmMyMessageBox("Do you want logout","NO","YES");
            if(message.ShowDialog() == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

       

        ///ALL FUNCTION AFTER THIS COMMENT IS JUST FOR DESIGN UI ,THE LOD´GIQUE FUCTION ABOVE
        void _ButtonsChangeColor(object sender)
        {
            //ResetAllButtonsColor
            btnCurrencies.BackColor = Color.FromArgb(125, 123, 103);
            btnManageClients.BackColor = Color.FromArgb(125, 123, 103);
            btnManageUsers.BackColor = Color.FromArgb(125, 123, 103);
            btnTransactions.BackColor = Color.FromArgb(125, 123, 103);
            Button button = (Button)sender;
            //Make pnlJumper Work
            pnljumper.Top = button.Bottom;
            pnljumper.Left = button.Left;
            pnljumper.BackColor = Color.White;
            //give name of button  to title 
            lblButtonTitle.Text = button.Text;
            button.BackColor = _CurrentButtonColor;
            lblAccessDenied.Visible = false;
        }
        private void btnManageClients_BackColorChanged(object sender, EventArgs e)
        {
            

        }
        Color _CurrentButtonColor;//SAVE THE CURRENT COLOR TO USE IT IN BUTTONSCHANGECOLOR
        int _currentcolor = -1; //a variable to save th current color of headers look at clscolorchangerrandomly to understand
        private void btnManageClients_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblButtonTitle.Text != btn.Text)
            {
               
                ChangeColorRandomly clscolorchangerrandomly = new ChangeColorRandomly(_currentcolor);
                clscolorchangerrandomly.ChangeButtunAndHeadersColorRandomly(btn);
                _CurrentButtonColor = btn.BackColor;
            }
            else
                pnlLogo.BackColor = btn.BackColor;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            //Reset the color after mouse leave ,if button not clicked
            Button button = (Button)sender;
            if (lblButtonTitle.Text != button.Text)
                button.BackColor = Color.FromArgb(125, 123, 103);
        }

        private void frmBankSystem_Load(object sender, EventArgs e)
        {
            lblusername.Text += _CurrentUser.username.ToUpper();
            btnCurrencies_Click(btnCurrencies, e);
        }

        private void pnlLogo_BackColorChanged(object sender, EventArgs e)
        {
            pnlTitle.BackColor = pnlLogo.BackColor;
        }

        private void pnlChildProgram_Paint(object sender, PaintEventArgs e)
        {

        }
        //THE END OF UI FUNCTIONS





    }
}
