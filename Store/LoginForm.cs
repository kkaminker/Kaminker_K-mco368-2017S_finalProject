using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //TODO: the following should be when application is exited
            //To ensure that cart data does not stick around between users
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var itemsInCart = dc.GetTable<cartItem>();
            if (itemsInCart.Any()) {
                dc.cartItems.DeleteAllOnSubmit(itemsInCart);
                dc.SubmitChanges();
            }
         
        }


        private void bttnLogin_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            
            var loginExists = dc.GetTable<account>().Any(x => x.CustPassword == txtbxPassword.Text && x.Username == txtbxUsername.Text);
            if (loginExists)
            {
                //update the customerID
                CustInfo.customerID = dc.GetTable<account>().First(x => x.CustPassword == txtbxPassword.Text && x.Username == txtbxUsername.Text).custId;
                //navigate to new form
                this.Hide();
                new MainStoreFrame().Show();
            }
            else
            {
                lblResult.Text = "Login not found";
            }
            
            
        }

        private void bttnNewUser_Click(object sender, EventArgs e)
        {
            //go to create login screen
            this.Hide();
            new CreateLogin().Show();
        }
    }
}
