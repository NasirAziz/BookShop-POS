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
        public static int Invoice_id = 0;
        private int quantity;
        int timesEnterPressed = 0;
        int Balance;
        public int totalPrice;
        public static int FinalPrice;
        public int grandTotal=0;
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
           // MessageBox.Show(Invoice_id.ToString());
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {  
                timesEnterPressed++;

                if (timesEnterPressed != 2)
                {
                  Console.WriteLine("Enter Key if" + timesEnterPressed.ToString());

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
                }else if (e.KeyCode == Keys.Enter && timesEnterPressed == 2) 
                {
                    Console.WriteLine("Enter Key else if" + timesEnterPressed.ToString());

                    AddItemToDatatable();
                    timesEnterPressed = 0;
                }
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
            timesEnterPressed = 0;
            AddItemToDatatable();
        }

        private void AddItemToDatatable()
        {
            try
            {
                timesEnterPressed = 0;

                productName = tbOrderProductName.Text;
                customerName = cbCustomername.GetItemText(cbCustomername.SelectedItem);
                price = int.Parse(tbOrderProductPrice.Text);
                quantity = int.Parse(tbOrderProductQuantity.Text);
                totalPrice = price * quantity;
                String currentdate = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");

                bool contains = order.AsEnumerable().Any(row => productName == row.Field<String>("Product"));

                if (!contains)
                {
                    order.Rows.Add(id, productName, quantity, price, totalPrice, currentdate, customerName, Invoice_id);
                }
                else
                {
                    MessageBox.Show("Product already exists! Please change its values using the Grid.");
                }

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
            FinalPrice = (grandTotal + Balance);
            lblBalance.Text = FinalPrice.ToString();
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
            //int columnIndex = e.ColumnIndex;
            int? productQuantityAtIndex = null;
            int? productPriceAtIndex = null;


            if (dgvOrderItems.Rows[rowIndex].Cells["Price"].Value.ToString().Length != 0)
            {
                productPriceAtIndex = int.Parse(order.Rows[rowIndex]["Price"].ToString());
            }
            if (dgvOrderItems.Rows[rowIndex].Cells["Quantity"].Value.ToString().Length != 0 )
            {
                productQuantityAtIndex = int.Parse(order.Rows[rowIndex]["Quantity"].ToString());
            }
            if(productPriceAtIndex!=null && productQuantityAtIndex !=null)
            {
            totalPrice = (int)(productPriceAtIndex * productQuantityAtIndex);
            }
            else
            {
                MessageBox.Show("Please Enter valid values in cells");
                return;
            }
            //update datatable with new values from grid view
            order.Rows[rowIndex]["Total"] = totalPrice;
            order.Rows[rowIndex]["Price"] = productPriceAtIndex;
            order.Rows[rowIndex]["Quantity"] = productQuantityAtIndex;
            CalculateTotalPrice();

           // MessageBox.Show(order.Rows[rowIndex]["Product"].ToString() + order.Rows[rowIndex]["Quantity"].ToString() + order.Rows[rowIndex]["Total"].ToString());
           // String value = dgvOrderItems.Rows[rowIndex].Cells["Quantity"].Value.ToString();
           // MessageBox.Show(value);
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
                label10.Text = (grandTotal + Balance).ToString();

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
            int paymentAmount;
            if (tbPaidAmount.Text.Length != 0)
            {
                try
                {
                paymentAmount = int.Parse(tbPaidAmount.Text);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Amount to Continue");
                return;
            }

            MoveOrdersToSaleTable();
            InvoiceViewer a = new InvoiceViewer();
            a.Show();
            
        }
    }
}
