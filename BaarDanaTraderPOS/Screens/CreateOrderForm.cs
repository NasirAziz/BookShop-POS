﻿using System;
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
        int Balance=0;

        private int quantity, Invoice_id;

        private int quantity;

        private int totalPrice;
        private int grandTotal=0;
        public bool flag = false;

        public CreateOrderForm()
        {
            InitializeComponent();

            con.ConnectionString = Connection.c;
            con.Open();

            order.Columns.Add("ID", typeof(int)); 
            order.Columns.Add("Product");
            order.Columns.Add("Quantity", typeof(int));
            order.Columns.Add("Price", typeof(int));
            order.Columns.Add("Total", typeof(int));
            order.Columns.Add("Date");
            order.Columns.Add("Customer_name");
            order.Columns.Add("Invoice_id", typeof(int));
            loaddataincategory();
            flag = true;
            dgvOrderItems.DataSource = order;
            dgvOrderItems.Columns["Date"].Visible = false;
        }
        public void loaddataincategory()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Add_customer";
            //Fill the DataTable with records from Table.
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Insert the Default Item to DataTable.
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Walkin Customer";
            dt.Rows.InsertAt(row, 0);
            cbCustomername.DataSource = dt;
            cbCustomername.DisplayMember = "Name";
            cbCustomername.ValueMember = "Customer_id";
            cbCustomername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCustomername.AutoCompleteSource = AutoCompleteSource.ListItems;
            ///////////////////////////////
            ///

        }
        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            dgvOrderItems.DataSource = order;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MMM-yyyy";


            this.tbOrderProductID.KeyDown += new KeyEventHandler(this.OnKeyDownHandler);
            Invoice_id = InvoiceIdGenerator();
            MessageBox.Show(Invoice_id.ToString());
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

                GetValuesFromDatabase();

            }

        }

        private void GetValuesFromDatabase()
        {
            ///get id
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Item_id from Add_item where Item_id=@id";
            cmd.Parameters.AddWithValue("@id", tbOrderProductID.Text);
            id = (int)cmd.ExecuteScalar();

            ///  Name
            
            cmd.Connection = con;
            cmd.CommandText = "select Name from Add_item where Item_id=@id1";
            cmd.Parameters.AddWithValue("@id1", tbOrderProductID.Text);
            productName = (String)cmd.ExecuteScalar();
            tbOrderProductName.Text = productName;
            ////// Price
            
            cmd.Connection = con;
            cmd.CommandText = "select Price from Add_item where Item_id=@id2";
            cmd.Parameters.AddWithValue("@id2", tbOrderProductID.Text);
            price = (int)cmd.ExecuteScalar();
            tbOrderProductPrice.Text = price.ToString();
            ///quantity
            
            cmd.Connection = con;
            cmd.CommandText = "select Quantity from Add_item where Item_id=@id3";
            cmd.Parameters.AddWithValue("@id3", tbOrderProductID.Text);
            quantity = (int)cmd.ExecuteScalar();
            tbOrderProductQuantity.Text = quantity.ToString();
        }

        private void btnCOAddProduct_Click(object sender, EventArgs e)
        {
           
            try {
                productName = tbOrderProductName.Text;
                customerName = cbCustomername.GetItemText(cbCustomername.SelectedItem);
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

            String currentdate = dateTimePicker1.Value.Date.ToString();

            order.Rows.Add(id, productName, quantity, price, totalPrice);

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

        private void btnCOAddProduct_Click_1(object sender, EventArgs e)
        {

            try
            {
                productName = tbOrderProductName.Text;
                customerName = cbCustomername.GetItemText(cbCustomername.SelectedItem);
                price = int.Parse(tbOrderProductPrice.Text);
                quantity = int.Parse(tbOrderProductQuantity.Text);
                totalPrice = price * quantity;
                String currentdate = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");
                order.Rows.Add(id, productName, quantity, price, totalPrice,currentdate,customerName,Invoice_id);

                //calculate total price
                CalculateTotalPrice();



            }
            catch
            {
                MessageBox.Show("Please enter valid data");
            }
        }

        private void CalculateTotalPrice()
        {
            grandTotal = 0;
            foreach (DataRow row in order.Rows)
            {
                grandTotal += int.Parse(row["Total"].ToString());
            }
            lblGrandTotal.Text = grandTotal.ToString();
            lblTotal.Text = (grandTotal + Balance).ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);

        }

        private void dgvOrderItems_Validated(object sender, EventArgs e)
        {
           // MessageBox.Show(e.ToString());
        }

        private void dgvOrderItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
           // int columnIndex = e.ColumnIndex;
            int productPriceAtIndex = int.Parse(order.Rows[rowIndex]["Price"].ToString());
            int productQuantityAtIndex = int.Parse(order.Rows[rowIndex]["Quantity"].ToString());
            totalPrice = productPriceAtIndex * productQuantityAtIndex;
            order.Rows[rowIndex]["Total"] = totalPrice;
            CalculateTotalPrice();
            
           // MessageBox.Show(productPriceAtIndex.ToString() + rowIndex.ToString());
        }

        private void cbCustomername_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCustomername_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag && cbCustomername.GetItemText(cbCustomername.SelectedItem) != "Walkin Customer") {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Balance from Add_customer where Name=@name";
                cmd.Parameters.AddWithValue("@name", cbCustomername.GetItemText(cbCustomername.SelectedItem));
                Balance = (int)cmd.ExecuteScalar();
                lblBalance.Text = Balance.ToString();
                lblTotal.Text = (grandTotal + Balance).ToString();
            }
            else
            {

            }
        }
        public void MoveOrdersToSaleTable()
        {
            SqlBulkCopy objbulk = new SqlBulkCopy(con);
            objbulk.DestinationTableName = "Sales_report";
            objbulk.ColumnMappings.Add("Date", "Date");
            objbulk.ColumnMappings.Add("Product", "Product");
            objbulk.ColumnMappings.Add("Quantity", "Quantity");
            objbulk.ColumnMappings.Add("Total", "Total");
            objbulk.ColumnMappings.Add("Price", "Price");
            objbulk.ColumnMappings.Add("Customer_name", "Customer_name");
            objbulk.ColumnMappings.Add("Invoice_id", "Invoice_id");
            objbulk.WriteToServer(order);

        }
        public int InvoiceIdGenerator()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Invoice_id from Invoice_id";
            int Invoice_id = (int)cmd.ExecuteScalar();
            Invoice_id++;
            cmd.CommandText = "update Invoice_id set Invoice_id = @invoiceid where id = @id ";
            cmd.Parameters.AddWithValue("@invoiceid", Invoice_id);
            cmd.Parameters.AddWithValue("@id", 1);
            cmd.ExecuteNonQuery();
            return Invoice_id;
        } 

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            InvoiceViewer a = new InvoiceViewer();
            a.Show();
            MoveOrdersToSaleTable();
            
        }

        private void btnCOConfirm_Click(object sender, EventArgs e)
        {
            int paymentAmount = int.Parse(tbPaidAmount.Text);
            

        }
    }
}
