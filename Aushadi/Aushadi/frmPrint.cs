using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Aushadi
{
    public partial class frmPrint : Form
    {
        List<Receipt> _list;
        private BindingSource ReceiptBindingSource;
        public frmPrint(BindingSource receiptBindingSource)
        {
            ReceiptBindingSource = receiptBindingSource;
        }

        string _total, _cash, _change, _date;
        public frmPrint(List<Receipt> dataSource, string total, string cash, string change, string date)
        {
            InitializeComponent();
            _list = dataSource;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                new Microsoft.Reporting.WinForms.ReportParameter("ptotal", _total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash", _cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange", _change),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                };
                this.reportViewer.LocalReport.SetParameters(para);
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
