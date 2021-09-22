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
        Double price, Quantity, Total, Sale_id, Product_id;
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

        public SalesReturn(Double price, Double Quantity,Double Total, String Product_Name,Double Sale_id,Double Product_id)
        {
            InitializeComponent();

            this.price = price;
            this.Quantity = Quantity;
            this.Total = Total;
            this.Product_name = Product_Name;
            this.Sale_id = Sale_id;
            this.Product_id = Product_id;
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
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Sales_report set Quantity=@q, Total=@t where Product_id=@id";
                cmd.Parameters.AddWithValue("@q", newqty);
                cmd.Parameters.AddWithValue("@t", newprice);
                cmd.Parameters.AddWithValue("@id", Product_id);
                int r=cmd.ExecuteNonQuery();
                if ( r> 0)
                {
                    MessageBox.Show("Partial Sale Return");
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
