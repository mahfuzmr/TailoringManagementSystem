using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorInventoryAndPos.UI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking aBooking=new Booking();
            aBooking.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomersAccount account=new CustomersAccount();
            account.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm aForm=new LoginForm();
            aForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewProduct aProduct=new NewProduct();
            aProduct.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InvoiceReport aReport=new InvoiceReport();
            aReport.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewStaff aStaff=new NewStaff();
            aStaff.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewSupplier aSupplier=new NewSupplier();
            aSupplier.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SellReport aReport=new SellReport();
            aReport.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StuffAccount account=new StuffAccount();
            account.Show();
        }

      
    }
}
