using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Bank_Syatem
{
    public partial class frmUpdate : Form
    {
        Color _color;
        Size _size;
        string _PicturePath;
        string _DefaultPicturePath = "C:\\Users\\USER\\source\\repos\\Mini Bank Syatem\\EmtyPicture.png";
        clsClient _client;
        public frmUpdate(clsClient client, Color color, Size size)
        {
            _client = client;
            _color = color;
            _size = size;
            InitializeComponent();
        }
        void _initialetheControls()
        {
            tbBalance.Text = _client.Balance.ToString();
             if(_client.PicturePath != string.Empty)
            {
                PbProfile.Image = Image.FromFile(_client.PicturePath);
                _PicturePath = _client.PicturePath;
            }
            else
            {
                btmDeletePicture.Visible = false;
                btnAddPicture.Location = new Point(130, 303);
                PbProfile.Image = Image.FromFile(_DefaultPicturePath);
            }
             tbAcountNumber.Text = _client.AccountNumber.ToString().Trim();
             tbPhone.Text = _client.Phone.Trim();
             tbName.Text = _client.ClientName.Trim();
             tbPinCode.Text = _client.PinCode.Trim();
             
        }
        void _GiveTextboxBackColor(TextBox textBox)
        {
            textBox.BackColor = _color;
        }

        bool _IsTextAcceptbale(TextBox text)
        {
            return (text.Text == text.Tag.ToString() || text.Text == string.Empty) ? false : true;
        }
        bool _IsControlisNumirec(TextBox text)
        {
            string str = text.Text;
            bool isDigit = true;
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    isDigit = false;
                    break;
                }
            }
            return isDigit;
        }

        bool _IsControlsReadyToSave()
        {
            double result;
            
            bool go = _IsControlisNumirec(tbBalance) || double.TryParse(tbBalance.Text, out result);
            if ( go&& _IsControlisNumirec(tbPinCode) && _IsControlisNumirec(tbPhone) && _IsTextAcceptbale(tbName) && _IsTextAcceptbale(tbPinCode) && _IsTextAcceptbale(tbPhone) && _IsTextAcceptbale(tbBalance) && _IsTextAcceptbale(tbAcountNumber))
            { return true; }
            return false;
        }
       
        void _AddPicture()
        {
            openFileDialog1.ShowDialog();

            string Path = openFileDialog1.FileName;
            if (Path != string.Empty)
            {
                PbProfile.Image = Image.FromFile(Path);
                _PicturePath = Path;
                btmDeletePicture.Visible = true;
                btnAddPicture.Location = new Point(21, 303);
            }
        }

        void _DeletePicture()
        {
            PbProfile.Image = Image.FromFile("C:\\Users\\USER\\source\\repos\\Mini Bank Syatem\\EmtyPicture.png");
            btnAddPicture.Location = new Point(130, 303);
            btmDeletePicture.Visible = false;
            _PicturePath = "";
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            lblAccountID.Text = _client.ClientID.ToString();
            tbAcountNumber.Focus();
            this.BackColor = _color;
            this.Size = _size;
            
            _initialetheControls();
            _GiveTextboxBackColor(tbName);
            _GiveTextboxBackColor(tbPinCode);
            _GiveTextboxBackColor(tbPhone);
            _GiveTextboxBackColor(tbBalance);
            _GiveTextboxBackColor(tbAcountNumber);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool x = _IsControlsReadyToSave();
            if (!x || tbPhone.Text.Length > 10 || tbPinCode.Text.Length >4)
            {
                frmMyMessageBox frm = new frmMyMessageBox("Some Informations Invalid", "Ok");
                frm.ShowDialog();
            }
            else
            {
                
               _client.Balance = Convert.ToDecimal(tbBalance.Text);
               _client.PicturePath = _PicturePath;
               _client.AccountNumber = tbAcountNumber.Text;
               _client.Phone = tbPhone.Text;
               _client.ClientName = tbName.Text;
               _client.PinCode = tbPinCode.Text;
                if (_client.Save())
                {
                    frmMyMessageBox frm = new frmMyMessageBox("Client Added Succefully", "Ok");
                    frm.ShowDialog();
                    btnSave.Enabled = false;
                }
                else
                {
                    frmMyMessageBox frm = new frmMyMessageBox("Error", "Ok");
                    frm.ShowDialog();
                }

            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            _AddPicture();
        }

        private void btmDeletePicture_Click(object sender, EventArgs e)
        {
            _DeletePicture();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPinCode_TextChanged(object sender, EventArgs e)
        {
            if (_IsTextAcceptbale(tbPinCode))
            {
                tbPinCode.PasswordChar = '*';
            }
            else
                tbPinCode.PasswordChar = '\0';
        }

        private void tbAcountNumber_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void tbAcountNumber_Leave(object sender, EventArgs e)
        {
            
        }

        private void tbAcountNumber_MouseEnter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == string.Empty)
            {
                textbox.Text = textbox.Tag.ToString();
            }
        }

        private void tbAcountNumber_MouseLeave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == string.Empty)
            {
                textbox.Text = textbox.Tag.ToString();
            }
        }

        private void showPinCode_CheckedChanged(object sender, EventArgs e)
        {
            if (showPinCode.Checked)
            {
                tbPinCode.PasswordChar = '\0';
            }
            else
                tbPinCode.PasswordChar = '*';
        }
    }
}
