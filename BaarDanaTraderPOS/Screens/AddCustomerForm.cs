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
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Customer Added Successfully");
            }
            else
            {
                MessageBox.Show("Not Added");
            }

        }

        private void btnACSearch_Click(object sender, EventArgs e)
        {
            DataTable customer = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Add_customer where Name=@name";
            
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", tbACSearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(customer);
            dgvAddCustomers.DataSource = customer;
            cmd.ExecuteNonQuery();
        }
    }
}
