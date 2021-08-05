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
    public partial class AddCustomerForm : Form
    {
       
        SqlConnection con = new SqlConnection();
       

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Connection.c;
            con.Open();
            LoadCustomers();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Add_customer values(@name,@phone,@address,@balance)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", tbCustomerName.Text);
            cmd.Parameters.AddWithValue("@phone", tbCustomerPhone.Text);
            cmd.Parameters.AddWithValue("@address", tbCustomerAddress.Text);
            cmd.Parameters.AddWithValue("@balance", tbCustomerBalance.Text);
            try 
            {
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Customer Added Successfully");
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Not Added");
                }
            }
            catch
            {
                MessageBox.Show("Please Fill the required fields!");            
            }
            

        }

        private void btnACSearch_Click(object sender, EventArgs e)
        {
            String name = tbACSearch.Text;
            SearchForCustomer(name);
        }

        private void SearchForCustomer(String name)
        {
            if(name.Length == 0)
            {
                MessageBox.Show("Please enter name to search!");
            }
            else if (name.Length > 0)
            {
                DataTable customer = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from Add_customer where Name=@name";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(customer);
                dgvAddCustomers.DataSource = customer;
                cmd.ExecuteNonQuery();
                
            }
            
        }

        private void LoadCustomers()
        {
            DataTable customer = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
                cmd.CommandText = "Select * from Add_customer";
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(customer);
                dgvAddCustomers.DataSource = customer;
                cmd.ExecuteNonQuery();
            
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            String name = tbCustomerName.Text;
            DeleteCustomer(name);
        }

        private void DeleteCustomer(String name)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Please enter Name to Delete!");
            }
            else if (name.Length > 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Add_customer where Name=@name";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                LoadCustomers();
            }

        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCustomer(int id, String name, String address, int phone)
        {

         SqlCommand cmd = new SqlCommand();
         cmd.Connection = con;
         cmd.CommandText = "UPDATE Add_customer SET Name=@name Phone_no=@phone Address=@address Balance=@balance WHERE Customer_id=@id";
         cmd.CommandType = CommandType.Text;
         cmd.Parameters.AddWithValue("@name", name);
         cmd.Parameters.AddWithValue("@id", id);
         cmd.Parameters.AddWithValue("@address", address);
         cmd.Parameters.AddWithValue("@phone", phone);
         cmd.ExecuteNonQuery();
         LoadCustomers();
          

        }
    }
}
