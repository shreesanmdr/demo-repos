using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class reportControl : UserControl
    {
        public reportControl()
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData", conn);
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
            else if (selectionBox.Text == "Search price@1 greater than" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE priceSingle >" + txtValuebox2.Text, conn);
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
            else if (selectionBox.Text == "Search price@1 lower than" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE priceSingle <" + txtValuebox2.Text, conn);
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
            else if (selectionBox.Text == "Search price@10 greater than" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE priceMass >" + txtValuebox2.Text, conn);
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
            else if (selectionBox.Text == "Search price@10 lower than" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE priceMass <" + txtValuebox2.Text, conn);
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
            else if (selectionBox.Text == "Search quantity is more than" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE productQuantity >" + txtValuebox2.Text, conn);
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
            else if (selectionBox.Text == "Search quantity is lesser than" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE productQuantity <" + txtValuebox2.Text, conn);
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
            else if (selectionBox.Text == "Search by price@10 is greater than price @1 by" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE priceMass > " + txtValuebox2.Text + "*priceSingle", conn);
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
            else if (selectionBox.Text == "Search by price@10 is lower than price @1 by" && txtValuebox2.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE priceMass < " + txtValuebox2.Text + "*priceSingle", conn);
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
            else if (selectionBox.Text == "Search by name contains" && txtValuebox1.Text != string.Empty)
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
                    SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * from productData WHERE productName LIKE '%" + txtValuebox1.Text + "%'", conn);
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
            if (selectionBox.SelectedIndex == 1 || selectionBox.SelectedIndex == 2 || selectionBox.SelectedIndex == 3 || selectionBox.SelectedIndex == 4 || selectionBox.SelectedIndex == 5 || selectionBox.SelectedIndex == 6 || selectionBox.SelectedIndex == 7 || selectionBox.SelectedIndex == 8)
            {
                txtValuebox1.Visible = false;
                txtValuebox2.Visible = true;
            }
            else
            {
                txtValuebox2.Visible = false;
                txtValuebox1.Visible = true;
            }
        }

        private void txtValuebox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }

        private void txtValuebox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValuebox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
