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
    public partial class CustInfo : Form
    {
      
        public int accID;
        public static int? customerID;
        public CustInfo()
        {
            InitializeComponent();
            this.accID = CreateLogin.accID;
        }

      

        private void bttn_custInfoSubmit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            
            Customer cust = new Customer
            {
                
                Fname = txtbx_fname.Text,
                Lname = txtbx_lname.Text,
                Phone = txtbx_phone.Text,
                Street = txtbx_street.Text,
                City = txtbx_city.Text,
                CState = comboBox_state.Text,
                Zip = txtbx_zip.Text,
                AccountId = accID
            };
            dc.Customers.InsertOnSubmit(cust);
            dc.SubmitChanges();
        
            
                var custIdResult= dc.GetTable<Customer>().Where(a => a.AccountId == accID).First().CId;
            //update account table with cID
            var custAccount = dc.GetTable<account>().Where(a => a.AccountID == accID).First();
            custAccount.custId = custIdResult;
            customerID = cust.CId;
            dc.SubmitChanges();
            this.Hide();
            new MainStoreFrame().Show();
            
        
        }
    }
}
