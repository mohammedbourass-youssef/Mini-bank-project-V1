namespace Mini_Bank_Syatem
{
    partial class frmEchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEchange));
            this.gbfrom = new System.Windows.Forms.GroupBox();
            this.gbto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstCurrencyCode = new System.Windows.Forms.Label();
            this.lblSecondCurrencyCode = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbFinalResult = new System.Windows.Forms.TextBox();
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbfrom
            // 
            this.gbfrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfrom.Location = new System.Drawing.Point(12, 12);
            this.gbfrom.Name = "gbfrom";
            this.gbfrom.Size = new System.Drawing.Size(683, 275);
            this.gbfrom.TabIndex = 17;
            this.gbfrom.TabStop = false;
            this.gbfrom.Text = "From";
            // 
            // gbto
            // 
            this.gbto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbto.Location = new System.Drawing.Point(16, 382);
            this.gbto.Name = "gbto";
            this.gbto.Size = new System.Drawing.Size(697, 281);
            this.gbto.TabIndex = 18;
            this.gbto.TabStop = false;
            this.gbto.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Amount in ";
            // 
            // lblFirstCurrencyCode
            // 
            this.lblFirstCurrencyCode.AutoSize = true;
            this.lblFirstCurrencyCode.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstCurrencyCode.Location = new System.Drawing.Point(160, 290);
            this.lblFirstCurrencyCode.Name = "lblFirstCurrencyCode";
            this.lblFirstCurrencyCode.Size = new System.Drawing.Size(55, 23);
            this.lblFirstCurrencyCode.TabIndex = 27;
            this.lblFirstCurrencyCode.Text = "USD";
            // 
            // lblSecondCurrencyCode
            // 
            this.lblSecondCurrencyCode.AutoSize = true;
            this.lblSecondCurrencyCode.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondCurrencyCode.Location = new System.Drawing.Point(519, 303);
            this.lblSecondCurrencyCode.Name = "lblSecondCurrencyCode";
            this.lblSecondCurrencyCode.Size = new System.Drawing.Size(59, 23);
            this.lblSecondCurrencyCode.TabIndex = 26;
            this.lblSecondCurrencyCode.Text = "MAD";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(36, 290);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(118, 23);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Amount in ";
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbAmount.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbAmount.ForeColor = System.Drawing.Color.White;
            this.tbAmount.Location = new System.Drawing.Point(12, 329);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(305, 47);
            this.tbAmount.TabIndex = 23;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // tbFinalResult
            // 
            this.tbFinalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.tbFinalResult.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbFinalResult.ForeColor = System.Drawing.Color.White;
            this.tbFinalResult.Location = new System.Drawing.Point(390, 329);
            this.tbFinalResult.Name = "tbFinalResult";
            this.tbFinalResult.ReadOnly = true;
            this.tbFinalResult.Size = new System.Drawing.Size(305, 47);
            this.tbFinalResult.TabIndex = 24;
            // 
            // btnFrom
            // 
            this.btnFrom.FlatAppearance.BorderSize = 0;
            this.btnFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrom.ForeColor = System.Drawing.Color.White;
            this.btnFrom.Image = ((System.Drawing.Image)(resources.GetObject("btnFrom.Image")));
            this.btnFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrom.Location = new System.Drawing.Point(701, 23);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(149, 54);
            this.btnFrom.TabIndex = 29;
            this.btnFrom.Tag = "";
            this.btnFrom.Text = "SELECT";
            this.btnFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // btnto
            // 
            this.btnto.FlatAppearance.BorderSize = 0;
            this.btnto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnto.ForeColor = System.Drawing.Color.White;
            this.btnto.Image = ((System.Drawing.Image)(resources.GetObject("btnto.Image")));
            this.btnto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnto.Location = new System.Drawing.Point(719, 397);
            this.btnto.Name = "btnto";
            this.btnto.Size = new System.Drawing.Size(131, 66);
            this.btnto.TabIndex = 30;
            this.btnto.Tag = "";
            this.btnto.Text = "SELECT";
            this.btnto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnto.UseVisualStyleBackColor = true;
            this.btnto.Click += new System.EventHandler(this.btnto_Click);
            // 
            // frmEchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(123)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(855, 667);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.btnto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstCurrencyCode);
            this.Controls.Add(this.lblSecondCurrencyCode);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbFinalResult);
            this.Controls.Add(this.gbto);
            this.Controls.Add(this.gbfrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEchange";
            this.Text = "frmEchange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbfrom;
        private System.Windows.Forms.GroupBox gbto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstCurrencyCode;
        private System.Windows.Forms.Label lblSecondCurrencyCode;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbFinalResult;
        public System.Windows.Forms.Button btnFrom;
        public System.Windows.Forms.Button btnto;
    }
}