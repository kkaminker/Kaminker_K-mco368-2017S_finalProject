using System;
using System.Collections;
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
    public partial class ItemDetails : Form
    {
       
        public ItemDetails()
        {
            InitializeComponent();
            lbl_errorBalance.Visible = false;
           
        }

        private void ItemDetails_Load(object sender, EventArgs e)
        {

        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainStoreFrame().Show();
        }

        private void bttn_addToCart_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
           
            //check won't exceed balance
         
            
            var balance = dc.GetTable<account>().Where(b => b.custId == CustInfo.customerID).First().Balance;

            Decimal orderedQuantity;
            var result = Decimal.TryParse(txtbx_quant.Text, out orderedQuantity);
         
            Product itemToAdd = dc.GetTable<Product>().Where(it => it.Pcode.Equals(lbl_code.Text)).First();
            if (!result)
            {
                lbl_errorBalance.Text = "Please enter a quantity greater than 0";
                lbl_errorBalance.Visible = true;
            }
          

           else if ( (balance+ orderedQuantity * Decimal.Parse(lbl_price.Text)).CompareTo(Program.maxBalance) <= 0 && orderedQuantity>0 && orderedQuantity <= itemToAdd.quantity)
            {

               // Product itemToAdd = dc.GetTable<Product>().Where(it => it.Pcode.Equals(lbl_code.Text)).First();
                cartItem item = new cartItem
                {
                    Pcode = itemToAdd.Pcode,
                    description = itemToAdd.description,
                    price = itemToAdd.price * decimal.Parse(txtbx_quant.Text),
                    quant_ordered = int.Parse(txtbx_quant.Text)

                };

                dc.cartItems.InsertOnSubmit(item);
                dc.SubmitChanges();
    
               
                

                this.Hide();
                new Cart().Show();
                   
                
            }
            else if (orderedQuantity > itemToAdd.quantity)
            {
                lbl_errorBalance.Text = "Sorry, this item is out of stock in the quantity ordered.";
                lbl_errorBalance.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(txtbx_quant.Text) || int.Parse(txtbx_quant.Text)<=0)
            {
                lbl_errorBalance.Text = "Please enter a quantity greater than 0";
                lbl_errorBalance.Visible = true;
            }
            else { lbl_errorBalance.Visible = true; }//show error message

         
          
        }

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Cart().Show();
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
    }
}
