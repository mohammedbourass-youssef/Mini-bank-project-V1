namespace Mini_Bank_Syatem
{
    partial class frmBankSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankSystem));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnljumper = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCurrencies = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblButtonTitle = new System.Windows.Forms.Label();
            this.pnlChildProgram = new System.Windows.Forms.Panel();
            this.lblAccessDenied = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlChildProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnBack);
            this.pnlMenu.Controls.Add(this.pnljumper);
            this.pnlMenu.Controls.Add(this.btnCurrencies);
            this.pnlMenu.Controls.Add(this.btnTransactions);
            this.pnlMenu.Controls.Add(this.btnManageUsers);
            this.pnlMenu.Controls.Add(this.btnManageClients);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(297, 739);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 685);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(297, 54);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "LOGOUT";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnljumper
            // 
            this.pnljumper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.pnljumper.ForeColor = System.Drawing.Color.White;
            this.pnljumper.Location = new System.Drawing.Point(0, 416);
            this.pnljumper.Name = "pnljumper";
            this.pnljumper.Size = new System.Drawing.Size(307, 8);
            this.pnljumper.TabIndex = 5;
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.FlatAppearance.BorderSize = 0;
            this.btnCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencies.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencies.ForeColor = System.Drawing.Color.White;
            this.btnCurrencies.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrencies.Image")));
            this.btnCurrencies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrencies.Location = new System.Drawing.Point(0, 425);
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.Size = new System.Drawing.Size(297, 82);
            this.btnCurrencies.TabIndex = 4;
            this.btnCurrencies.Text = "Currencies";
            this.btnCurrencies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrencies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCurrencies.UseVisualStyleBackColor = true;
            this.btnCurrencies.BackColorChanged += new System.EventHandler(this.btnManageClients_BackColorChanged);
            this.btnCurrencies.Click += new System.EventHandler(this.btnCurrencies_Click);
            this.btnCurrencies.MouseEnter += new System.EventHandler(this.btnManageClients_MouseEnter);
            this.btnCurrencies.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btnTransactions
            // 
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(0, 333);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(297, 82);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.BackColorChanged += new System.EventHandler(this.btnManageClients_BackColorChanged);
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            this.btnTransactions.MouseEnter += new System.EventHandler(this.btnManageClients_MouseEnter);
            this.btnTransactions.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 243);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(297, 82);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.BackColorChanged += new System.EventHandler(this.btnManageClients_BackColorChanged);
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            this.btnManageUsers.MouseEnter += new System.EventHandler(this.btnManageClients_MouseEnter);
            this.btnManageUsers.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btnManageClients
            // 
            this.btnManageClients.FlatAppearance.BorderSize = 0;
            this.btnManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClients.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.ForeColor = System.Drawing.Color.White;
            this.btnManageClients.Image = ((System.Drawing.Image)(resources.GetObject("btnManageClients.Image")));
            this.btnManageClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageClients.Location = new System.Drawing.Point(0, 154);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(297, 82);
            this.btnManageClients.TabIndex = 1;
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageClients.UseVisualStyleBackColor = true;
            this.btnManageClients.BackColorChanged += new System.EventHandler(this.btnManageClients_BackColorChanged);
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            this.btnManageClients.MouseEnter += new System.EventHandler(this.btnManageClients_MouseEnter);
            this.btnManageClients.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.flowLayoutPanel1);
            this.pnlLogo.Controls.Add(this.lblusername);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(297, 101);
            this.pnlLogo.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 4);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(12, 65);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(93, 19);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "WELCOME ,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MINI BANK SYSTEM";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTitle.Controls.Add(this.lblButtonTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(297, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(947, 45);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblButtonTitle
            // 
            this.lblButtonTitle.AutoSize = true;
            this.lblButtonTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonTitle.ForeColor = System.Drawing.Color.White;
            this.lblButtonTitle.Location = new System.Drawing.Point(342, 4);
            this.lblButtonTitle.Name = "lblButtonTitle";
            this.lblButtonTitle.Size = new System.Drawing.Size(306, 38);
            this.lblButtonTitle.TabIndex = 1;
            this.lblButtonTitle.Text = "MINI BANK SYSTEM";
            this.lblButtonTitle.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // pnlChildProgram
            // 
            this.pnlChildProgram.Controls.Add(this.lblAccessDenied);
            this.pnlChildProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildProgram.Location = new System.Drawing.Point(297, 45);
            this.pnlChildProgram.Name = "pnlChildProgram";
            this.pnlChildProgram.Size = new System.Drawing.Size(947, 694);
            this.pnlChildProgram.TabIndex = 2;
            this.pnlChildProgram.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChildProgram_Paint);
            // 
            // lblAccessDenied
            // 
            this.lblAccessDenied.AutoSize = true;
            this.lblAccessDenied.BackColor = System.Drawing.Color.White;
            this.lblAccessDenied.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessDenied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccessDenied.Location = new System.Drawing.Point(220, 277);
            this.lblAccessDenied.Name = "lblAccessDenied";
            this.lblAccessDenied.Size = new System.Drawing.Size(518, 77);
            this.lblAccessDenied.TabIndex = 0;
            this.lblAccessDenied.Text = "ACCESS DENIED";
            this.lblAccessDenied.Visible = false;
            // 
            // frmBankSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 739);
            this.ControlBox = false;
            this.Controls.Add(this.pnlChildProgram);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBankSystem_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlChildProgram.ResumeLayout(false);
            this.pnlChildProgram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnCurrencies;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnljumper;
        private System.Windows.Forms.Label lblButtonTitle;
        private System.Windows.Forms.Panel pnlChildProgram;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAccessDenied;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblusername;
    }
}

