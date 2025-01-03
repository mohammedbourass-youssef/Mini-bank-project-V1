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
    public partial class frmAddNewClient : Form
    {
        Color _color;
        Size _size;
        string _PicturePath = "";
        string _DefaultPicturePath = "C:\\Users\\USER\\source\\repos\\Mini Bank Syatem\\EmtyPicture.png";
        frmManageClients _father;
        public frmAddNewClient(Color color, Size size, frmManageClients Father)
        {
            _father = Father;
            _size = size;
            _color = color;
            InitializeComponent();
        }
        bool _IsTextAcceptbale(TextBox text)
        {
            return (text.Text == text.Tag.ToString()|| text.Text == string.Empty)?false : true;
        }
        string _GenrateAccountNumber()
        {
            char[] allChar = new char[26]; // Array to hold all lowercase letters
            for (int i = 0; i < 26; i++)
            {
                allChar[i] = (char)('a' + i); // Fill the array with letters from 'a' to 'z'
            }
            List<char> list = new List<char>();
            Random random = new Random();
            int index = 0;
            string AcountNumber = string.Empty;
            while (AcountNumber.Length < 10)
            {
                index = random.Next(allChar.Length);
                AcountNumber += allChar[index];
            }
            return AcountNumber;
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
            if(_IsControlisNumirec(tbBalance)&&_IsControlisNumirec(tbPinCode) && _IsControlisNumirec(tbPhone) && _IsTextAcceptbale(tbName)&& _IsTextAcceptbale(tbPinCode) && _IsTextAcceptbale(tbPhone) && _IsTextAcceptbale(tbBalance) && _IsTextAcceptbale(tbAcountNumber))
                { return true; }
            return false;
        }
        void _GiveTextboxBackColor(TextBox textBox)
        {
            textBox.BackColor = _color;
        }
        void _AddPicture()
        {
            openFileDialog1.ShowDialog();

            string Path  = openFileDialog1.FileName;    
            if(Path != string.Empty)
            {
                PbProfile.Image = Image.FromFile(Path);
                _PicturePath = Path;
                btmDeletePicture.Visible = true;
                btnAddPicture.Location = new Point(21, 326);
            }
        }

        void _DeletePicture()
        {
            PbProfile.Image = Image.FromFile(_DefaultPicturePath);
            btnAddPicture.Location = new Point(127, 324);
            btmDeletePicture.Visible = false;
            _PicturePath = "";
        }

        private void frmAddNewClient_Load(object sender, EventArgs e)
        {
            this.BackColor = _color;
            this.Size = _size;
            _father.BackColor = _color;
           btmDeletePicture.Visible = false;
            btnAddPicture.Location = new Point(127, 324);
            tbAcountNumber.Text = _GenrateAccountNumber();
            _GiveTextboxBackColor(tbName);
            _GiveTextboxBackColor(tbPinCode);
            _GiveTextboxBackColor(tbPhone);
            _GiveTextboxBackColor(tbBalance);
            _GiveTextboxBackColor(tbAcountNumber);
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            _AddPicture();
        }

        private void btmDeletePicture_Click(object sender, EventArgs e)
        {
            _DeletePicture();
        }

        private void tbAcountNumber_Enter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == textbox.Tag.ToString())
            {
                textbox.Text = string.Empty;
                
            }
        }

        private void tbAcountNumber_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == string.Empty)
            {
                textbox.Text = textbox.Tag.ToString();
            }
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

        private void showPinCode_CheckedChanged(object sender, EventArgs e)
        {
            if(showPinCode.Checked)
            {
                tbPinCode.PasswordChar = '\0';
            }
            else
                tbPinCode.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!_IsControlsReadyToSave() || tbPhone.Text.Length > 10 || tbPinCode.Text.Length > 4)
            {
                frmMyMessageBox frm = new frmMyMessageBox("Some Informations Invalid", "Ok");
                frm.ShowDialog();
            }
            else
            {
                clsClient client = new clsClient();
                client.Balance = Convert.ToDecimal(tbBalance.Text);
                client.PicturePath = _PicturePath;
                client.AccountNumber = tbAcountNumber.Text;
                client.Phone = tbPhone.Text;
                client.ClientName = tbName.Text;
                client.PinCode = tbPinCode.Text;
                if (client.Save())
                {
                    frmMyMessageBox frm = new frmMyMessageBox("Client Added Succefully", "Ok");
                    frm.ShowDialog();
                    btnSave.Enabled = false;
                    _father.btnAllClients_Click(_father.btnAllClients, e);
                }
                else
                {
                    frmMyMessageBox frm = new frmMyMessageBox("Error", "Ok");
                    frm.ShowDialog();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            _father.btnAllClients_Click(_father.btnAllClients, e);
            this.Close();
        }

        private void pnltitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
