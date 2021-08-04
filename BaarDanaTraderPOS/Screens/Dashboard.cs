using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaarDanaTraderPOS.Screens;

namespace BaarDanaTraderPOS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateOrder(object sender, EventArgs e)
        {
            CreateOrderForm cof = new CreateOrderForm();
            cof.Show();
        }

        private void btnViewHistory(object sender, EventArgs e)
        {
            //asdsadsadsadasd
            //asdsadsadsadasd

            ViewHistoryForm vhf = new ViewHistoryForm();
            vhf.Show();

        }

        private void btnAddItem(object sender, EventArgs e)
        {
            AddItemForm aif = new AddItemForm();
            aif.Show();

        }

        private void btnAddCustomer(object sender, EventArgs e)
        {
            AddCustomerForm acf = new AddCustomerForm();
            acf.Show();

        }
    }
}
