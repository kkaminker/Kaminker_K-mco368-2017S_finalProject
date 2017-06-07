namespace Store
{
    partial class Purchases
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
            this.txtbx_purchases = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_priceFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_priceTo = new System.Windows.Forms.TextBox();
            this.clndr_from = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clndr_endDate = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_purchases
            // 
            this.txtbx_purchases.Location = new System.Drawing.Point(326, 265);
            this.txtbx_purchases.Multiline = true;
            this.txtbx_purchases.Name = "txtbx_purchases";
            this.txtbx_purchases.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbx_purchases.Size = new System.Drawing.Size(498, 168);
            this.txtbx_purchases.TabIndex = 0;
            this.txtbx_purchases.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price Range:";
            // 
            // txtbx_priceFrom
            // 
            this.txtbx_priceFrom.Location = new System.Drawing.Point(105, 73);
            this.txtbx_priceFrom.Name = "txtbx_priceFrom";
            this.txtbx_priceFrom.Size = new System.Drawing.Size(39, 20);
            this.txtbx_priceFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "---";
            // 
            // txtbx_priceTo
            // 
            this.txtbx_priceTo.Location = new System.Drawing.Point(172, 73);
            this.txtbx_priceTo.Name = "txtbx_priceTo";
            this.txtbx_priceTo.Size = new System.Drawing.Size(39, 20);
            this.txtbx_priceTo.TabIndex = 5;
            // 
            // clndr_from
            // 
            this.clndr_from.Location = new System.Drawing.Point(350, 92);
            this.clndr_from.MaxSelectionCount = 1;
            this.clndr_from.Name = "clndr_from";
            this.clndr_from.TabIndex = 6;
            this.clndr_from.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.clndr_from_DateChanged);
            this.clndr_from.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.clndr_from_DateSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "OR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Range";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.viewItemsToolStripMenuItem,
            this.viewCartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 13;
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
            // clndr_endDate
            // 
            this.clndr_endDate.Location = new System.Drawing.Point(607, 91);
            this.clndr_endDate.MaxSelectionCount = 1;
            this.clndr_endDate.Name = "clndr_endDate";
            this.clndr_endDate.TabIndex = 14;
            this.clndr_endDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.clndr_endDate_DateSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "From:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "View All Purchases";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clndr_endDate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clndr_from);
            this.Controls.Add(this.txtbx_priceTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_priceFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_purchases);
            this.Name = "Purchases";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Purchases_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_purchases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_priceFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_priceTo;
        private System.Windows.Forms.MonthCalendar clndr_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCartToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar clndr_endDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}