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
using Microsoft.Reporting.WinForms;

namespace BaarDanaTraderPOS.Screens
{
    public partial class InvoiceViewer : Form
    {
        SqlConnection con = new SqlConnection();
        public InvoiceViewer()
        {
            InitializeComponent();
        }

        private void InvoiceViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baarDanaTradersDataSet12.Sales_report' table. You can move, or remove it, as needed.
            this.sales_reportTableAdapter.Fill(this.baarDanaTradersDataSet12.Sales_report);

            this.reportViewer1.RefreshReport();
            con.ConnectionString = Connection.c;
            con.Open();
            load();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //load();
        }
        public void load()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Sales_report where Invoice_id=@a";
            cmd.Parameters.AddWithValue("@a",CreateOrderForm.Invoice_id);
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataSet1 a = new DataSet1();

            adapter.Fill(a, "Sales_report");

            ReportDataSource datasource = new ReportDataSource("DataSet1", a.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();



        }
    }
}
