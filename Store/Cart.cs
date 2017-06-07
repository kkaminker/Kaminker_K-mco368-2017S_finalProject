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
    public partial class Cart : Form
    {
        

        public Cart()
        {

            InitializeComponent();
           
            StringBuilder sb = new StringBuilder();
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var itemsInCart = dc.GetTable<cartItem>();
            if (itemsInCart.Any())
            {
                foreach (var p in itemsInCart)
                {
                    sb.Append("\n" + p.Pcode + " " + p.description);
                    sb.AppendLine(p.quant_ordered + " $" +  p.price);
                }
                txtbx_cart.Text = sb.ToString();
            }
            else
            {
                txtbx_cart.Text = "Empty Cart";
            }
        }

        private void bttn_emptyCart_Click(object sender, EventArgs e)
        {
            txtbx_cart.Text = "Empty Cart";
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var itemsInCart = dc.GetTable<cartItem>();
            dc.cartItems.DeleteAllOnSubmit(itemsInCart);
            dc.SubmitChanges();
            
            
            
        }

        private void bttn_purchaseCart_Click(object sender, EventArgs e)
        {
           
            var lastInvoiceID = 0;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            //get customer's account id

            var accID = dc.GetTable<account>().Where(a => a.custId == CustInfo.customerID).First().AccountID;

            var itemsInCart = dc.GetTable<cartItem>();
             //NOTE: cartItem's price is the price of the item * the quantity ordered of that item
            //get total of items in cart 
            if (itemsInCart.Any())
            {
                decimal sumTotal = 0.0M;
                foreach (var p in itemsInCart)
                {
                    
                    sumTotal += p.price;
                }
                //get invoice id //this should be an identity
                var invoices = dc.GetTable<invoice>();
                               
                if (invoices.Any())
                {
                    lastInvoiceID = invoices.Max(a => a.invoiceID);
                }

                //make a new invoice
                invoice inv = new invoice
                {
                    accountID = accID,
                    totalPrice = sumTotal,
                    dateOrdered = DateTime.Today,
                    invoiceID = ++lastInvoiceID


                };
                dc.invoices.InsertOnSubmit(inv);
                dc.SubmitChanges();
                //update balance
                var userAccount = dc.GetTable<account>().Where(b => b.AccountID == inv.accountID).First();
                userAccount.Balance += sumTotal;
                dc.SubmitChanges();

                //make invoiceItems
                foreach (var p in itemsInCart)
                {
                    invoice_item inv_itm = new invoice_item
                    {
                        invoiceID = inv.invoiceID,
                        productID = p.Pcode,
                        quantityOrdered = p.quant_ordered,
                        price = p.price/p.quant_ordered
                    };
                    dc.invoice_items.InsertOnSubmit(inv_itm);
                    dc.SubmitChanges();

                    var productToDecrementQuant = dc.GetTable<Product>().Where(x => x.Pcode == p.Pcode).First();
                    productToDecrementQuant.quantity -= p.quant_ordered;
                }

                dc.cartItems.DeleteAllOnSubmit(itemsInCart);
                dc.SubmitChanges();
                txtbx_cart.Text = "Empty Cart";
                lbl_purchaseWarning.Text = "Thank you for your purchase. \nYour account has been charged.";
            }//if cartItems.Any()

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

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainStoreFrame().Show();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Purchases().Show();
        }

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cart().Show();
        }
    }
}
