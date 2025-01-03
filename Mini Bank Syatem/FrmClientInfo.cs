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
    public partial class FrmClientInfo : Form
    {
        Color _BackColor;
        clsClient _client;
        frmManageClients _father;
        public FrmClientInfo(Color BackColor,clsClient client,frmManageClients father)
        {
            _father = father;
            _client = client;
            _BackColor = BackColor;
            InitializeComponent();
        }
        public FrmClientInfo(Color BackColor, clsClient client)
        {
            
            _client = client;
            _BackColor = BackColor;
            InitializeComponent();
        }

        void _UploadInfo()
        {
            if(_client != null)
            {
                lblaccountnumber.Text = _client.AccountNumber;
                lblbalance.Text = _client.Balance.ToString();
                lblClientID.Text = _client.ClientID.ToString();
                lblClientNumber.Text = _client.AccountNumber.ToString();
                lblfullname.Text = _client.ClientName.ToString();
                lblphone.Text = _client.Phone.ToString();
                lblPinCode.Text = _client.PinCode.ToString();
                if (_client.PicturePath != string.Empty)
                    PbProfile.Image = Image.FromFile(_client.PicturePath);
            }
        }



        private void FrmClientInfo_Load(object sender, EventArgs e)
        {
            this.BackColor = _BackColor;
            pnltitle.BackColor = _BackColor;
           if(_father!= null)
                _father.BackColor = _BackColor;
            _UploadInfo();
        }

        private void butnCancel_Click(object sender, EventArgs e)
        {
            if (_father != null)
                _father.btnAllClients_Click(_father.btnAllClients, e);
            this.Close();
        }
    }
}
