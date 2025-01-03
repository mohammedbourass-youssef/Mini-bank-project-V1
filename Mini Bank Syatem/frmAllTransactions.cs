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
    public partial class frmAllTransactions : Form
    {
        Color _CurrentColor;
        frmTransactions _father;
        clsUser _user;
        public frmAllTransactions(Color color,frmTransactions father,clsUser user)
        {
            _user = user;
            _father = father;
            _CurrentColor = color;
            InitializeComponent();
        }


        DataTable _GetTransactions()
        {
            DataTable AllTransactions = clsTransaction.GetAllTransactions();

            DataTable UserTransactions = new DataTable();

            UserTransactions.Columns.Add("TransactionID", typeof(int));
            UserTransactions.Columns.Add("ClientName", typeof(string));
            UserTransactions.Columns.Add("TransactionType", typeof(string));
            UserTransactions.Columns.Add("Amount", typeof(double));
            clsClient client = null;
            foreach (DataRow row in AllTransactions.Rows)
            {
               if(_user.userID == (int)row["UserID"])
                {
                    client = clsClient.Find((int)row["ClientID"]);
                    UserTransactions.Rows.Add(Convert.ToInt32(row["TransactionID"]), client.ClientName,
                        clsTransactionType.GetNAmeUsingID(Convert.ToInt32((int)row["TransactionTypeID"])), Convert.ToDouble(row["Amount"]));
                }
            }
            return UserTransactions;    
        }
        void   _LoadAllTransactions()
        {
            pnlBody.Controls.Clear();
            Size buttonSize = new Size(931, 104);
            pnlBody.AutoScroll = true;
            int yPosition = 0;
            string PicturePath = string.Empty;

            DataTable data = _GetTransactions();

            foreach (DataRow row in data.Rows)
            {
                Button btn = new Button
                {
                    Text = $"ID:{row["TransactionID"]}                           Transaction Type :  {row["TransactionType"]}   \r\nClientName :  {row["ClientName"]}                  Amount :  {row["Amount"]}  " ,
                 
                    //Text = $"{row["AccountNumber"]}\n{row["ClientName"]}\n{row["Phone"]}",
                    Size = new Size(931, 100),
                    Dock = DockStyle.Top,
                    Location = new Point(10, yPosition), // Set the location of the button
                    Margin = new Padding(10), // Space around the button
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    
                    ImageAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    BackColor = _CurrentColor, // Button background color
                    ForeColor = Color.White, // Button text color
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new Font("Century Gothic", 20, FontStyle.Bold), // Font for the button text
                    FlatStyle = FlatStyle.Flat, // Remove button border
                    FlatAppearance = { BorderSize = 2 }, // Remove button border
                    
                };

                yPosition += 139;
                // Add the button to your form or panel
                pnlBody.Controls.Add(btn);
                btn.Click += delegate
                {
                 

                };
                btn.MouseUp += delegate
                {
                   
                };
            }
        }
        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAllTransactions_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _user.username;
            _LoadAllTransactions();
        }
    }
}
