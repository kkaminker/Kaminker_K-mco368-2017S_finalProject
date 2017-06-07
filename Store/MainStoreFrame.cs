using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class MainStoreFrame : Form
    {
        public MainStoreFrame()
        {
            InitializeComponent();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Purchases().Show();
        }

        private void checkBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Balance().Show();
        }

        private void payBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainStoreFrame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c_storeDataSet.Product' table. 
            //You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.c_storeDataSet.Product);
            // TODO: This line of code loads data into the 'c_store_products.Product' table. 
            // You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.c_store_products.Product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            ItemDetails id = new ItemDetails();
            DataGridViewSelectedRowCollection dgv = dataGridView1.SelectedRows;
            id.lbl_code.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            id.lbl_desc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
            id.lbl_price.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            this.Close();
            id.Show();
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MainStoreFrame().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cart().Show();
        }
    }
}
