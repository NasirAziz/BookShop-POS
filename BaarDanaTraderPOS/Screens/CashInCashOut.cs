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
                cmd.CommandText = "select * from Cash_report where Date between @first And @second";
                cmd.Parameters.AddWithValue("@first", fromDate);
                cmd.Parameters.AddWithValue("@second", tillDate);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                dt.Clear();
                ad.Fill(dt);
                dgv.DataSource = dt;
                cmd.ExecuteNonQuery();
                dgv.Refresh();

            }
            catch ( Exception)
            {
                MessageBox.Show(e.ToString());

            }
        }


        public CashInCashOut()
        {
            InitializeComponent();
        }

        private void CashInCashOut_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            try
            {

                dgv.Refresh();
                cmd.CommandText = "select * from Cash_report";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                dt.Clear();
                ad.Fill(dt);
                dgv.DataSource = dt;
                cmd.ExecuteNonQuery();
                dgv.Refresh();

            }
            catch(Exception)
            {
                MessageBox.Show(e.ToString());

            }
        }

    }
}
