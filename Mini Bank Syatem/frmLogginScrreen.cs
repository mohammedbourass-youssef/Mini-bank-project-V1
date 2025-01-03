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
    public partial class frmLogginScrreen : Form
    {
        public frmLogginScrreen()
        {
            InitializeComponent();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            frmMyMessageBox message = new frmMyMessageBox("Do you want logout", "NO", "YES");
            if (message.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbUserNAme_MouseEnter(object sender, EventArgs e)
        {
            TextBox button =(TextBox)sender;
            pnlJumper.Top = button.Bottom;
            pnlJumper.Left = button.Left;
            pnlJumper.Width = button.Width;
            if(button.Text == button.Tag.ToString())
                button.Text = string.Empty;

        }

        private void btmLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.Find(tbUserNAme.Text.Trim());
            if(tbPassword.Text !="PASSWORD"||tbUserNAme.Text != "USER NAME")
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                if (user == null)
                {
                    frmMyMessageBox frmMyMessage = new frmMyMessageBox("PASSWORD\\USERNAME\r\n incorrect", "ok");
                    frmMyMessage.ShowDialog();
                    tbUserNAme.Text = "USER NAME";
                    tbPassword.Text = "PASSWORD";
                }
                else
                {
                    if(user.password.Trim() == tbPassword.Text)
                    {
                        frmBankSystem bankSystem = new frmBankSystem(user);
                        this.Hide();
                        if (bankSystem.ShowDialog()==DialogResult.Yes)
                        {
                            tbUserNAme.Text = "USERNAME";
                            tbPassword.Text = "PASSWORD";
                            this.Show();
                        }
                        
                    }
                    else
                    {
                        frmMyMessageBox frmMyMessage = new frmMyMessageBox("PASSWORD\\USERNAME : incorrect", "ok");
                        frmMyMessage.ShowDialog();
                        tbUserNAme.Text = "USERNAME";
                        tbPassword.Text = "PASSWORD";
                    }
                }
            }
            else
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible=true;

            }
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text.Text == string.Empty)
            {
                text.Text = text.Tag.ToString();
                //I saved the name of each textbox in his Tag
            }
        }

        private void chbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbshowpass.Checked)
            {
                if (tbPassword.Text != "PASSWORD")
                    tbPassword.PasswordChar = '*';

            }
                
            else
                tbPassword.PasswordChar = '\0';
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!chbshowpass.Checked)
            {
                if (tbPassword.Text == string.Empty || tbPassword.Text == "PASSWORD")
                {
                    tbPassword.PasswordChar = '\0';
                }
                else
                {
                    tbPassword.PasswordChar = '*';
                }
            }
        }

        private void frmLogginScrreen_Load(object sender, EventArgs e)
        {
            tbUserNAme.Focus();
        }

        private void tbUserNAme_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(e.KeyCode == Keys.Enter)
                {
                if(textBox.Text != textBox.Tag.ToString() || !string.IsNullOrEmpty(textBox.Text))
                {
                    btmLogin_Click(btmLogin, e);
                }
            }
        }
    }
}
