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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();

            lbl_balance.Text = getUserBalance().ToString();
        }

        private Decimal getUserBalance()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var userAccounts = from b in dc.GetTable<account>()
                               where b.custId == CustInfo.customerID
                               select b;
            var userAccount = userAccounts.First();
            return userAccount.Balance;
        }
        private void bttn_payFullBalance_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var userAccount = dc.GetTable<account>().Where(b => b.custId == CustInfo.customerID).First();
             
            userAccount.Balance = 0; 
            dc.SubmitChanges();
            lbl_balance.Text = "0";

        }

        private void bttn_payBalance_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var userAccount = dc.GetTable<account>().Where(b => b.custId == CustInfo.customerID).First();
            userAccount.Balance -= Decimal.Parse(txtbx_toPay.Text);
            dc.SubmitChanges();
            lbl_balance.Text = dc.GetTable<account>().Where(b => b.custId == CustInfo.customerID).First().Balance.ToString();
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainStoreFrame.ActiveForm.Show();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Purchases().Show();
        }

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cart().Show();
        }

        private void checkBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Balance().Show();
        }
    }
}
