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
    public partial class frmMyMessageBox : Form
    {
        string _Message,_B1Message,_B2Message;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (button1.Text) {
                case "NO": this.DialogResult = DialogResult.No; break;
                case "Cancel": this.DialogResult= DialogResult.Cancel; break;
                default:DialogResult = DialogResult.OK; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (button2.Text)
            {
                case "YES": this.DialogResult = DialogResult.Yes; break;
                
                default: DialogResult = DialogResult.OK; break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public frmMyMessageBox(string Message , string Buttun1,string Buttun2="")
        {
            _Message = Message;
            _B1Message = Buttun1.ToUpper();
            _B2Message = Buttun2.ToUpper();
            InitializeComponent();
        }

        private void frmMyMessageBox_Load(object sender, EventArgs e)
        {
         
            lblMessage.Text = _Message;
            if (_B1Message == "OK")
            {
                button1.Location = (_Message.Length > 10) ? new System.Drawing.Point(174, 131) : new System.Drawing.Point(15, 53);
                button1.Text = "OK";
                button2.Visible = false;
            }
            else
            {
                button2.Text = _B2Message;
                button1.Text = _B1Message;
            }
        }
    }
}
