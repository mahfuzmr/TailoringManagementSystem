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
    public partial class CustomersAccount : Form
    {
        public CustomersAccount()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HomePage aHomePage=new HomePage();
            aHomePage.Show();
        }
    }
}
