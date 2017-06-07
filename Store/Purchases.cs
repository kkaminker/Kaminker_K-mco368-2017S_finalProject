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
    public partial class Purchases : Form
    {
        private DateTime? startDate = null;
        private DateTime? endDate = null;
        public Purchases()
        {
            InitializeComponent();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext dc = new DataClasses1DataContext();
            //get this customer's invoices
            var custInvoices = from a in dc.GetTable<account>()
                               where a.custId == CustInfo.customerID
                               join custInvoice in dc.GetTable<invoice>() on a.AccountID equals custInvoice.accountID
                               select custInvoice;

            //get all his ordered products
            var orderedProducts = from inv in dc.GetTable<invoice>()
                                  where inv.accountID == custInvoices.First().accountID
                                  join order in dc.GetTable<invoice_item>() on inv.invoiceID equals order.invoiceID
                                  select order;

            //if filtering by price
            if (!String.IsNullOrWhiteSpace(txtbx_priceFrom.Text) && !String.IsNullOrWhiteSpace(txtbx_priceTo.Text))
            {
               
                var startPrice = Decimal.Parse(txtbx_priceFrom.Text);
                var endPrice = Decimal.Parse(txtbx_priceTo.Text);
                var priceFilteredInvoices = custInvoices.Where(x => x.totalPrice >= startPrice && x.totalPrice <= endPrice);
                var ItemsPriceFiltered = from filteredInvoice in priceFilteredInvoices
                                         join prod in orderedProducts on filteredInvoice.invoiceID equals prod.invoiceID
                                         select prod;
                var priceFilteredItemDetails = from it in ItemsPriceFiltered
                                               join prod in dc.GetTable<Product>() on it.productID equals prod.Pcode
                                               select new { it.invoiceID, prod.Pcode, prod.description, it.quantityOrdered, Price = it.quantityOrdered * prod.price };
                StringBuilder sb = new StringBuilder();
                foreach(var prod in priceFilteredItemDetails)
                {
                    sb.AppendLine(prod.invoiceID + "    " + prod.Pcode + "    " + prod.description + "    " + prod.quantityOrdered + "    $" + prod.Price);
                }
                txtbx_purchases.Visible = true;
                txtbx_purchases.Text = sb.ToString();

            }
            //if filtering by date
            else if (startDate != null && endDate != null)
            {
                var dateFilteredInvoices = custInvoices.Where(x => x.dateOrdered >= startDate && x.dateOrdered <= endDate);
                var ItemsDateFiltered = from filteredItem in orderedProducts
                                        join filteredInvoice in dateFilteredInvoices on filteredItem.invoiceID equals filteredInvoice.invoiceID
                                        select filteredItem;
                var dateFilteredItemDetails= from it in ItemsDateFiltered
                                             join prod in dc.GetTable<Product>() on it.productID equals prod.Pcode
                                             join inv in dateFilteredInvoices on it.invoiceID equals inv.invoiceID
                                             select new { it.invoiceID, inv.dateOrdered,prod.Pcode, prod.description, it.quantityOrdered, Price = it.quantityOrdered * prod.price };
                //TODO: display ItemsDateFiltered
                StringBuilder sb = new StringBuilder();
                foreach (var prod in dateFilteredItemDetails)
                {
                    sb.AppendLine(prod.invoiceID + "    " + prod.Pcode + "    " +
                        prod.description + "    " + prod.quantityOrdered + "    $" + prod.Price+"    "+prod.dateOrdered);
                }
                txtbx_purchases.Visible = true;
                txtbx_purchases.Text = sb.ToString();

            }
            else //no valid filter show all
            {
                
                showAllPurchases();
            }
            

        }
        private void showAllPurchases()
        {
            StringBuilder sb = new StringBuilder();
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var orderedProducts = (from a in dc.GetTable<account>()
                                   where a.custId == CustInfo.customerID
                                   join custInvoice in dc.GetTable<invoice>() on a.AccountID equals custInvoice.accountID
                                   join order in dc.GetTable<invoice_item>() on custInvoice.invoiceID equals order.invoiceID
                                   select order).OrderBy(x=>x.invoiceID);
                                                 //get all his ordered products

     
            var orderedProductDetails = (from op in orderedProducts
                                         join p in dc.GetTable<Product>() on op.productID equals p.Pcode
                                         select new {
                                             op.invoiceID,
                                             op.productID,
                                             p.description,
                                             op.quantityOrdered,
                                             Price = op.quantityOrdered * op.price });//.GroupBy(x=>x.invoiceID);
            foreach (var prchs in orderedProductDetails)
            {
                sb.AppendLine(prchs.invoiceID + "    " + prchs.productID + "    " + prchs.description +
                    "    " + prchs.quantityOrdered + "    $" + prchs.Price);
            }
            
            txtbx_purchases.Visible = true;
            txtbx_purchases.Text = sb.ToString();

        }
     
        private void clndr_from_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void clndr_from_DateSelected(object sender, DateRangeEventArgs e)
        {
            startDate=e.Start;
        }

        private void clndr_endDate_DateSelected(object sender, DateRangeEventArgs e)
        {
           endDate= e.Start;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showAllPurchases();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Purchases().Show();
        }

        private void checkBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Balance().Show();
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainStoreFrame().Show();
        }

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cart().Show();
        }
    }
}
