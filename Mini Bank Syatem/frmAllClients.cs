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
using System.Windows.Forms.VisualStyles;

namespace Mini_Bank_Syatem
{
    public partial class frmAllClients : Form
    {
        Color _CurrentColor = Color.White;
        Size _formSize;
        frmManageClients _father;
        public frmAllClients(Color color,Size size,frmManageClients father)
        {
            _father = father;
            _formSize = size;
            _CurrentColor = color;
            InitializeComponent();
        }
        void _LoadAllClient()
        {
            pnlBody.Controls.Clear();
            Size buttonSize = new Size(931, 104);
            pnlBody.AutoScroll = true;
            DataTable data = clsClient.GetAllClients();
            int yPosition = 0;
            string PicturePath=string.Empty;
            foreach (DataRow row in data.Rows)
            {
                if (row["picturepath"] != DBNull.Value)
                    PicturePath = (string)row["picturepath"];
                else
                    PicturePath = @"C:\Users\USER\source\repos\Mini Bank Syatem\EmtyPicture.png";
                try
                {
                    Image.FromFile(PicturePath);
                }
                catch (Exception ex)
                {
                    {
                        PicturePath = @"C:\Users\USER\source\repos\Mini Bank Syatem\EmtyPicture.png";
                    }
                }
                clsCircularPictureButton btn = new clsCircularPictureButton
                {
                    Text = $"             {row["AccountNumber"]}          " +
                    $"{row["ClientName"]}           " +
                    $"{row["Phone"]}",
                    //Text = $"{row["AccountNumber"]}\n{row["ClientName"]}\n{row["Phone"]}",
                    Size = new Size(931, 100),
                    Dock = DockStyle.Top,
                    Location = new Point(10, yPosition), // Set the location of the button
                    Margin = new Padding(10), // Space around the button
                    CircularImage = Image.FromFile(PicturePath), // Assign the image here
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    Tag = (int)row["ClientID"],
                    ImageAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    BackColor = _CurrentColor, // Button background color
                    ForeColor = Color.White, // Button text color
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new Font("Century Gothic", 20, FontStyle.Bold), // Font for the button text
                    FlatStyle = FlatStyle.Flat, // Remove button border
                    FlatAppearance = { BorderSize = 0 }, // Remove button border
                    ContextMenuStrip = contextMenuStrip1,
                };
                
                yPosition += 139;
                // Add the button to your form or panel
                pnlBody.Controls.Add(btn);
                btn.Click += delegate
                {
                    FrmClientInfo frm = new FrmClientInfo(_CurrentColor, clsClient.Find(Convert.ToInt32(btn.Tag.ToString())),_father);
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
        private void frmAllClients_Load(object sender, EventArgs e)
        {
            this.Size  = _formSize;
            pnlBody.BackColor = _CurrentColor;
            pnlHeader.BackColor = _CurrentColor;    
            _LoadAllClient();

        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmUpdate frm = new frmUpdate(clsClient.Find(Convert.ToInt32(contextMenuStrip1.Tag.ToString())),_CurrentColor,_formSize);
            this.BackColor = Color.FromArgb(125, 123, 103);
            frm.ShowDialog();
            this.BackColor = _CurrentColor;
            _LoadAllClient();

        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmMyMessageBox frm = new frmMyMessageBox("wait the form will shown here", "ok");
                frm.ShowDialog();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(Convert.ToInt32(contextMenuStrip1.Tag.ToString()));
            frmMyMessageBox frmMyMessageBox = new frmMyMessageBox("Do you want to delete Mr " + client.ClientID.ToString(), "No", "YES");
            if(frmMyMessageBox.ShowDialog() == DialogResult.Yes)
            {
                if (client.Delete())
                {
                    frmMyMessageBox = new frmMyMessageBox("Mr " + client.ClientName+" Deleted Succefully", "ok");
                    frmMyMessageBox.ShowDialog();
                }
                else
                {
                    frmMyMessageBox = new frmMyMessageBox("Error ", "ok");
                    frmMyMessageBox.ShowDialog();
                }
            }
            _LoadAllClient() ;
        }

        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientInfo frm = new FrmClientInfo(_CurrentColor, clsClient.Find(Convert.ToInt32(contextMenuStrip1.Tag.ToString())));
            frm.ShowDialog();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
