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
    public partial class Users : Form
    {
        string s;
        SqlConnection con;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Users values(@Name,@Password,@Permissions)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
            cmd.Parameters.AddWithValue("@Permissions", s);

            try
            {
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("User Added Successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Please Fill the required fields!");
            }
        }

        private void permissionsList_Validating(object sender, CancelEventArgs e)
        {
/*            var list = permissionsList.SelectedItems;
            if (list.Contains("Create Order"))
                createOrder = "CreateOrder";
            else
                createOrder = "";
            if (list.Contains("Add Product"))
                addProduct = "AddProduct";
            else
                addProduct = "";

            if (list.Contains("Sales Report"))
                salesReport = "SalesReport";
            else
                salesReport = "";
            if (list.Contains("Cash Report"))
                cashReport = "CashReport";
            else
                cashReport = "";

            if (list.Contains("Add Other Income"))
                addOtherIncome = "AddOtherIncome";
            else
                addOtherIncome = "";
            if (list.Contains("Profit Loss"))
                profitLoss = "ProfitLoss";
            else
                profitLoss = "";

            if (list.Contains("Add Expenses"))
                addExpenses = "AddExpenses";
            else
                addExpenses = "";
            if (list.Contains("Settings"))
                settings = "Settings";
            else
                settings = "";

            if (list.Contains("Users"))
                users = "Users";
            else
                users = "";

            MessageBox.Show(users.ToString() + settings.ToString() + createOrder.ToString());*/

            if (permissionsList.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                s = "";
                for (int x = 0; x < permissionsList.CheckedItems.Count; x++)
                {
                    s = s + permissionsList.CheckedItems[x].ToString() + ",";
                }
                MessageBox.Show(s);
            }
        }

        string name, password;

        private void permissionsList_Validated(object sender, EventArgs e)
        {
           
        }


        public Users()
        {
            InitializeComponent();
        }


        private void permissionsList_SelectedValueChanged(object sender, EventArgs e)
        {

           

        }

        private void Users_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(Connection.c);
            con.Open();
        }

        private void permissionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
