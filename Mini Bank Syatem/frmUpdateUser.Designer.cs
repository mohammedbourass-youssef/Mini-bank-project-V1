namespace Mini_Bank_Syatem
{
    partial class frmUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserId = new System.Windows.Forms.Label();
            this.pnltitle = new System.Windows.Forms.Label();
            this.butnCancel = new System.Windows.Forms.Button();
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.tbUserNAme = new System.Windows.Forms.TextBox();
            this.tbPasword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chTransactions = new System.Windows.Forms.CheckBox();
            this.chManageUsers = new System.Windows.Forms.CheckBox();
            this.chManagerClientAccess = new System.Windows.Forms.CheckBox();
            this.chFullAccess = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlJumper = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gbPersonInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butnCancel);
            this.panel1.Controls.Add(this.lblUserId);
            this.panel1.Controls.Add(this.pnltitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 65);
            this.panel1.TabIndex = 0;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.White;
            this.lblUserId.Location = new System.Drawing.Point(515, 9);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(53, 39);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "00";
            // 
            // pnltitle
            // 
            this.pnltitle.AutoSize = true;
            this.pnltitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltitle.ForeColor = System.Drawing.Color.White;
            this.pnltitle.Location = new System.Drawing.Point(125, 9);
            this.pnltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(381, 39);
            this.pnltitle.TabIndex = 3;
            this.pnltitle.Text = "Update USER NUMBER : ";
            this.pnltitle.Click += new System.EventHandler(this.pnltitle_Click);
            // 
            // butnCancel
            // 
            this.butnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.butnCancel.FlatAppearance.BorderSize = 0;
            this.butnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnCancel.Image = ((System.Drawing.Image)(resources.GetObject("butnCancel.Image")));
            this.butnCancel.Location = new System.Drawing.Point(0, 0);
            this.butnCancel.Name = "butnCancel";
            this.butnCancel.Size = new System.Drawing.Size(75, 65);
            this.butnCancel.TabIndex = 5;
            this.butnCancel.UseVisualStyleBackColor = true;
            this.butnCancel.Click += new System.EventHandler(this.butnCancel_Click);
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.pnlJumper);
            this.gbPersonInfo.Controls.Add(this.tbUserNAme);
            this.gbPersonInfo.Controls.Add(this.tbPasword);
            this.gbPersonInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbPersonInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPersonInfo.ForeColor = System.Drawing.Color.White;
            this.gbPersonInfo.Location = new System.Drawing.Point(12, 92);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(846, 191);
            this.gbPersonInfo.TabIndex = 2;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Info";
            // 
            // tbUserNAme
            // 
            this.tbUserNAme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbUserNAme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserNAme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserNAme.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserNAme.ForeColor = System.Drawing.Color.White;
            this.tbUserNAme.HideSelection = false;
            this.tbUserNAme.Location = new System.Drawing.Point(31, 36);
            this.tbUserNAme.Name = "tbUserNAme";
            this.tbUserNAme.Size = new System.Drawing.Size(267, 40);
            this.tbUserNAme.TabIndex = 3;
            this.tbUserNAme.Tag = "User Name";
            this.tbUserNAme.Text = "User Name";
            this.tbUserNAme.Enter += new System.EventHandler(this.tbUserNAme_Enter);
            // 
            // tbPasword
            // 
            this.tbPasword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbPasword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasword.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasword.ForeColor = System.Drawing.Color.White;
            this.tbPasword.HideSelection = false;
            this.tbPasword.Location = new System.Drawing.Point(31, 108);
            this.tbPasword.Name = "tbPasword";
            this.tbPasword.Size = new System.Drawing.Size(267, 40);
            this.tbPasword.TabIndex = 1;
            this.tbPasword.Tag = "Password";
            this.tbPasword.Text = "Password";
            this.tbPasword.Enter += new System.EventHandler(this.tbUserNAme_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chTransactions);
            this.groupBox2.Controls.Add(this.chManageUsers);
            this.groupBox2.Controls.Add(this.chManagerClientAccess);
            this.groupBox2.Controls.Add(this.chFullAccess);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 164);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissions";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chTransactions
            // 
            this.chTransactions.AutoSize = true;
            this.chTransactions.BackColor = System.Drawing.Color.Transparent;
            this.chTransactions.Cursor = System.Windows.Forms.Cursors.Default;
            this.chTransactions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chTransactions.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chTransactions.Location = new System.Drawing.Point(446, 92);
            this.chTransactions.Name = "chTransactions";
            this.chTransactions.Size = new System.Drawing.Size(351, 44);
            this.chTransactions.TabIndex = 3;
            this.chTransactions.Tag = "4";
            this.chTransactions.Text = "Transactions Access";
            this.chTransactions.UseVisualStyleBackColor = false;
            this.chTransactions.CheckedChanged += new System.EventHandler(this.chFullAccess_CheckedChanged);
            // 
            // chManageUsers
            // 
            this.chManageUsers.AutoSize = true;
            this.chManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.chManageUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.chManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chManageUsers.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chManageUsers.Location = new System.Drawing.Point(446, 43);
            this.chManageUsers.Name = "chManageUsers";
            this.chManageUsers.Size = new System.Drawing.Size(382, 44);
            this.chManageUsers.TabIndex = 2;
            this.chManageUsers.Tag = "2";
            this.chManageUsers.Text = "Manage Users Access";
            this.chManageUsers.UseVisualStyleBackColor = true;
            this.chManageUsers.CheckedChanged += new System.EventHandler(this.chFullAccess_CheckedChanged);
            // 
            // chManagerClientAccess
            // 
            this.chManagerClientAccess.AutoSize = true;
            this.chManagerClientAccess.BackColor = System.Drawing.Color.Transparent;
            this.chManagerClientAccess.Cursor = System.Windows.Forms.Cursors.Default;
            this.chManagerClientAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chManagerClientAccess.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chManagerClientAccess.Location = new System.Drawing.Point(20, 92);
            this.chManagerClientAccess.Name = "chManagerClientAccess";
            this.chManagerClientAccess.Size = new System.Drawing.Size(405, 44);
            this.chManagerClientAccess.TabIndex = 1;
            this.chManagerClientAccess.Tag = "1";
            this.chManagerClientAccess.Text = " Manage Client Access";
            this.chManagerClientAccess.UseVisualStyleBackColor = false;
            this.chManagerClientAccess.CheckedChanged += new System.EventHandler(this.chFullAccess_CheckedChanged);
            // 
            // chFullAccess
            // 
            this.chFullAccess.AutoSize = true;
            this.chFullAccess.BackColor = System.Drawing.Color.Transparent;
            this.chFullAccess.Cursor = System.Windows.Forms.Cursors.Default;
            this.chFullAccess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chFullAccess.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chFullAccess.Location = new System.Drawing.Point(20, 44);
            this.chFullAccess.Name = "chFullAccess";
            this.chFullAccess.Size = new System.Drawing.Size(208, 44);
            this.chFullAccess.TabIndex = 0;
            this.chFullAccess.Text = "Full Access";
            this.chFullAccess.UseVisualStyleBackColor = false;
            this.chFullAccess.CheckedChanged += new System.EventHandler(this.chFullAccess_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(223, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(345, 48);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save New Informations";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlJumper
            // 
            this.pnlJumper.BackColor = System.Drawing.Color.White;
            this.pnlJumper.Location = new System.Drawing.Point(31, 82);
            this.pnlJumper.Name = "pnlJumper";
            this.pnlJumper.Size = new System.Drawing.Size(463, 8);
            this.pnlJumper.TabIndex = 4;
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(870, 595);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPersonInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateUser";
            this.Load += new System.EventHandler(this.frmUpdateUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label pnltitle;
        private System.Windows.Forms.Button butnCancel;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.TextBox tbUserNAme;
        private System.Windows.Forms.TextBox tbPasword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chTransactions;
        private System.Windows.Forms.CheckBox chManageUsers;
        private System.Windows.Forms.CheckBox chManagerClientAccess;
        private System.Windows.Forms.CheckBox chFullAccess;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlJumper;
    }
}