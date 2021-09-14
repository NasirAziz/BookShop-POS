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
    public partial class CashInCashOut : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection();

        DateTime fromDate, tillDate;
        double totalCashIn, totalCashOut, totalProfit, totalLoss;

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            fromDate = dtpFrom.Value.Date;
            tillDate = dtpTill.Value.Date;

            try
            {

                dgv.Refresh();
                cmd.CommandText = "select * from Expense where Date between @first And @second";
                cmd.Parameters.AddWithValue("@first", fromDate);
                cmd.Parameters.AddWithValue("@second", tillDate);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                dt.Clear();
                ad.Fill(dt);
                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "Detail";
                dt.Columns[2].ColumnName = "CashOUT";
                dgv.DataSource = dt;
                cmd.ExecuteNonQuery();
                dgv.Refresh();

            }
            catch ( Exception)
            {
                MessageBox.Show(e.ToString());

            }
        }
        public void CashIn()
        {
            DateTime now = DateTime.Now;
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SUM(Total) FROM Sales_report where Date=@d";
            cmd.Parameters.AddWithValue("@d", now.ToString("yyyy-MM-dd"));
            int totalsales =(int)cmd.ExecuteScalar();
            cmd.CommandText = "SELECT SUM(amount) FROM Expense where date=@date";
            cmd.Parameters.AddWithValue("@date", now.ToString("yyyy-MM-dd"));
            int totalotherincome = (int)cmd.ExecuteScalar();
            double cashin = totalotherincome + totalsales;
            MessageBox.Show(totalsales.ToString());

        }

        public CashInCashOut()
        {
            InitializeComponent();
        }

        private void CashInCashOut_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Connection.c;
            con.Open();
            CashIn();

            
        }

    }
}
