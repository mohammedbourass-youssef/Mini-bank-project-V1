namespace Mini_Bank_Syatem
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.pnlButtonslesf = new System.Windows.Forms.Panel();
            this.btmOptions = new System.Windows.Forms.Button();
            this.btnAddnewUser = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlJumper = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlButtonslesf.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonslesf
            // 
            this.pnlButtonslesf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.pnlButtonslesf.Controls.Add(this.btmOptions);
            this.pnlButtonslesf.Controls.Add(this.btnAddnewUser);
            this.pnlButtonslesf.Controls.Add(this.btnUsers);
            this.pnlButtonslesf.Controls.Add(this.pnlJumper);
            this.pnlButtonslesf.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtonslesf.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonslesf.Name = "pnlButtonslesf";
            this.pnlButtonslesf.Size = new System.Drawing.Size(307, 694);
            this.pnlButtonslesf.TabIndex = 0;
            this.pnlButtonslesf.Click += new System.EventHandler(this.pnlButtonslesf_Click);
            this.pnlButtonslesf.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlButtonslesf_Paint);
            // 
            // btmOptions
            // 
            this.btmOptions.FlatAppearance.BorderSize = 0;
            this.btmOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmOptions.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmOptions.ForeColor = System.Drawing.Color.White;
            this.btmOptions.Image = ((System.Drawing.Image)(resources.GetObject("btmOptions.Image")));
            this.btmOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmOptions.Location = new System.Drawing.Point(12, 0);
            this.btmOptions.Name = "btmOptions";
            this.btmOptions.Size = new System.Drawing.Size(295, 66);
            this.btmOptions.TabIndex = 9;
            this.btmOptions.Tag = "Options";
            this.btmOptions.Text = "Options";
            this.btmOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmOptions.UseVisualStyleBackColor = true;
            this.btmOptions.Click += new System.EventHandler(this.btmOptions_Click);
            this.btmOptions.MouseEnter += new System.EventHandler(this.btmOptions_MouseEnter);
            this.btmOptions.MouseLeave += new System.EventHandler(this.btmOptions_MouseLeave);
            // 
            // btnAddnewUser
            // 
            this.btnAddnewUser.FlatAppearance.BorderSize = 0;
            this.btnAddnewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnewUser.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddnewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnewUser.Image")));
            this.btnAddnewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewUser.Location = new System.Drawing.Point(9, 310);
            this.btnAddnewUser.Name = "btnAddnewUser";
            this.btnAddnewUser.Size = new System.Drawing.Size(295, 66);
            this.btnAddnewUser.TabIndex = 7;
            this.btnAddnewUser.Tag = "Add New User";
            this.btnAddnewUser.Text = "Add New User";
            this.btnAddnewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddnewUser.UseVisualStyleBackColor = true;
            this.btnAddnewUser.Click += new System.EventHandler(this.btnAddnewClient_Click);
            this.btnAddnewUser.MouseEnter += new System.EventHandler(this.btnAddnewClient_MouseEnter);
            this.btnAddnewUser.MouseLeave += new System.EventHandler(this.btnAddnewClient_MouseLeave);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(12, 191);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(295, 66);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Tag = "Users List";
            this.btnUsers.Text = "Users List";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnAllClients_Click);
            this.btnUsers.MouseEnter += new System.EventHandler(this.btnAddnewClient_MouseEnter);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnAddnewClient_MouseLeave);
            // 
            // pnlJumper
            // 
            this.pnlJumper.BackColor = System.Drawing.Color.White;
            this.pnlJumper.Location = new System.Drawing.Point(3, 191);
            this.pnlJumper.Name = "pnlJumper";
            this.pnlJumper.Size = new System.Drawing.Size(8, 66);
            this.pnlJumper.TabIndex = 5;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(947, 694);
            this.pnlBody.TabIndex = 0;
            this.pnlBody.Click += new System.EventHandler(this.pnlBody_Click);
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 694);
            this.ControlBox = false;
            this.Controls.Add(this.pnlButtonslesf);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUsers";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.pnlButtonslesf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonslesf;
        private System.Windows.Forms.Button btmOptions;
        private System.Windows.Forms.Button btnAddnewUser;
        public System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel pnlJumper;
        private System.Windows.Forms.Panel pnlBody;
    }
}