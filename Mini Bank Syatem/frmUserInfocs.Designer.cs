namespace Mini_Bank_Syatem
{
    partial class frmUserInfocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfocs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butnCancel = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.pnltitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chTransactions = new System.Windows.Forms.CheckBox();
            this.chManageUsers = new System.Windows.Forms.CheckBox();
            this.chManagerClientAccess = new System.Windows.Forms.CheckBox();
            this.chFullAccess = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(870, 66);
            this.panel1.TabIndex = 11;
            // 
            // butnCancel
            // 
            this.butnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.butnCancel.FlatAppearance.BorderSize = 0;
            this.butnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnCancel.Image = ((System.Drawing.Image)(resources.GetObject("butnCancel.Image")));
            this.butnCancel.Location = new System.Drawing.Point(0, 0);
            this.butnCancel.Name = "butnCancel";
            this.butnCancel.Size = new System.Drawing.Size(75, 66);
            this.butnCancel.TabIndex = 3;
            this.butnCancel.UseVisualStyleBackColor = true;
            this.butnCancel.Click += new System.EventHandler(this.butnCancel_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.White;
            this.lblUserId.Location = new System.Drawing.Point(486, 9);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(53, 39);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "00";
            // 
            // pnltitle
            // 
            this.pnltitle.AutoSize = true;
            this.pnltitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltitle.ForeColor = System.Drawing.Color.White;
            this.pnltitle.Location = new System.Drawing.Point(224, 9);
            this.pnltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(254, 39);
            this.pnltitle.TabIndex = 1;
            this.pnltitle.Text = "USER NUMBER : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnal Info : ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(346, 105);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(182, 39);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Mohamed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "PASSWORD  : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.No;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(346, 42);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(182, 39);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "Mohamed";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Cursor = System.Windows.Forms.Cursors.No;
            this.label.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(24, 42);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(219, 39);
            this.label.TabIndex = 12;
            this.label.Text = "USER NAME : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chTransactions);
            this.groupBox2.Controls.Add(this.chManageUsers);
            this.groupBox2.Controls.Add(this.chManagerClientAccess);
            this.groupBox2.Controls.Add(this.chFullAccess);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 168);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissions";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chTransactions
            // 
            this.chTransactions.AutoSize = true;
            this.chTransactions.BackColor = System.Drawing.Color.Transparent;
            this.chTransactions.Cursor = System.Windows.Forms.Cursors.No;
            this.chTransactions.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chTransactions.Location = new System.Drawing.Point(446, 92);
            this.chTransactions.Name = "chTransactions";
            this.chTransactions.Size = new System.Drawing.Size(345, 43);
            this.chTransactions.TabIndex = 3;
            this.chTransactions.Text = "Transactions Access";
            this.chTransactions.UseVisualStyleBackColor = false;
            this.chTransactions.Visible = false;
            this.chTransactions.CheckedChanged += new System.EventHandler(this.chTransactions_CheckedChanged);
            this.chTransactions.Click += new System.EventHandler(this.chTransactions_Click);
            // 
            // chManageUsers
            // 
            this.chManageUsers.AutoCheck = false;
            this.chManageUsers.AutoSize = true;
            this.chManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.chManageUsers.Cursor = System.Windows.Forms.Cursors.No;
            this.chManageUsers.Enabled = false;
            this.chManageUsers.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chManageUsers.Location = new System.Drawing.Point(446, 43);
            this.chManageUsers.Name = "chManageUsers";
            this.chManageUsers.Size = new System.Drawing.Size(376, 43);
            this.chManageUsers.TabIndex = 2;
            this.chManageUsers.Text = "Manage Users Access";
            this.chManageUsers.UseVisualStyleBackColor = false;
            this.chManageUsers.Visible = false;
            this.chManageUsers.CheckedChanged += new System.EventHandler(this.chTransactions_CheckedChanged);
            this.chManageUsers.Click += new System.EventHandler(this.chTransactions_Click);
            // 
            // chManagerClientAccess
            // 
            this.chManagerClientAccess.AutoSize = true;
            this.chManagerClientAccess.BackColor = System.Drawing.Color.Transparent;
            this.chManagerClientAccess.Cursor = System.Windows.Forms.Cursors.No;
            this.chManagerClientAccess.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chManagerClientAccess.Location = new System.Drawing.Point(20, 92);
            this.chManagerClientAccess.Name = "chManagerClientAccess";
            this.chManagerClientAccess.Size = new System.Drawing.Size(399, 43);
            this.chManagerClientAccess.TabIndex = 1;
            this.chManagerClientAccess.Text = " Manage Client Access";
            this.chManagerClientAccess.UseVisualStyleBackColor = false;
            this.chManagerClientAccess.Visible = false;
            this.chManagerClientAccess.CheckedChanged += new System.EventHandler(this.chTransactions_CheckedChanged);
            this.chManagerClientAccess.Click += new System.EventHandler(this.chTransactions_Click);
            // 
            // chFullAccess
            // 
            this.chFullAccess.AutoSize = true;
            this.chFullAccess.BackColor = System.Drawing.Color.Transparent;
            this.chFullAccess.Cursor = System.Windows.Forms.Cursors.No;
            this.chFullAccess.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.chFullAccess.Location = new System.Drawing.Point(20, 44);
            this.chFullAccess.Name = "chFullAccess";
            this.chFullAccess.Size = new System.Drawing.Size(202, 43);
            this.chFullAccess.TabIndex = 0;
            this.chFullAccess.Text = "Full Access";
            this.chFullAccess.UseVisualStyleBackColor = false;
            this.chFullAccess.Visible = false;
            this.chFullAccess.CheckedChanged += new System.EventHandler(this.chTransactions_CheckedChanged);
            this.chFullAccess.Click += new System.EventHandler(this.chTransactions_Click);
            // 
            // frmUserInfocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(870, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserInfocs";
            this.ShowInTaskbar = false;
            this.Text = "frmUserInfocs";
            this.Load += new System.EventHandler(this.frmUserInfocs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butnCancel;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label pnltitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chTransactions;
        private System.Windows.Forms.CheckBox chManageUsers;
        private System.Windows.Forms.CheckBox chManagerClientAccess;
        private System.Windows.Forms.CheckBox chFullAccess;
    }
}