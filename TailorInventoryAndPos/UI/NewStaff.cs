﻿using System;
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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage aPage=new HomePage();
            aPage.Show();
        }
    }
}
