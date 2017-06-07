namespace Store
{
    partial class MainStoreFrame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c_store_products = new Store.c_store_products();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Store.c_store_productsTableAdapters.ProductTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.c_storeDataSet = new Store.c_storeDataSet();
            this.productTableAdapter1 = new Store.c_storeDataSetTableAdapters.ProductTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_store_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.viewItemsToolStripMenuItem,
            this.viewCartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // c_store_products
            // 
            this.c_store_products.DataSetName = "c_store_products";
            this.c_store_products.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.c_store_products;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 282);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pcodeDataGridViewTextBoxColumn
            // 
            this.pcodeDataGridViewTextBoxColumn.DataPropertyName = "Pcode";
            this.pcodeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.pcodeDataGridViewTextBoxColumn.Name = "pcodeDataGridViewTextBoxColumn";
            this.pcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.c_storeDataSet;
            // 
            // c_storeDataSet
            // 
            this.c_storeDataSet.DataSetName = "c_storeDataSet";
            this.c_storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // MainStoreFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainStoreFrame";
            this.Text = "MainStoreFrame";
            this.Load += new System.EventHandler(this.MainStoreFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_store_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_storeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private c_store_products c_store_products;
        private System.Windows.Forms.BindingSource productBindingSource;
        private c_store_productsTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private c_storeDataSet c_storeDataSet;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private c_storeDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem viewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCartToolStripMenuItem;
    }
}