namespace Mini_Bank_Syatem
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.btmDeletePicture = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.PbProfile = new System.Windows.Forms.PictureBox();
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAcountNumber = new System.Windows.Forms.TextBox();
            this.showPinCode = new System.Windows.Forms.CheckBox();
            this.tbPinCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbProfile)).BeginInit();
            this.gbPersonInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(441, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(337, 48);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save New Information";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(49, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(299, 48);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.btmDeletePicture);
            this.gbPicture.Controls.Add(this.btnAddPicture);
            this.gbPicture.Controls.Add(this.PbProfile);
            this.gbPicture.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPicture.ForeColor = System.Drawing.Color.White;
            this.gbPicture.Location = new System.Drawing.Point(441, 104);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(406, 382);
            this.gbPicture.TabIndex = 6;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "Profile";
            // 
            // btmDeletePicture
            // 
            this.btmDeletePicture.FlatAppearance.BorderSize = 0;
            this.btmDeletePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmDeletePicture.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDeletePicture.Image = ((System.Drawing.Image)(resources.GetObject("btmDeletePicture.Image")));
            this.btmDeletePicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmDeletePicture.Location = new System.Drawing.Point(205, 303);
            this.btmDeletePicture.Name = "btmDeletePicture";
            this.btmDeletePicture.Size = new System.Drawing.Size(156, 48);
            this.btmDeletePicture.TabIndex = 2;
            this.btmDeletePicture.Text = "Remove";
            this.btmDeletePicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmDeletePicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmDeletePicture.UseVisualStyleBackColor = true;
            this.btmDeletePicture.Click += new System.EventHandler(this.btmDeletePicture_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.FlatAppearance.BorderSize = 0;
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPicture.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPicture.Image")));
            this.btnAddPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPicture.Location = new System.Drawing.Point(21, 303);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(156, 48);
            this.btnAddPicture.TabIndex = 1;
            this.btnAddPicture.Text = "Add";
            this.btnAddPicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // PbProfile
            // 
            this.PbProfile.Image = ((System.Drawing.Image)(resources.GetObject("PbProfile.Image")));
            this.PbProfile.Location = new System.Drawing.Point(21, 31);
            this.PbProfile.Name = "PbProfile";
            this.PbProfile.Size = new System.Drawing.Size(379, 260);
            this.PbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbProfile.TabIndex = 0;
            this.PbProfile.TabStop = false;
            this.PbProfile.Tag = "NULL";
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.tbBalance);
            this.gbPersonInfo.Controls.Add(this.tbPhone);
            this.gbPersonInfo.Controls.Add(this.tbAcountNumber);
            this.gbPersonInfo.Controls.Add(this.showPinCode);
            this.gbPersonInfo.Controls.Add(this.tbPinCode);
            this.gbPersonInfo.Controls.Add(this.tbName);
            this.gbPersonInfo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonInfo.ForeColor = System.Drawing.Color.White;
            this.gbPersonInfo.Location = new System.Drawing.Point(22, 90);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(356, 396);
            this.gbPersonInfo.TabIndex = 5;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Info";
            // 
            // tbBalance
            // 
            this.tbBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBalance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalance.ForeColor = System.Drawing.Color.White;
            this.tbBalance.Location = new System.Drawing.Point(31, 324);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(267, 40);
            this.tbBalance.TabIndex = 5;
            this.tbBalance.Tag = "Start Balance";
            this.tbBalance.Text = "Start Balance";
            this.tbBalance.MouseEnter += new System.EventHandler(this.tbAcountNumber_MouseEnter);
            this.tbBalance.MouseLeave += new System.EventHandler(this.tbAcountNumber_MouseLeave);
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.ForeColor = System.Drawing.Color.White;
            this.tbPhone.Location = new System.Drawing.Point(31, 252);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(267, 40);
            this.tbPhone.TabIndex = 4;
            this.tbPhone.Tag = "Phone";
            this.tbPhone.Text = "Phone";
            this.tbPhone.MouseEnter += new System.EventHandler(this.tbAcountNumber_MouseEnter);
            this.tbPhone.MouseLeave += new System.EventHandler(this.tbAcountNumber_MouseLeave);
            // 
            // tbAcountNumber
            // 
            this.tbAcountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbAcountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAcountNumber.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAcountNumber.ForeColor = System.Drawing.Color.White;
            this.tbAcountNumber.Location = new System.Drawing.Point(31, 36);
            this.tbAcountNumber.Name = "tbAcountNumber";
            this.tbAcountNumber.ReadOnly = true;
            this.tbAcountNumber.Size = new System.Drawing.Size(267, 40);
            this.tbAcountNumber.TabIndex = 3;
            this.tbAcountNumber.Tag = "Account Number";
            this.tbAcountNumber.Text = "Account Number";
            this.tbAcountNumber.MouseEnter += new System.EventHandler(this.tbAcountNumber_MouseEnter);
            this.tbAcountNumber.MouseLeave += new System.EventHandler(this.tbAcountNumber_MouseLeave);
            // 
            // showPinCode
            // 
            this.showPinCode.AutoSize = true;
            this.showPinCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPinCode.Location = new System.Drawing.Point(170, 153);
            this.showPinCode.Name = "showPinCode";
            this.showPinCode.Size = new System.Drawing.Size(139, 24);
            this.showPinCode.TabIndex = 2;
            this.showPinCode.Text = "Show Pin Code";
            this.showPinCode.UseVisualStyleBackColor = true;
            this.showPinCode.CheckedChanged += new System.EventHandler(this.showPinCode_CheckedChanged);
            // 
            // tbPinCode
            // 
            this.tbPinCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPinCode.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinCode.ForeColor = System.Drawing.Color.White;
            this.tbPinCode.Location = new System.Drawing.Point(31, 108);
            this.tbPinCode.Name = "tbPinCode";
            this.tbPinCode.Size = new System.Drawing.Size(267, 40);
            this.tbPinCode.TabIndex = 1;
            this.tbPinCode.Tag = "Pin Code";
            this.tbPinCode.Text = "Pin Code";
            this.tbPinCode.TextChanged += new System.EventHandler(this.tbPinCode_TextChanged);
            this.tbPinCode.MouseEnter += new System.EventHandler(this.tbAcountNumber_MouseEnter);
            this.tbPinCode.MouseLeave += new System.EventHandler(this.tbAcountNumber_MouseLeave);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(31, 180);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(267, 40);
            this.tbName.TabIndex = 0;
            this.tbName.Tag = "Full Name";
            this.tbName.Text = "Full Name";
            this.tbName.MouseEnter += new System.EventHandler(this.tbAcountNumber_MouseEnter);
            this.tbName.MouseLeave += new System.EventHandler(this.tbAcountNumber_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAccountID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 51);
            this.panel1.TabIndex = 9;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblAccountID.ForeColor = System.Drawing.Color.White;
            this.lblAccountID.Location = new System.Drawing.Point(449, 9);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(38, 28);
            this.lblAccountID.TabIndex = 1;
            this.lblAccountID.Text = "00";
            this.lblAccountID.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Client Number : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(880, 628);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbPicture);
            this.Controls.Add(this.gbPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.gbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbProfile)).EndInit();
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.Button btmDeletePicture;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.PictureBox PbProfile;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAcountNumber;
        private System.Windows.Forms.CheckBox showPinCode;
        private System.Windows.Forms.TextBox tbPinCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}