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
    public partial class frmManageClients : Form
    {
        //Design Methods {
        Size smallsize = new Size(67, 66);
        Size biglsize = new Size(295, 66);
        bool issmall = true;
        bool isoptionsclicked = false;
        Size _childSize = new Size(880, 628);
        void _LightJumperPAnel(object sender)
        {
            Button btn = (Button)sender;
            pnlJumper.BackColor = Color.White;
            btn.Left = pnlJumper.Right ;
            pnlJumper.Top = btn.Top;    // Align the top of pnlJumper with the button
           
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
        private void btnAllClients_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = _headercolor;
            _GiveButtonsSmallSize();
        }
        private void btnAllClients_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(125, 123, 103);

        }

        void _GiveButtonsSmallSize()
        {
            pnlheader.Size = smallsize;
            btmOptions.Size = smallsize;
            btmOptions.Text = string.Empty;
            btnAddnewClient.Size = smallsize;
            btnAddnewClient.Text = string.Empty;
            btnAllClients.Size = smallsize;
            btnAllClients.Text = string.Empty;
            btnFindClient.Size = smallsize;
            btnFindClient.Text = string.Empty;
            issmall = true;
            isoptionsclicked = false;
        }
        void _GiveButtonsBigSize()
        {
            pnlheader.Size = biglsize;
            btmOptions.Size = biglsize;
            btmOptions.Text = btmOptions.Tag.ToString();
            btnAddnewClient.Size = biglsize;
            btnAddnewClient.Text = btnAddnewClient.Tag.ToString();
            btnAllClients.Size = biglsize;
            btnAllClients.Text = btnAllClients.Tag.ToString();
            btnFindClient.Size = biglsize;
            btnFindClient.Text = btnFindClient.Tag.ToString();
            issmall = false;
        }
        //                }
        Color _headercolor = Color.White;
        public frmManageClients(Color headercolor)
        {
            _headercolor = headercolor;
            InitializeComponent();
        }
       
        private void frmManageClients_Load(object sender, EventArgs e)
        {
            _GiveButtonsSmallSize();
            pnlheader.BackColor = _headercolor;
            _LightJumperPAnel(btnAllClients);
            frmAllClients frm = new frmAllClients(_headercolor,_childSize,this);
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Left;
            frm.Show();
        }

     

        private void btnAddnewClient_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            pnlbody.Controls.Clear();
            frmAddNewClient frm= new frmAddNewClient(_headercolor, _childSize,this);
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        public void btnAllClients_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            pnlbody.Controls.Clear();
            frmAllClients frm = new frmAllClients(_headercolor, _childSize, this);
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

    

        private void btmOptions_Click_1(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            isoptionsclicked = true;
            if (issmall)
                _GiveButtonsBigSize();
            else
                _GiveButtonsSmallSize();

        }

        private void btnFindClient_Click_1(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            pnlbody.Controls.Clear();
            femFindScreen frm = new femFindScreen(_headercolor);
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        private void pnlheader_Click(object sender, EventArgs e)
        {
            _GiveButtonsSmallSize();
        }

        private void pnlbody_Click(object sender, EventArgs e)
        {
            _GiveButtonsSmallSize();
        }

        private void pnlbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlheader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
