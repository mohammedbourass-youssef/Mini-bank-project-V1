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
    public partial class frmTotalBalance : Form
    {
        frmTransactions _father;
        clsUser _user;
        Color _CurrentColor;
        public frmTotalBalance(frmTransactions transactions,clsUser user, Color currentColor)
        {
            _father = transactions;
            _user = user;
            InitializeComponent();
            _CurrentColor = currentColor;
        }
        void _LoadAllClient()
        {
            pnlBody.Controls.Clear();
            Size buttonSize = new Size(931, 104);
            pnlBody.AutoScroll = true;
            DataTable data = clsClient.GetAllClients();
            int yPosition = 0;
            string PicturePath = string.Empty;
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
                    Text = $"             {row["AccountNumber"]}         " +
                    $"{row["ClientName"]}           " +
                    $"{row["Balance"]} MAD",
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
                    //FrmClientInfo frm = new FrmClientInfo(_CurrentColor, clsClient.Find(Convert.ToInt32(btn.Tag.ToString())), _father);
                    //pnlBody.Controls.Clear();
                    //frm.TopLevel = false;
                    //pnlBody.Controls.Add(frm);
                    //frm.Dock = DockStyle.Fill;
                    //frm.BringToFront();
                    //frm.Show();
                };
                btn.MouseUp += delegate
                {
                    contextMenuStrip1.Tag = btn.Tag;
                };
            }
        }
        

        private void frmTotalBalance_Load(object sender, EventArgs e)
        {
            _LoadAllClient();
            double x = clsUser.TotaleBalance();
            lblTotalBalamce.Text = x.ToString();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(Convert.ToInt32(contextMenuStrip1.Tag.ToString()));
            frmWithdrawDeposit frm = new frmWithdrawDeposit(_CurrentColor,_father, clsTransactionType.Withdraw,client,_user);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(Convert.ToInt32(contextMenuStrip1.Tag.ToString()));
            frmWithdrawDeposit frm = new frmWithdrawDeposit(_CurrentColor, _father, clsTransactionType.Deposit, client, _user);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }
    }
}
