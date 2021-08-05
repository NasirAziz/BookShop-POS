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
        public int id, phno, balance;
        public String name, address;

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
            DeleteCustomer(id);
        }

        private void DeleteCustomer(int id)
        {
            
            
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Add_customer where Customer_id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                LoadCustomers();
            

        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                name = tbCustomerName.Text;
                phno = Convert.ToInt32(tbCustomerPhone.Text);
                try
                {
                    balance = Convert.ToInt32(tbCustomerBalance.Text);
                }
                catch
                {
                    balance = 0;
                }

                address = tbCustomerAddress.Text;
            }
            catch
            {
                MessageBox.Show("Please fill the requiered field");
            }
            
            UpdateCustomer(id, name, address, phno,balance);
            
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void UpdateCustomer(int id, String name, String address, int phone,int balance)
        {

         SqlCommand cmd = new SqlCommand();
         cmd.Connection = con;
         cmd.CommandText = "UPDATE Add_customer SET Name=@name, Phone_no=@phone, Address=@address, Balance=@balance WHERE Customer_id=@id";
         cmd.CommandType = CommandType.Text;
         cmd.Parameters.AddWithValue("@name", name);
         cmd.Parameters.AddWithValue("@id", id);
         cmd.Parameters.AddWithValue("@address", address);
         cmd.Parameters.AddWithValue("@phone", phone);
        cmd.Parameters.AddWithValue("@balance", balance);
        int r=cmd.ExecuteNonQuery();
        if (r > 0)
            {
                MessageBox.Show("Updated");
            }
         LoadCustomers();
          

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
            try
            {
                id = Convert.ToInt32(dgvAddCustomers.CurrentRow.Cells[0].Value.ToString());
                name = dgvAddCustomers.CurrentRow.Cells[1].Value.ToString();
                phno = Convert.ToInt32(dgvAddCustomers.CurrentRow.Cells[2].Value.ToString());
                address = dgvAddCustomers.CurrentRow.Cells[3].Value.ToString();
                balance = Convert.ToInt32(dgvAddCustomers.CurrentRow.Cells[4].Value.ToString());
                tbCustomerName.Text = name;
                tbCustomerPhone.Text = phno.ToString();
                tbCustomerBalance.Text = balance.ToString();
                tbCustomerAddress.Text = address;
            }
            catch
            {

            }

        }
        

        }
    }

