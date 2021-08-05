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

namespace BaarDanaTraderPOS.Screens
{
    public partial class CreateOrderForm : Form
    {
        private DataTable order = new DataTable();
        
        SqlConnection con = new SqlConnection();


        private String productName;
        private String customerName;
        private int price, id;
        private int quantity;
        private int totalPrice;
        private int grandTotal=0;

        public CreateOrderForm()
        {
            InitializeComponent();

            con.ConnectionString = Connection.c;
            con.Open();

            //order.Columns.Add("ID", typeof(int)); 
            //order.Columns.Add("Product");
            //order.Columns.Add("Quantity", typeof(int));
            //order.Columns.Add("Price", typeof(int));
            //order.Columns.Add("Total", typeof(int));
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            dgvOrderItems.DataSource = order;


            this.tbOrderProductID.KeyDown += new KeyEventHandler(this.OnKeyDownHandler);

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                /*  int id = int.Parse(tbOrderProductID.Text);
                  SqlCommand cmd = new SqlCommand();
                  cmd.Connection = con;
                  cmd.CommandText = "Select * from Add_item where Item_id=@id";
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@id", id);
                  SqlDataAdapter sda = new SqlDataAdapter(cmd);
                  sda.Fill(order);
                  dgvOrderItems.DataSource = order;
                  cmd.ExecuteNonQuery();
                  //MessageBox.Show("key");
                  */
                ///get id
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Item_id from Add_item where Item_id=@id";
                cmd.Parameters.AddWithValue("@id", tbOrderProductID.Text);
                id = (int)cmd.ExecuteScalar();

                ///  Name
                SqlCommand cmd1 = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Name from Add_item where Item_id=@id1";
                cmd.Parameters.AddWithValue("@id1", tbOrderProductID.Text);
                productName = (String)cmd.ExecuteScalar();
                tbOrderProductName.Text = productName;
                ////// Price
                SqlCommand cmd2 = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Price from Add_item where Item_id=@id2";
                cmd.Parameters.AddWithValue("@id2", tbOrderProductID.Text);
                price = (int)cmd.ExecuteScalar();
                tbOrderProductPrice.Text = price.ToString();
                ///quantity
                SqlCommand cmd3 = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Quantity from Add_item where Item_id=@id3";
                cmd.Parameters.AddWithValue("@id3", tbOrderProductID.Text);
                 quantity = (int)cmd.ExecuteScalar();
                tbOrderProductQuantity.Text = quantity.ToString();
                //
            }

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
            order.Rows.Add(1, productName, quantity, price, totalPrice);

        }

        private void btnCORemoveProduct_Click(object sender, EventArgs e)
        {
            String name = tbOrderProductName.Text;
            foreach (DataRow row in order.Rows) {
                if(name == row["Product"].ToString())
                {
                    order.Rows.Remove(row);
                }
            }

            dgvOrderItems.DataSource = order;
        }

        private void btnCOCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbOrderCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void lblGrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCOConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
