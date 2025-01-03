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
    public partial class femFindScreen : Form
    {
        Color _CurrentColor;
        enum EnSearchMethode { ClientID,AccountNumber,ClientName}
        EnSearchMethode _searchmode= EnSearchMethode.ClientName;
        public femFindScreen(Color color)
        {
            _CurrentColor = color;
            InitializeComponent();
        }
        EnSearchMethode _GetSearchMethod(DialogResult result)
        {
            switch (result)
            {
                case DialogResult.OK:return EnSearchMethode.AccountNumber;
                case DialogResult.Cancel:return EnSearchMethode.AccountNumber;
                case DialogResult.Yes:return EnSearchMethode.ClientName;
                case DialogResult.No:return EnSearchMethode.ClientID;
                default: return EnSearchMethode.ClientName;
            }
        }

        string _tbSearchName()
        {
            switch(_searchmode)
            {
                case EnSearchMethode.ClientName:tbSearch.Text = "ClIENT NAME";return "ClIENT NAME";
                case EnSearchMethode.ClientID: tbSearch.Text = "CLIENT ID"; return "CLIENT ID";
                case EnSearchMethode.AccountNumber: tbSearch.Text = "ACCOUNT NUMBER"; return "ACCOUNT NUMBER";
            }
            return "";
        }

        bool _GetClientsByName()
        {
            string PicturePath = "";
            Size buttonSize = new Size(931, 104);
            pnlBody.AutoScroll = true;
            DataTable data = clsClient.GetAllClients();
            int yPosition = 0;
            bool result=false;

            foreach (DataRow row in data.Rows)
            {
                if ((string)row["ClientName"] == tbSearch.Text)
                {
                    result = true;
                }

            }
            if (result)
            {
                foreach (DataRow row in data.Rows)
                {
                    if ((string)row["ClientName"] == tbSearch.Text)
                    {
                        result = true;
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

                        };

                        yPosition += 139;
                        // Add the button to your form or panel
                        pnlBody.Controls.Add(btn);
                        btn.Click += delegate
                        {
                            FrmClientInfo frm = new FrmClientInfo(_CurrentColor, clsClient.Find(Convert.ToInt32(btn.Tag.ToString())));
                            frm.ShowDialog();
                        };
                    }

                }
                return result;
            }
            return result;
        }
     

      

        bool  _GetClientsByIDandAcountNumber(clsClient client)
        {
            if(client == null) return false;
            pnlBody.Controls.Clear();
            FrmClientInfo frm = new FrmClientInfo(_CurrentColor,client);
            frm.TopLevel = false;
            pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
            string PicturePath = "";
            Size buttonSize = new Size(931, 104);
            pnlBody.AutoScroll = true;
            DataTable data = clsClient.GetAllClients();
            int yPosition = 0;

            if (client.PicturePath != "")
                PicturePath = client.PicturePath;
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
                    Text = $"             {client.AccountNumber}          " +
                    $"{client.ClientName}           " +
                    $"{client.Phone}",
                    //Text = $"{row["AccountNumber"]}\n{row["ClientName"]}\n{row["Phone"]}",
                    Size = new Size(931, 100),
                    Dock = DockStyle.Top,
                    Location = new Point(10, yPosition), // Set the location of the button
                    Margin = new Padding(10), // Space around the button
                    CircularImage = Image.FromFile(PicturePath), // Assign the image here
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    Tag = client.ClientID,
                    ImageAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    BackColor = _CurrentColor, // Button background color
                    ForeColor = Color.White, // Button text color
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new Font("Century Gothic", 20, FontStyle.Bold), // Font for the button text
                    FlatStyle = FlatStyle.Flat, // Remove button border
                    FlatAppearance = { BorderSize = 0 }, // Remove button border

                };

            yPosition += 139;
            // Add the button to your form or panel
            pnlBody.Controls.Add(btn);
            btn.Click += delegate
                {
                    FrmClientInfo frm1 = new FrmClientInfo(_CurrentColor, clsClient.Find(Convert.ToInt32(btn.Tag.ToString())));
                    frm1.ShowDialog();
                };
            
            return true;
        }

        bool _FindClient()
        {
            
            switch (_searchmode)
            {
                case EnSearchMethode.ClientID:return _GetClientsByIDandAcountNumber(clsClient.Find(Convert.ToInt32(tbSearch.Text)));
                case EnSearchMethode.AccountNumber:return  _GetClientsByIDandAcountNumber(clsClient.Find(tbSearch.Text));
                case EnSearchMethode.ClientName:return _GetClientsByName();
            }
            return false;
        }


        private void femFindScreen_Load(object sender, EventArgs e)
        {
            _tbSearchName();
            this.BackColor = _CurrentColor;
            pnlBody.BackColor = _CurrentColor;
            pnlSearch.BackColor = _CurrentColor;
            tbSearch.BackColor = _CurrentColor;
        }

        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                pnlBody.Controls.Clear();
                if (_FindClient())
                {
                    label1.Text = "Foundsuccefully";
                }
                else
                {
                    label1.Text = "Not found";
                    pnlBody.Controls.Clear();
                    pnlBody.Controls.Add(label1);
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmfindSetting setting = new frmfindSetting(_CurrentColor);
            _searchmode = _GetSearchMethod(setting.ShowDialog());
            _tbSearchName();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == _tbSearchName())
                tbSearch.Text = string.Empty;
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == string.Empty)
                tbSearch.Text = _tbSearchName();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBody_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (_FindClient())
            {
                label1.Text = "Foundsuccefully";
            }
                else
            {
                label1.Text = "Not found";
                pnlBody.Controls.Clear();
                pnlBody.Controls.Add(label1);
            }
        }
    }
}
