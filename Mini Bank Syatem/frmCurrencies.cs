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
    public partial class frmCurrencies : Form
    {
        Color _headercolor = Color.White;
        Size smallsize = new Size(67, 66);
        Size biglsize = new Size(295, 66);
        bool issmall = true;
        bool isoptionsclicked = false;
        Size _childSize = new Size(880, 628);
        clsUser _CurentUser;
        List<clsCircularPictureButton> _Buttns = new List<clsCircularPictureButton>();
        public frmCurrencies(Color color,clsUser clsUser)
        {
            _CurentUser = clsUser;  
            _headercolor = color;
            InitializeComponent();
        }
        void _LightJumperPAnel(object sender)
        {
            Button btn = (Button)sender;
            pnlJumper.BackColor = Color.White;
            btn.Left = pnlJumper.Right;
            pnlJumper.Top = btn.Top;    // Align the top of pnlJumper with the button

        }
        void _GiveButtonsSmallSize()
        {
            pnlButtonslesf.Size = smallsize;
            btmOptions.Size = smallsize;
            btmOptions.Text = string.Empty;
            btnCurrencies.Size = smallsize;
            btnCurrencies.Text = string.Empty;
            btnExChange.Size = smallsize;
            btnExChange.Text = string.Empty;
            btnFind.Size = smallsize;
            btnFind.Text = string.Empty;
            issmall = true;
            isoptionsclicked = false;
        }
        void _GiveButtonsBigSize()
        {
            pnlButtonslesf.Size = biglsize;
            btmOptions.Size = biglsize;
            btmOptions.Text = btmOptions.Tag.ToString();
            btnCurrencies.Size = biglsize;
            btnCurrencies.Text = btnCurrencies.Tag.ToString();
            btnExChange.Size = biglsize;
            btnExChange.Text = btnExChange.Tag.ToString();
            btnFind.Size = biglsize;
            btnFind.Text = btnFind.Tag.ToString();

            issmall = false;
        }
        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            this.BackColor = _headercolor;
            btnFind_Click(btnFind, e);

            Size buttonSize = new Size(931, 104);
            DataTable data = clsCurrrency.AllCurrencies();
            int yPosition = 0;
            string PicturePath = string.Empty;
            foreach (DataRow row in data.Rows)
            {

                PicturePath = (string)row["CountryPicturePath"];
                clsCircularPictureButton btn = new clsCircularPictureButton
                {
                    Text = $"             {row["Country"]}          " +
                    $"{row["CurrencyCode"]}           " +
                    $"{row["Rate"]}",
                    //Text = $"{row["AccountNumber"]}\n{row["ClientName"]}\n{row["Phone"]}",
                    Size = new Size(931, 100),
                    Dock = DockStyle.Top,
                    Location = new Point(10, yPosition), // Set the location of the button
                    Margin = new Padding(10), // Space around the button
                    //CircularImage = Image.FromFile(PicturePath), // Assign the image here
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    Tag = (int)row["CurrencyID"],
                    ImageAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    BackColor = _headercolor, // Button background color
                    ForeColor = Color.White, // Button text color
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new Font("Century Gothic", 20, FontStyle.Bold), // Font for the button text
                    FlatStyle = FlatStyle.Flat, // Remove button border
                    FlatAppearance = { BorderSize = 0 }, // Remove button border

                };

                yPosition += 139;
                // Add the button to your form or panel
                _Buttns.Add(btn);
                btn.Click += delegate
                {

                };
                btn.MouseUp += delegate
                {

                };
            }

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
        private void btmOptions_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            isoptionsclicked = true;
            if (issmall)
                _GiveButtonsBigSize();
            else
                _GiveButtonsSmallSize();
        }

        public void btnCurrencies_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            _GiveButtonsSmallSize();
            pnlbody.Controls.Clear();
            FrmAllCurrencies frm = new FrmAllCurrencies(BackColor, _childSize, this,_Buttns);
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        public void btnFind_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            _GiveButtonsSmallSize();
            pnlbody.Controls.Clear();
           frmFindCurrencies frm = new frmFindCurrencies();
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        public void btnExChange_Click(object sender, EventArgs e)
        {
            _LightJumperPAnel(sender);
            _GiveButtonsSmallSize();
            pnlbody.Controls.Clear();
            frmEchange frm = new frmEchange(this);
            frm.TopLevel = false;
            pnlbody.Controls.Add(frm);
            frm.Dock = DockStyle.Right;
            frm.Show();
        }

        private void pnlbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlButtonslesf_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
