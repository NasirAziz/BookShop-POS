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
    public partial class ViewHistoryForm : Form
    {
        SqlConnection con = new SqlConnection();
        public string fromdate, todate;
        bool isFromDateChanged=false, isToDateChanged = false;


        public ViewHistoryForm()
        {
            InitializeComponent();
        }

        private void ViewHistoryForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Connection.c;
            con.Open();
            from.Format = DateTimePickerFormat.Custom;
            from.CustomFormat = " ";
            to.Format = DateTimePickerFormat.Custom;
            to.CustomFormat = " ";



        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            try
            {
                cmd.CommandText = "select * from Sales_report where Invoice_id=@id";
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbCustomerSearch.Text));
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable viewhistory = new DataTable();
                ad.Fill(viewhistory);
                dgvViewHistory.DataSource = viewhistory;
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("try");
            }
            try
            {
                if(isFromDateChanged && isToDateChanged)
                {
                    try
                    {

                        cmd.CommandText = "select * from Sales_report where Customer_name=@name AND Date between @first And @second";
                        cmd.Parameters.AddWithValue("@name", tbCustomerSearch.Text);
                        cmd.Parameters.AddWithValue("@first", Convert.ToDateTime(fromdate));
                        cmd.Parameters.AddWithValue("@second", Convert.ToDateTime(todate));
                        SqlDataAdapter ad2 = new SqlDataAdapter(cmd);
                        DataTable viewhistory2 = new DataTable();
                        ad2.Fill(viewhistory2);
                        dgvViewHistory.DataSource = viewhistory2;
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("try 2");

                    }
                }
                else
                {
                 cmd.CommandText = "select * from Sales_report where Customer_name=@name";
                  cmd.Parameters.AddWithValue("@name",tbCustomerSearch.Text);
                  SqlDataAdapter ad = new SqlDataAdapter(cmd);
                  DataTable viewhistory = new DataTable();
                  ad.Fill(viewhistory);
                  cmd.ExecuteNonQuery();
                  dgvViewHistory.DataSource = viewhistory;
                }

               

            }
            catch
            {
                MessageBox.Show("try 3");
            }
           
           
           


        }

        private void from_ValueChanged(object sender, EventArgs e)
        {
            isFromDateChanged = true;
            from.Format = DateTimePickerFormat.Custom;
            from.CustomFormat = "dd-MMM-yyyy";
            fromdate = from.Value.ToString("dd-MM-yyyy");
        }

        private void to_ValueChanged(object sender, EventArgs e)
        {
            isToDateChanged = true;
            to.Format = DateTimePickerFormat.Custom;
            to.CustomFormat = "dd-MMM-yyyy";
            todate = to.Value.ToString("dd-MM-yyyy");
        }
    }
}
