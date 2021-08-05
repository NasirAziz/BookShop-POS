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

        private void tbACSearch_TextChanged(object sender, EventArgs e)
        {

            DataTable customer = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Add_customer where Name Like @name + '%'";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", tbACSearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(customer);
            dgvAddCustomers.DataSource = customer;
            cmd.ExecuteNonQuery();
        }

        private void dgvAddCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvAddCustomers.CurrentRow.Cells[0].Value.ToString());
            String name= dgvAddCustomers.CurrentRow.Cells[1].Value.ToString();
            int phno = Convert.ToInt32(dgvAddCustomers.CurrentRow.Cells[2].Value.ToString());
            String Address = dgvAddCustomers.CurrentRow.Cells[3].Value.ToString();
            int balance = Convert.ToInt32(dgvAddCustomers.CurrentRow.Cells[4].Value.ToString());
            tbCustomerName.Text = name;
            tbCustomerPhone.Text = phno.ToString();
            tbCustomerBalance.Text = balance.ToString();
            tbCustomerAddress.Text = Address;

                

        }
    }
}
