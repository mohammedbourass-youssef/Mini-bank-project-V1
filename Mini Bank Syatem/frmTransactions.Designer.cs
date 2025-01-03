namespace Mini_Bank_Syatem
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btmOptions = new System.Windows.Forms.Button();
            this.pnlJumper = new System.Windows.Forms.Panel();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnAllClientsWithTotalBalance = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnDeposit);
            this.pnlMenu.Controls.Add(this.btmOptions);
            this.pnlMenu.Controls.Add(this.pnlJumper);
            this.pnlMenu.Controls.Add(this.btnTransactions);
            this.pnlMenu.Controls.Add(this.btnWithdraw);
            this.pnlMenu.Controls.Add(this.btnAllClientsWithTotalBalance);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(307, 694);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(10, 343);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(295, 66);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Tag = "Deposit";
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            this.btnDeposit.MouseEnter += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseEnter);
            this.btnDeposit.MouseLeave += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseLeave);
            // 
            // btmOptions
            // 
            this.btmOptions.FlatAppearance.BorderSize = 0;
            this.btmOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmOptions.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmOptions.ForeColor = System.Drawing.Color.White;
            this.btmOptions.Image = ((System.Drawing.Image)(resources.GetObject("btmOptions.Image")));
            this.btmOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmOptions.Location = new System.Drawing.Point(12, 3);
            this.btmOptions.Name = "btmOptions";
            this.btmOptions.Size = new System.Drawing.Size(295, 66);
            this.btmOptions.TabIndex = 10;
            this.btmOptions.Tag = "Options";
            this.btmOptions.Text = "Options";
            this.btmOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmOptions.UseVisualStyleBackColor = true;
            this.btmOptions.Click += new System.EventHandler(this.btmOptions_Click);
            // 
            // pnlJumper
            // 
            this.pnlJumper.BackColor = System.Drawing.Color.White;
            this.pnlJumper.Location = new System.Drawing.Point(2, 165);
            this.pnlJumper.Name = "pnlJumper";
            this.pnlJumper.Size = new System.Drawing.Size(8, 66);
            this.pnlJumper.TabIndex = 9;
            // 
            // btnTransactions
            // 
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(10, 432);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(295, 66);
            this.btnTransactions.TabIndex = 8;
            this.btnTransactions.Tag = "your Transactions";
            this.btnTransactions.Text = "your Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            this.btnTransactions.MouseEnter += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseEnter);
            this.btnTransactions.MouseLeave += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseLeave);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Image")));
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(10, 254);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(295, 66);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Tag = "Withdraw";
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            this.btnWithdraw.MouseEnter += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseEnter);
            this.btnWithdraw.MouseLeave += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseLeave);
            // 
            // btnAllClientsWithTotalBalance
            // 
            this.btnAllClientsWithTotalBalance.FlatAppearance.BorderSize = 0;
            this.btnAllClientsWithTotalBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllClientsWithTotalBalance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllClientsWithTotalBalance.ForeColor = System.Drawing.Color.White;
            this.btnAllClientsWithTotalBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnAllClientsWithTotalBalance.Image")));
            this.btnAllClientsWithTotalBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllClientsWithTotalBalance.Location = new System.Drawing.Point(10, 165);
            this.btnAllClientsWithTotalBalance.Name = "btnAllClientsWithTotalBalance";
            this.btnAllClientsWithTotalBalance.Size = new System.Drawing.Size(295, 66);
            this.btnAllClientsWithTotalBalance.TabIndex = 6;
            this.btnAllClientsWithTotalBalance.Tag = "Total Blance";
            this.btnAllClientsWithTotalBalance.Text = "Total Blance";
            this.btnAllClientsWithTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllClientsWithTotalBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllClientsWithTotalBalance.UseVisualStyleBackColor = true;
            this.btnAllClientsWithTotalBalance.Click += new System.EventHandler(this.btnAllClientsWithTotalBalance_Click);
            this.btnAllClientsWithTotalBalance.MouseEnter += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseEnter);
            this.btnAllClientsWithTotalBalance.MouseLeave += new System.EventHandler(this.btnAllClientsWithTotalBalance_MouseLeave);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(947, 694);
            this.pnlBody.TabIndex = 1;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(947, 694);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btmOptions;
        private System.Windows.Forms.Panel pnlJumper;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnWithdraw;
        public System.Windows.Forms.Button btnAllClientsWithTotalBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel pnlBody;
    }
}