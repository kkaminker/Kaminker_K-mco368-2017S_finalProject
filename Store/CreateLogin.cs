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
    public partial class CreateLogin : Form
    {
        public static int accID;
        public CreateLogin()
        {
            InitializeComponent();
            //TODO: the following should be when application is exited
            //To ensure that cart data does not stick around between users
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var itemsInCart = dc.GetTable<cartItem>();
            if (itemsInCart.Any())
            {
                dc.cartItems.DeleteAllOnSubmit(itemsInCart);
                dc.SubmitChanges();
            }

        }

        private void bttnCreateLogin_Click(object sender, EventArgs e)
        {
            //insert username.text and password.text into account
          
            DataClasses1DataContext dc = new DataClasses1DataContext();
            account acc = new account {
                Balance = 0.0M,
                Username = txtbxUsernameNew.Text,
                CustPassword = txtbxPasswordNew.Text
            };
        
            dc.accounts.InsertOnSubmit(acc);
            dc.SubmitChanges();
            this.Hide();
            accID = acc.AccountID;
            CustInfo ci = new CustInfo();
           // ci.acceptLogin(acc.AccountID);//TODO pass in the accountId of this person
            ci.Show();
            
           
          /*  //Testing
           *  var newLogin = from l in dc.GetTable<account>()
                           select l;
            txtbxUsernameNew.Text = newLogin.First().Username;*/


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
