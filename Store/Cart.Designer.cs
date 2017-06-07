namespace Store
{
    partial class Cart
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
            this.txtbx_cart = new System.Windows.Forms.TextBox();
            this.bttn_emptyCart = new System.Windows.Forms.Button();
            this.bttn_purchaseCart = new System.Windows.Forms.Button();
            this.lbl_purchaseWarning = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_cart
            // 
            this.txtbx_cart.Location = new System.Drawing.Point(23, 42);
            this.txtbx_cart.Multiline = true;
            this.txtbx_cart.Name = "txtbx_cart";
            this.txtbx_cart.ReadOnly = true;
            this.txtbx_cart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_cart.Size = new System.Drawing.Size(240, 128);
            this.txtbx_cart.TabIndex = 0;
            // 
            // bttn_emptyCart
            // 
            this.bttn_emptyCart.Location = new System.Drawing.Point(9, 207);
            this.bttn_emptyCart.Name = "bttn_emptyCart";
            this.bttn_emptyCart.Size = new System.Drawing.Size(86, 36);
            this.bttn_emptyCart.TabIndex = 1;
            this.bttn_emptyCart.Text = "Empty Cart";
            this.bttn_emptyCart.UseVisualStyleBackColor = true;
            this.bttn_emptyCart.Click += new System.EventHandler(this.bttn_emptyCart_Click);
            // 
            // bttn_purchaseCart
            // 
            this.bttn_purchaseCart.Location = new System.Drawing.Point(189, 207);
            this.bttn_purchaseCart.Name = "bttn_purchaseCart";
            this.bttn_purchaseCart.Size = new System.Drawing.Size(83, 36);
            this.bttn_purchaseCart.TabIndex = 2;
            this.bttn_purchaseCart.Text = "Purchase";
            this.bttn_purchaseCart.UseVisualStyleBackColor = true;
            this.bttn_purchaseCart.Click += new System.EventHandler(this.bttn_purchaseCart_Click);
            // 
            // lbl_purchaseWarning
            // 
            this.lbl_purchaseWarning.AutoSize = true;
            this.lbl_purchaseWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_purchaseWarning.Location = new System.Drawing.Point(76, 246);
            this.lbl_purchaseWarning.Name = "lbl_purchaseWarning";
            this.lbl_purchaseWarning.Size = new System.Drawing.Size(211, 13);
            this.lbl_purchaseWarning.TabIndex = 3;
            this.lbl_purchaseWarning.Text = "Clicking Purchase will charge your Account";
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
            this.menuStrip1.TabIndex = 4;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back to Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_purchaseWarning);
            this.Controls.Add(this.bttn_purchaseCart);
            this.Controls.Add(this.bttn_emptyCart);
            this.Controls.Add(this.txtbx_cart);
            this.Name = "Cart";
            this.Text = "Cart";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_cart;
        private System.Windows.Forms.Button bttn_emptyCart;
        private System.Windows.Forms.Button bttn_purchaseCart;
        private System.Windows.Forms.Label lbl_purchaseWarning;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCartToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}