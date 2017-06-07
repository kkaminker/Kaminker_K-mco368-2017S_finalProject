namespace Store
{
    partial class ItemDetails
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
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.bttn_addToCart = new System.Windows.Forms.Button();
            this.lbl_quant = new System.Windows.Forms.Label();
            this.txtbx_quant = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_errorBalance = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(14, 37);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(70, 26);
            this.lbl_desc.TabIndex = 0;
            this.lbl_desc.Text = "label1";
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.Location = new System.Drawing.Point(16, 72);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(41, 15);
            this.lbl_code.TabIndex = 1;
            this.lbl_code.Text = "label1";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(15, 128);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(51, 20);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "label1";
            // 
            // bttn_addToCart
            // 
            this.bttn_addToCart.Location = new System.Drawing.Point(120, 202);
            this.bttn_addToCart.Name = "bttn_addToCart";
            this.bttn_addToCart.Size = new System.Drawing.Size(99, 34);
            this.bttn_addToCart.TabIndex = 3;
            this.bttn_addToCart.Text = "Add to Cart";
            this.bttn_addToCart.UseVisualStyleBackColor = true;
            this.bttn_addToCart.Click += new System.EventHandler(this.bttn_addToCart_Click);
            // 
            // lbl_quant
            // 
            this.lbl_quant.AutoSize = true;
            this.lbl_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quant.Location = new System.Drawing.Point(34, 164);
            this.lbl_quant.Name = "lbl_quant";
            this.lbl_quant.Size = new System.Drawing.Size(65, 17);
            this.lbl_quant.TabIndex = 4;
            this.lbl_quant.Text = "Quantity:";
            // 
            // txtbx_quant
            // 
            this.txtbx_quant.Location = new System.Drawing.Point(105, 163);
            this.txtbx_quant.Name = "txtbx_quant";
            this.txtbx_quant.Size = new System.Drawing.Size(58, 20);
            this.txtbx_quant.TabIndex = 5;
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
            this.menuStrip1.TabIndex = 7;
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
            // lbl_errorBalance
            // 
            this.lbl_errorBalance.AutoSize = true;
            this.lbl_errorBalance.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorBalance.Location = new System.Drawing.Point(102, 239);
            this.lbl_errorBalance.Name = "lbl_errorBalance";
            this.lbl_errorBalance.Size = new System.Drawing.Size(165, 13);
            this.lbl_errorBalance.TabIndex = 8;
            this.lbl_errorBalance.Text = "Error: Exceeds Maximum Balance";
            this.lbl_errorBalance.Visible = false;
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_errorBalance);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtbx_quant);
            this.Controls.Add(this.lbl_quant);
            this.Controls.Add(this.bttn_addToCart);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.lbl_desc);
            this.Name = "ItemDetails";
            this.Text = "ItemDetails";
            this.Load += new System.EventHandler(this.ItemDetails_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_desc;
        
        public System.Windows.Forms.Label lbl_code;
        public System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button bttn_addToCart;
        private System.Windows.Forms.Label lbl_quant;
        public System.Windows.Forms.TextBox txtbx_quant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_errorBalance;
        private System.Windows.Forms.ToolStripMenuItem viewCartToolStripMenuItem;
    }
}