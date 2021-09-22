using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BaarDanaTraderPOS.Screens
{
    public partial class SalesReturn : Form
    {
        Double price, Quantity, Total, Sale_id, Product_id, Profit;
        String Product_name;
        SqlConnection con = new SqlConnection();
        
        public SalesReturn()
        {
            InitializeComponent();

        }
        public void FillTextBox()
        {
            tbProductName.Text = this.Product_name;
            tbPrice.Text = price.ToString();
            tbQuantity.Text = Quantity.ToString();
            tbTotal.Text = Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteSale();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            update();
        }

        public SalesReturn(Double price, Double Quantity,Double Total, String Product_Name,Double Sale_id,Double Product_id,Double Profit)
        {
            InitializeComponent();

            this.price = price;
            this.Quantity = Quantity;
            this.Total = Total;
            this.Product_name = Product_Name;
            this.Sale_id = Sale_id;
            this.Product_id = Product_id;
            this.Profit = Profit;
            FillTextBox();
            


        }
        public void DeleteSale()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Sales_report where Sale_id=@id";
                cmd.Parameters.AddWithValue("@id", Sale_id);
                int r=cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Sale Successfully Return ");
                    QuantityBack(Quantity);
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void QuantityBack(Double qty)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Add_item set Quantity=@q where Item_id=@id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Product_id));
            cmd.Parameters.AddWithValue("@q", qty);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("added Quantity");
            }
            

        }
        public void update()
        {
            double newqty = Convert.ToDouble(tbQuantity.Text);
            if ( newqty > Quantity )
            {
                MessageBox.Show("You are returning more quantity than you sold.");
            }
            else
            {
                double newprice= newqty * price;
                double newprofit = (Profit / Quantity) * newqty;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Sales_report set Quantity=@q, Total=@t,Profit=@p where Sale_id=@invoice";
                cmd.Parameters.AddWithValue("@q", newqty);
                cmd.Parameters.AddWithValue("@t", newprice);
                cmd.Parameters.AddWithValue("@id", Product_id);
                cmd.Parameters.AddWithValue("@invoice", Sale_id);
                cmd.Parameters.AddWithValue("@p", newprofit);
                int r=cmd.ExecuteNonQuery();
                if ( r> 0)
                {
                    MessageBox.Show("Partial Sale Return");
                    QuantityBack(newqty);
                }
                else
                {
                    MessageBox.Show("");
                }
                
            }

            


        }
        

        private void SalesReturn_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Connection.c;
            con.Open();
        }
    }
}
