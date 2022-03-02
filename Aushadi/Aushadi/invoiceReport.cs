using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class invoiceReport : UserControl
    {
        public invoiceReport()
        {
            InitializeComponent();
        }

        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RGNLB5\MSSQLSERVER01;Initial Catalog=collegeproject;Integrated Security=True");

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            if (selectionBox.Text == string.Empty)
            {
                MessageBox.Show("Please select a search category and enter search conditions", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectionBox.Text == "Search all")
            {
                try
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from Invoice_Master", conn);
                    DataTable dtbl = new DataTable();
                    dtAdapter.Fill(dtbl);
                    dgvReport.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (selectionBox.Text == "Search by invoice ID" && txtValuebox2.Text != string.Empty)
            {
                try
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from Invoice_Master WHERE InvoiceID =" + txtValuebox2.Text, conn);
                    DataTable dtbl = new DataTable();
                    dtAdapter.Fill(dtbl);
                    dgvReport.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (selectionBox.Text == "Search by total is higher than" && txtValuebox2.Text != string.Empty)
            {
                try
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from Invoice_Master WHERE NetAmount >" + txtValuebox2.Text, conn);
                    DataTable dtbl = new DataTable();
                    dtAdapter.Fill(dtbl);
                    dgvReport.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (selectionBox.Text == "Search by total is lower than" && txtValuebox2.Text != string.Empty)
            {
                try
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from Invoice_Master WHERE NetAmount <" + txtValuebox2.Text, conn);
                    DataTable dtbl = new DataTable();
                    dtAdapter.Fill(dtbl);
                    dgvReport.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("The value in condition field has not been entered.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectionBox_SelectedValueChanged(object sender, EventArgs e)
        {
            txtValuebox2.Visible = true;
        }

        private void txtValuebox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
