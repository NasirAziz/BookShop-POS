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
            DataTable a = new DataTable();

            adapter.Fill(a);

            ReportDataSource datasource = new ReportDataSource("DataSet1", a);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();



        }
    }
}
