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
        SqlConnection con = new SqlConnection();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Connection.c;
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Error! Database not found.");
            }
            
        }

        private void btnCreateOrder(object sender, EventArgs e)
        {
            CreateOrderForm cof = new CreateOrderForm();
            cof.Show();
        }

        private void btnViewHistory(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }
    }
}
