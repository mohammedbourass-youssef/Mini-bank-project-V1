namespace Mini_Bank_Syatem
{
    partial class frmManageClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageClients));
            this.pnlbody = new System.Windows.Forms.Panel();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.btmOptions = new System.Windows.Forms.Button();
            this.pnlJumper = new System.Windows.Forms.Panel();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnAddnewClient = new System.Windows.Forms.Button();
            this.btnAllClients = new System.Windows.Forms.Button();
            this.pnlheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbody
            // 
            this.pnlbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbody.Location = new System.Drawing.Point(307, 0);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(640, 694);
            this.pnlbody.TabIndex = 0;
            this.pnlbody.Click += new System.EventHandler(this.pnlbody_Click);
            this.pnlbody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbody_Paint);
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.pnlheader.Controls.Add(this.btmOptions);
            this.pnlheader.Controls.Add(this.pnlJumper);
            this.pnlheader.Controls.Add(this.btnFindClient);
            this.pnlheader.Controls.Add(this.btnAddnewClient);
            this.pnlheader.Controls.Add(this.btnAllClients);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(307, 694);
            this.pnlheader.TabIndex = 2;
            this.pnlheader.Click += new System.EventHandler(this.pnlheader_Click);
            this.pnlheader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlheader_Paint);
            // 
            // btmOptions
            // 
            this.btmOptions.FlatAppearance.BorderSize = 0;
            this.btmOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmOptions.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmOptions.ForeColor = System.Drawing.Color.White;
            this.btmOptions.Image = ((System.Drawing.Image)(resources.GetObject("btmOptions.Image")));
            this.btmOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmOptions.Location = new System.Drawing.Point(9, 3);
            this.btmOptions.Name = "btmOptions";
            this.btmOptions.Size = new System.Drawing.Size(295, 66);
            this.btmOptions.TabIndex = 5;
            this.btmOptions.Tag = "Options";
            this.btmOptions.Text = "Options";
            this.btmOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmOptions.UseVisualStyleBackColor = true;
            this.btmOptions.Click += new System.EventHandler(this.btmOptions_Click_1);
            this.btmOptions.MouseEnter += new System.EventHandler(this.btmOptions_MouseEnter);
            this.btmOptions.MouseLeave += new System.EventHandler(this.btmOptions_MouseLeave);
            // 
            // pnlJumper
            // 
            this.pnlJumper.BackColor = System.Drawing.Color.White;
            this.pnlJumper.Location = new System.Drawing.Point(1, 162);
            this.pnlJumper.Name = "pnlJumper";
            this.pnlJumper.Size = new System.Drawing.Size(8, 66);
            this.pnlJumper.TabIndex = 4;
            // 
            // btnFindClient
            // 
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.White;
            this.btnFindClient.Image = ((System.Drawing.Image)(resources.GetObject("btnFindClient.Image")));
            this.btnFindClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.Location = new System.Drawing.Point(9, 358);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(295, 66);
            this.btnFindClient.TabIndex = 3;
            this.btnFindClient.Tag = "FindClient";
            this.btnFindClient.Text = "FindClient";
            this.btnFindClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click_1);
            this.btnFindClient.MouseEnter += new System.EventHandler(this.btnAllClients_MouseEnter);
            this.btnFindClient.MouseLeave += new System.EventHandler(this.btnAllClients_MouseLeave);
            // 
            // btnAddnewClient
            // 
            this.btnAddnewClient.FlatAppearance.BorderSize = 0;
            this.btnAddnewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnewClient.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewClient.ForeColor = System.Drawing.Color.White;
            this.btnAddnewClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnewClient.Image")));
            this.btnAddnewClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewClient.Location = new System.Drawing.Point(9, 260);
            this.btnAddnewClient.Name = "btnAddnewClient";
            this.btnAddnewClient.Size = new System.Drawing.Size(295, 66);
            this.btnAddnewClient.TabIndex = 2;
            this.btnAddnewClient.Tag = "Add New Client";
            this.btnAddnewClient.Text = "Add New Client";
            this.btnAddnewClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddnewClient.UseVisualStyleBackColor = true;
            this.btnAddnewClient.Click += new System.EventHandler(this.btnAddnewClient_Click);
            this.btnAddnewClient.MouseEnter += new System.EventHandler(this.btnAllClients_MouseEnter);
            this.btnAddnewClient.MouseLeave += new System.EventHandler(this.btnAllClients_MouseLeave);
            // 
            // btnAllClients
            // 
            this.btnAllClients.FlatAppearance.BorderSize = 0;
            this.btnAllClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllClients.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllClients.ForeColor = System.Drawing.Color.White;
            this.btnAllClients.Image = ((System.Drawing.Image)(resources.GetObject("btnAllClients.Image")));
            this.btnAllClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllClients.Location = new System.Drawing.Point(9, 162);
            this.btnAllClients.Name = "btnAllClients";
            this.btnAllClients.Size = new System.Drawing.Size(295, 66);
            this.btnAllClients.TabIndex = 1;
            this.btnAllClients.Tag = "Clients List";
            this.btnAllClients.Text = "Clients List";
            this.btnAllClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllClients.UseVisualStyleBackColor = true;
            this.btnAllClients.Click += new System.EventHandler(this.btnAllClients_Click);
            this.btnAllClients.MouseEnter += new System.EventHandler(this.btnAllClients_MouseEnter);
            this.btnAllClients.MouseLeave += new System.EventHandler(this.btnAllClients_MouseLeave);
            // 
            // frmManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 694);
            this.ControlBox = false;
            this.Controls.Add(this.pnlbody);
            this.Controls.Add(this.pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageClients";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmManageClients_Load);
            this.pnlheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbody;
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Button btnAddnewClient;
        public System.Windows.Forms.Button btnAllClients;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btmOptions;
        private System.Windows.Forms.Panel pnlJumper;
       
    }
}