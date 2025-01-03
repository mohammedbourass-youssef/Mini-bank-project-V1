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
    public partial class frmAllUsers : Form
    {
        Color _CurrentColor = Color.White;
        Size _formSize;
        frmManageUsers _father1;
        
        //public frmAllUsers(Color color,Size size, Panel father)
        //{
        //    _formSize = size;
        //    _CurrentColor = color;
        //    InitializeComponent();
        //    _father = father;
        //}
        public frmAllUsers(Color color, Size size, frmManageUsers father)
        {
            _formSize = size;
            _CurrentColor = color;
            InitializeComponent();
            _father1 = father;
        }
        void _LoadAllUsers()
        {
            pnlBody.Controls.Clear();
            Size buttonSize = new Size(931, 104);
            pnlBody.AutoScroll = true;
            DataTable data = clsUser.GetAllUsers();
            int yPosition = 0;
            string PicturePath = string.Empty;
            foreach (DataRow row in data.Rows)
            {
                Button btn = new Button
                {
                    Text = $"                   UserID --    {row["UserID"]}          " +
                    $"User Name --  {row["UserName"]} ",
                    //Text = $"{row["AccountNumber"]}\n{row["ClientName"]}\n{row["Phone"]}",
                    Size = new Size(931, 100),
                    Dock = DockStyle.Top,
                    Location = new Point(10, yPosition), // Set the location of the button
                    Margin = new Padding(10), // Space around the button
                
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    Tag = (int)row["UserID"],
                    ImageAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    BackColor = _CurrentColor, // Button background color
                    ForeColor = Color.White, // Button text color
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new Font("Century Gothic", 20, FontStyle.Bold), // Font for the button text
                    FlatStyle = FlatStyle.Flat, // Remove button border
                    FlatAppearance = { BorderSize = 2 }, // Remove button border
                    ContextMenuStrip = contextMenuStrip1,
                };

                yPosition += 139;
                // Add the button to your form or panel
                pnlBody.Controls.Add(btn);
                btn.Click += delegate
                {
                    frmUserInfocs frm = new frmUserInfocs(_CurrentColor, clsUser.Find(Convert.ToInt32(btn.Tag.ToString())),new Size(931, 533),_father1);
                    pnlBody.Controls.Clear();
                    frm.TopLevel = false;
                    pnlBody.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.BringToFront();
                    frm.Show();
                    
                };
                btn.MouseUp += delegate
                {
                    contextMenuStrip1.Tag = btn.Tag;
                };
            }
        }

      



        private void frmAllUsers_Load(object sender, EventArgs e)
        {
            this.BackColor = _CurrentColor;
            this.Size = _formSize;
            pnlBody.BackColor = this.BackColor;
            pnlHeader.BackColor = this.BackColor;
            tbSearch.BackColor = this.BackColor;
            _LoadAllUsers();
            

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search")
                tbSearch.Text = string.Empty;
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == string.Empty)
                tbSearch.Text = "Search";
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.Find(Convert.ToInt32(contextMenuStrip1.Tag.ToString()));
            frmUpdateUser frm = new frmUpdateUser(user, _father1);
            pnlBody.Controls.Clear();
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.Find(Convert.ToInt32(contextMenuStrip1.Tag.ToString()));
            frmMyMessageBox frm = new frmMyMessageBox("do you want to delete this user ??", "NO", "YES");
            if(frm.ShowDialog() == DialogResult.Yes)
            {
                user.Delete();
                frm = new frmMyMessageBox("Deleted Succefully", "OK");
                frm.ShowDialog();
                this.frmAllUsers_Load(this, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbSearch.Text==string.Empty||tbSearch.Text == tbSearch.Tag.ToString())
            {
                return;
            }
            else
            {
                
                clsUser user = clsUser.Find(tbSearch.Text);
                frmUserInfocs frm = new frmUserInfocs(_CurrentColor, user, _formSize, _father1);
                pnlBody.Controls.Clear();
                frm.TopLevel = false;
                pnlBody.Controls.Add(frm);
                frm.Show();
            }

        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click( btnSearch,e );
            }
        }
    }
}
