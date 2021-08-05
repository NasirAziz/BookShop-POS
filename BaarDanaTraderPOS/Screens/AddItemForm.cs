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
    public partial class AddItemForm : Form
    {
        SqlConnection con = new SqlConnection();
        public int id, price, quantity;
        public String name;
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Add_item values(@name,@price,@quantity)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", tbItemName.Text);
            cmd.Parameters.AddWithValue("@price", tbItemPrice.Text);
            cmd.Parameters.AddWithValue("@quantity", tbItemQuantity.Text);
            
            try
            {
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Item Added Successfully");
                    
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
        private void UpdateItem(int id, String name, int price, int quantity)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Add_item SET Name=@name, Price=@price, Quantity=@quantity WHERE Item_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Updated");
            }
            


        }
        private void LoadItems()
        {
            DataTable Item = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Add_item";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(Item);
            dgvItems.DataSource = Item;
            cmd.ExecuteNonQuery();

        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Connection.c;
            con.Open();
        }

        private void btnAISearch_Click(object sender, EventArgs e)
        {
            DataTable Item = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Add_item where Name Like @name +'%'  ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", tbAISearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(Item);
            dgvItems.DataSource = Item;
            cmd.ExecuteNonQuery();
        }
        private void DeleteItem(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Add_item where Item_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            LoadItems();


        }
        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            name = tbItemName.Text;
            price = Convert.ToInt32(tbItemPrice.Text);
            quantity = Convert.ToInt32(tbItemQuantity.Text);
            UpdateItem(id, name, price, quantity);
            LoadItems();
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            DeleteItem(id);
            LoadItems();
        }

        private void btnItemCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAISearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Item = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Add_item where Name Like @name + '%'";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", tbAISearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(Item);
            dgvItems.DataSource = Item;
            cmd.ExecuteNonQuery();
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value.ToString());
                name = dgvItems.CurrentRow.Cells[1].Value.ToString();
                price= Convert.ToInt32(dgvItems.CurrentRow.Cells[2].Value.ToString());
                quantity = Convert.ToInt32(dgvItems.CurrentRow.Cells[3].Value.ToString());
                tbItemName.Text = name;
                tbItemPrice.Text = price.ToString();
                tbItemQuantity.Text = quantity.ToString();
                
            }
            catch
            {

            }
        }
    }
}
