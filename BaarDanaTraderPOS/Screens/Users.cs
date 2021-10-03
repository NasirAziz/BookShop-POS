using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaarDanaTraderPOS.Screens
{
    public partial class Users : Form
    {
        string createOrder,addProduct,salesReport,cashReport,addOtherIncome,profitLoss,addExpenses,settings,users;
        string name, password;

        private void permissionsList_Validated(object sender, EventArgs e)
        {
            var list = permissionsList.SelectedItems;
            MessageBox.Show(list.Count.ToString());
        }


        public Users()
        {
            InitializeComponent();
        }


        private void permissionsList_SelectedValueChanged(object sender, EventArgs e)
        {

            var list = permissionsList.SelectedItems;

            if (list.Contains("Create Order"))
                createOrder = "CreateOrder";
            if (list.Contains("Add Product"))
                addProduct = "AddProduct";

            if (list.Contains("Sales Report"))
                salesReport = "SalesReport";
            if (list.Contains("Cash Report"))
                cashReport = "CashReport";

            if (list.Contains("Add Other Income"))
                addOtherIncome = "AddOtherIncome";
            if (list.Contains("Profit Loss"))
                profitLoss = "ProfitLoss";

            if (list.Contains("Add Expenses"))
                addExpenses = "AddExpenses";
            if (list.Contains("Settings"))
                settings = "Settings";

            if (list.Contains("Users"))
                users = "Users";

        }
        

        private void permissionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
