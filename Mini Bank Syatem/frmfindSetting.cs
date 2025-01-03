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
    public partial class frmfindSetting : Form
    {
        Color _backcolor;
        public frmfindSetting(Color color)
        {
            _backcolor = color;
            InitializeComponent();
        }

        private void frmfindSetting_Load(object sender, EventArgs e)
        {
            this.BackColor = _backcolor;
            pnlheader.BackColor = _backcolor;
            groupBox1.BackColor = _backcolor;
            rbfullname.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(rbAcountNumber.Checked)
            {
              this.DialogResult = DialogResult.OK;
            }
            if (rbfullname.Checked)
             this.DialogResult = DialogResult.Yes;
            if (rbClientID.Checked)
             this.DialogResult= DialogResult.No;
            MessageBox.Show("Saved Succefully");
        }
    }
}
