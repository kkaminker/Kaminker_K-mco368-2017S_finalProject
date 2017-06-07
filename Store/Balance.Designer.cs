namespace Store
{
    partial class Balance
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
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_pay = new System.Windows.Forms.Label();
            this.txtbx_toPay = new System.Windows.Forms.TextBox();
            this.bttn_payBalance = new System.Windows.Forms.Button();
            this.bttn_payFullBalance = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(57, 50);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(35, 13);
            this.lbl_balance.TabIndex = 0;
            this.lbl_balance.Text = "label1";
            // 
            // lbl_pay
            // 
            this.lbl_pay.AutoSize = true;
            this.lbl_pay.Location = new System.Drawing.Point(12, 138);
            this.lbl_pay.Name = "lbl_pay";
            this.lbl_pay.Size = new System.Drawing.Size(43, 13);
            this.lbl_pay.TabIndex = 1;
            this.lbl_pay.Text = "Amount";
            // 
            // txtbx_toPay
            // 
            this.txtbx_toPay.Location = new System.Drawing.Point(60, 134);
            this.txtbx_toPay.Name = "txtbx_toPay";
            this.txtbx_toPay.Size = new System.Drawing.Size(74, 20);
            this.txtbx_toPay.TabIndex = 2;
            // 
            // bttn_payBalance
            // 
            this.bttn_payBalance.Location = new System.Drawing.Point(177, 204);
            this.bttn_payBalance.Name = "bttn_payBalance";
            this.bttn_payBalance.Size = new System.Drawing.Size(84, 36);
            this.bttn_payBalance.TabIndex = 3;
            this.bttn_payBalance.Text = "Submit Payment";
            this.bttn_payBalance.UseVisualStyleBackColor = true;
            this.bttn_payBalance.Click += new System.EventHandler(this.bttn_payBalance_Click);
            // 
            // bttn_payFullBalance
            // 
            this.bttn_payFullBalance.Location = new System.Drawing.Point(177, 126);
            this.bttn_payFullBalance.Name = "bttn_payFullBalance";
            this.bttn_payFullBalance.Size = new System.Drawing.Size(84, 36);
            this.bttn_payFullBalance.TabIndex = 4;
            this.bttn_payFullBalance.Text = "Pay Full Balance";
            this.bttn_payFullBalance.UseVisualStyleBackColor = true;
            this.bttn_payFullBalance.Click += new System.EventHandler(this.bttn_payFullBalance_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.viewItemsToolStripMenuItem,
            this.viewCartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPurchasesToolStripMenuItem,
            this.checkBalanceToolStripMenuItem});
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // viewPurchasesToolStripMenuItem
            // 
            this.viewPurchasesToolStripMenuItem.Name = "viewPurchasesToolStripMenuItem";
            this.viewPurchasesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.viewPurchasesToolStripMenuItem.Text = "View Purchases";
            this.viewPurchasesToolStripMenuItem.Click += new System.EventHandler(this.viewPurchasesToolStripMenuItem_Click);
            // 
            // checkBalanceToolStripMenuItem
            // 
            this.checkBalanceToolStripMenuItem.Name = "checkBalanceToolStripMenuItem";
            this.checkBalanceToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.checkBalanceToolStripMenuItem.Text = "My Balance";
            this.checkBalanceToolStripMenuItem.Click += new System.EventHandler(this.checkBalanceToolStripMenuItem_Click);
            // 
            // viewItemsToolStripMenuItem
            // 
            this.viewItemsToolStripMenuItem.Name = "viewItemsToolStripMenuItem";
            this.viewItemsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.viewItemsToolStripMenuItem.Text = "View Items";
            this.viewItemsToolStripMenuItem.Click += new System.EventHandler(this.viewItemsToolStripMenuItem_Click);
            // 
            // viewCartToolStripMenuItem
            // 
            this.viewCartToolStripMenuItem.Name = "viewCartToolStripMenuItem";
            this.viewCartToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewCartToolStripMenuItem.Text = "View Cart";
            this.viewCartToolStripMenuItem.Click += new System.EventHandler(this.viewCartToolStripMenuItem_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bttn_payFullBalance);
            this.Controls.Add(this.bttn_payBalance);
            this.Controls.Add(this.txtbx_toPay);
            this.Controls.Add(this.lbl_pay);
            this.Controls.Add(this.lbl_balance);
            this.Name = "Balance";
            this.Text = "Balance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_pay;
        private System.Windows.Forms.TextBox txtbx_toPay;
        private System.Windows.Forms.Button bttn_payBalance;
        private System.Windows.Forms.Button bttn_payFullBalance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCartToolStripMenuItem;
    }
}