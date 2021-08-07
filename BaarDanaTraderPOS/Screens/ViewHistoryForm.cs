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
        bool flag = false;
        public static DataTable viewhistory = new DataTable();
        
        
        public ViewHistoryForm()
        {
            InitializeComponent();
        }

        private void ViewHistoryForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Connection.c;
            con.Open();
            



        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            fromdate = from.Value.ToString("yyyy-dd-MM");
            todate = to.Value.ToString("yyyy-dd-MM");
            
            if (flag)
            {
                try
                {
                    
                    
                    dgvViewHistory.Refresh();
                    cmd.CommandText = "select * from Sales_report where Customer_name=@name and Date between @first And @second";
                    cmd.Parameters.AddWithValue("@name", tbCustomerSearch.Text);
                    cmd.Parameters.AddWithValue("@first", Convert.ToDateTime(fromdate));
                    cmd.Parameters.AddWithValue("@second", Convert.ToDateTime(todate));
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                   // DataTable viewhistory = new DataTable();
                    ad.Fill(viewhistory);
                    dgvViewHistory.DataSource = viewhistory;
                    cmd.ExecuteNonQuery();
                }
                catch
                {


                }
            }
            else
            {
               
                dgvViewHistory.Refresh();
                cmd.CommandText = "select * from Sales_report where Customer_name=@name";
                cmd.Parameters.AddWithValue("@name", tbCustomerSearch.Text);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                //DataTable viewhistory = new DataTable();
                ad.Fill(viewhistory);
                cmd.ExecuteNonQuery();
                dgvViewHistory.DataSource = viewhistory;
            }
            
            try
            {
                
                dgvViewHistory.Refresh();
                cmd.CommandText = "select * from Sales_report where Invoice_id=@id";
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbCustomerSearch.Text));
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
               // DataTable viewhistory = new DataTable();
                ad.Fill(viewhistory);
                cmd.ExecuteNonQuery();
                dgvViewHistory.DataSource = viewhistory;
                
            }
            catch
            {

            }
            
           
           


        }

        private void from_ValueChanged(object sender, EventArgs e)
        {
            flag = true;
            to.MinDate = from.Value.Date;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            ViewHistoryReport a = new ViewHistoryReport();
            a.Show();
        }

        private void to_ValueChanged(object sender, EventArgs e)
        {
            flag = true;
        }
    }
}
