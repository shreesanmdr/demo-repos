using Microsoft.Reporting.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aushadi.Report
{
    public partial class PrintInvoice : Form
    {
        public PrintInvoice()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RGNLB5\MSSQLSERVER01;Initial Catalog=collegeproject;Integrated Security=True");

        private void PrintInvoice_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from View_All_Bill_Test where InvoiceID = '" + txtInvoiceID.Text + "'", conn);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable_Invoice");
            ReportDataSource dataSource = new ReportDataSource("DataSet_Report");
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.Refresh();
        }
    }
}
