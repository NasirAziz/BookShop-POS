using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaarDanaTraderPOS.Screens
{
    public partial class CreateOrderForm : Form
    {
        private DataTable order = new DataTable();

        private String productName;
        private String customerName;
        private int price;
        private int quantity;
        private int totalPrice;
        private int grandTotal=0;

        public CreateOrderForm()
        {
            InitializeComponent();
            order.Columns.Add("ID", typeof(int)); 
            order.Columns.Add("Product");
            order.Columns.Add("Quantity", typeof(int));
            order.Columns.Add("Price", typeof(int));
            order.Columns.Add("Total", typeof(int));

           order.Rows.Add(1, "Tomato",10, 100,1000);
           order.Rows.Add(2, "Potato", 10, 100, 1000);
           order.Rows.Add(3, "Apple", 10, 100, 1000);
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            dgvOrderItems.DataSource = order;
        }

        private void btnCOAddProduct_Click(object sender, EventArgs e)
        {
            try {
                productName = tbOrderProductName.Text;
                customerName = tbOrderCustomerName.Text;
                price = int.Parse(tbOrderProductPrice.Text);
                quantity = int.Parse(tbOrderProductQuantity.Text);
                totalPrice = price * quantity;
            } 
            catch {
                MessageBox.Show("Please enter valid data");
            }
            foreach (DataRow row in order.Rows)
            {
                grandTotal += int.Parse(row["Total"].ToString());
            }
            lblGrandTotal.Text = grandTotal.ToString();
            order.Rows.Add(1, productName, price, quantity, totalPrice);

        }

        private void btnCORemoveProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnCOCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnCOConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
