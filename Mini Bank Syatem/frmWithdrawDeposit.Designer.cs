namespace Mini_Bank_Syatem
{
    partial class frmWithdrawDeposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdrawDeposit));
            this.cmClients = new System.Windows.Forms.ComboBox();
            this.pnltitle = new System.Windows.Forms.Label();
            this.lblaccountnumber = new System.Windows.Forms.Label();
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.PbProfile = new System.Windows.Forms.PictureBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.butnCancel = new System.Windows.Forms.Button();
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // cmClients
            // 
            this.cmClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.cmClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmClients.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cmClients.ForeColor = System.Drawing.Color.White;
            this.cmClients.FormattingEnabled = true;
            this.cmClients.Location = new System.Drawing.Point(313, 109);
            this.cmClients.Name = "cmClients";
            this.cmClients.Size = new System.Drawing.Size(358, 32);
            this.cmClients.TabIndex = 0;
            this.cmClients.SelectedIndexChanged += new System.EventHandler(this.cmClients_SelectedIndexChanged);
            // 
            // pnltitle
            // 
            this.pnltitle.AutoSize = true;
            this.pnltitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltitle.ForeColor = System.Drawing.Color.White;
            this.pnltitle.Location = new System.Drawing.Point(71, 109);
            this.pnltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(226, 24);
            this.pnltitle.TabIndex = 5;
            this.pnltitle.Text = "Choose Client Name";
            // 
            // lblaccountnumber
            // 
            this.lblaccountnumber.AutoSize = true;
            this.lblaccountnumber.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblaccountnumber.ForeColor = System.Drawing.Color.White;
            this.lblaccountnumber.Location = new System.Drawing.Point(141, 43);
            this.lblaccountnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaccountnumber.Name = "lblaccountnumber";
            this.lblaccountnumber.Size = new System.Drawing.Size(210, 24);
            this.lblaccountnumber.TabIndex = 13;
            this.lblaccountnumber.Text = "ACCOUNT NUMBER ";
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.PbProfile);
            this.gbPicture.Controls.Add(this.lblaccountnumber);
            this.gbPicture.Controls.Add(this.lblphone);
            this.gbPicture.Controls.Add(this.label3);
            this.gbPicture.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.gbPicture.ForeColor = System.Drawing.Color.White;
            this.gbPicture.Location = new System.Drawing.Point(9, 191);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(496, 175);
            this.gbPicture.TabIndex = 11;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "Profile";
            // 
            // PbProfile
            // 
            this.PbProfile.Image = ((System.Drawing.Image)(resources.GetObject("PbProfile.Image")));
            this.PbProfile.Location = new System.Drawing.Point(12, 43);
            this.PbProfile.Name = "PbProfile";
            this.PbProfile.Size = new System.Drawing.Size(122, 112);
            this.PbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbProfile.TabIndex = 14;
            this.PbProfile.TabStop = false;
            this.PbProfile.Tag = "NULL";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblphone.ForeColor = System.Drawing.Color.White;
            this.lblphone.Location = new System.Drawing.Point(337, 106);
            this.lblphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(94, 24);
            this.lblphone.TabIndex = 12;
            this.lblphone.Text = "0000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "PHONE NUMBER : ";
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblbalance.ForeColor = System.Drawing.Color.White;
            this.lblbalance.Location = new System.Drawing.Point(726, 264);
            this.lblbalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(98, 39);
            this.lblbalance.TabIndex = 13;
            this.lblbalance.Text = "0.000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(544, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Balance : ";
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbAmount.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbAmount.ForeColor = System.Drawing.Color.White;
            this.tbAmount.Location = new System.Drawing.Point(334, 416);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(305, 47);
            this.tbAmount.TabIndex = 14;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(203, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(372, 42);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Choose Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Amount";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(280, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(345, 48);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save New amount";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // butnCancel
            // 
            this.butnCancel.FlatAppearance.BorderSize = 0;
            this.butnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnCancel.Image = ((System.Drawing.Image)(resources.GetObject("butnCancel.Image")));
            this.butnCancel.Location = new System.Drawing.Point(9, 6);
            this.butnCancel.Name = "butnCancel";
            this.butnCancel.Size = new System.Drawing.Size(75, 65);
            this.butnCancel.TabIndex = 22;
            this.butnCancel.UseVisualStyleBackColor = true;
            this.butnCancel.Click += new System.EventHandler(this.butnCancel_Click);
            // 
            // frmWithdrawDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(870, 595);
            this.Controls.Add(this.butnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.gbPicture);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.pnltitle);
            this.Controls.Add(this.cmClients);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWithdrawDeposit";
            this.ShowInTaskbar = false;
            this.Text = "frmWithdra";
            this.Load += new System.EventHandler(this.frmWithdra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmWithdrawDeposit_KeyDown);
            this.gbPicture.ResumeLayout(false);
            this.gbPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmClients;
        private System.Windows.Forms.Label pnltitle;
        private System.Windows.Forms.Label lblaccountnumber;
        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.PictureBox PbProfile;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button butnCancel;
    }
}