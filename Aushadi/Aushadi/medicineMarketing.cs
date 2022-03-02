using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class medicineMarketing : UserControl
    {

        int order = 1;
        double total = 0;
        private static medicineMarketing _instance;
        public static medicineMarketing Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new medicineMarketing();
                return _instance;
            }
        }
        public medicineMarketing()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RGNLB5\MSSQLSERVER01;Initial Catalog=collegeproject;Integrated Security=True");

        private void txtproductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private bool quantityCheck()
        {
            int databaseQuantity = 0;
            int quantity = 0;
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
                SqlCommand cmd = new SqlCommand(@"SELECT [productQuantity] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productName", txtproductName.Text);
                if (cmd.ExecuteScalar() == null)
                {
                    return false;
                }
                else
                {
                    if (selectionBox.Text == "Singular")
                    {
                        quantity = Convert.ToInt32(txtquantity.Text);
                    }
                    else if (selectionBox.Text == "Mass")
                    {
                        quantity = 10 * Convert.ToInt32(txtquantity.Text);
                    }
                    else
                    {
                        MessageBox.Show("Quantity has not been entered", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    databaseQuantity = (int)cmd.ExecuteScalar();
                    if (databaseQuantity >= quantity)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        private bool hasProduct(string name)
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
                SqlCommand cmd = new SqlCommand(@"SELECT [productName] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productName", name);
                if (cmd.ExecuteScalar() == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        private void quantityAddUpdate()
        {
            try
            {
                int selectionType = 0;
                if (selectionBox.Text == "Singular")
                {
                    selectionType = 1;
                }
                else if (selectionBox.Text == "Mass")
                {
                    selectionType = 10;
                }
                else
                {
                    MessageBox.Show("Selection type has not been selected");
                }
                SqlCommand cmd2 = new SqlCommand(@"SELECT [productQuantity] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@productName", txtproductName.Text);
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[productData] SET [productQuantity] = @productQuantity WHERE [productName] = @productName", conn);
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Open();
                }
                else
                {
                    conn.Open();
                }
                int quantity = (int)cmd2.ExecuteScalar();
                int selectedQuantity = Convert.ToInt32(txtquantity.Text);
                quantity = quantity - (selectionType * selectedQuantity);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productName", txtproductName.Text);
                cmd.Parameters.AddWithValue("@productQuantity", quantity);
                int a = (int)cmd.ExecuteNonQuery();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtproductName.Text == string.Empty || txtquantity.Text == string.Empty || txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Please enter the required fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasProduct(txtproductName.Text) == false)
            {
                MessageBox.Show("This product doesn't exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantityCheck() == false)
            {
                MessageBox.Show("Quantity of the product exceeds the registered amount", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] arr = new string[5];
                arr[0] = txtproductName.Text;
                arr[1] = selectionBox.Text;
                arr[2] = txtPrice.Text;
                arr[3] = txtquantity.Text;
                arr[4] = (Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(txtPrice.Text)).ToString();
                ListViewItem lvI = new ListViewItem(arr);
                listView1.Items.Add(lvI);
                if (txtTotal.Text == string.Empty)
                {
                    txtTotal.Text = "0";
                }
                quantityAddUpdate();
                txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + Convert.ToInt32(arr[4])).ToString();
                txtPrice.Text = string.Empty;
                txtproductName.Text = string.Empty;
                selectionBox.Text = string.Empty;
                txtquantity.Text = string.Empty;
            }
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void medicineMarketing_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new List<Receipt>();//Init empty list
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new Report.PrintInvoice().Show();
        }
        private void selectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtproductName.Text == string.Empty)
            {
                selectionBox.Text = string.Empty;
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasProduct(txtproductName.Text) == false)
            {
                MessageBox.Show("There is no product with the name entered", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand(@"SELECT [priceSingle] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("@productName", txtproductName.Text);
                    int priceSingle = (int)cmd2.ExecuteScalar();
                    SqlCommand cmd3 = new SqlCommand(@"SELECT [priceMass] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.AddWithValue("@productName", txtproductName.Text);
                    int priceMass = (int)cmd3.ExecuteScalar();
                    if (selectionBox.Text == "Mass")
                    {
                        txtPrice.Text = priceMass.ToString();
                    }
                    else
                    {
                        txtPrice.Text = priceSingle.ToString();
                    }
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
        }

        private void txtproductName_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtproductName_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT [productName] FROM [dbo].[productData]", conn);
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Open();
                }
                else
                {
                    conn.Open();
                }
                SqlDataReader dtRead = cmd.ExecuteReader();
                AutoCompleteStringCollection searchCollection = new AutoCompleteStringCollection();
                while (dtRead.Read())
                {
                    searchCollection.Add(dtRead.GetString(0));
                }
                txtproductName.AutoCompleteCustomSource = searchCollection;
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

        public void removeUpdate(string name, int selection, int quantity)
        {
            try
            {
                string productName = name;
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Open();
                }
                else
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(@"SELECT [productQuantity] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productName", @productName);
                int dbQuantity = (int)cmd.ExecuteScalar();
                SqlCommand cmd2 = new SqlCommand(@"UPDATE [dbo].[productData] SET [productQuantity] = " + (dbQuantity + (selection * quantity)) + " WHERE [productName] = " + productName + "", conn);
                cmd2.CommandType = CommandType.Text;
                if (cmd2.ExecuteScalar() == null)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    cmd2.ExecuteScalar();
                    MessageBox.Show("Added");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string productName;
            int selectionn, quantity = 0;
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        productName = listView1.Items[i].SubItems[0].Text.ToString();
                        if (listView1.Items[i].SubItems[1].Text == "Singular")
                        {
                            selectionn = 1;
                        }
                        else
                        {
                            selectionn = 10;
                        }
                        quantity = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                        txtTotal.Text = (Convert.ToInt32(txtTotal.Text) - Convert.ToInt32(listView1.Items[i].SubItems[4].Text)).ToString();
                        listView1.Items[i].Remove();
                    }

                }
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(txtTotal.Text);
            int cash;
            if (txtCash.Text == string.Empty)
            {
                cash = 0;
            }
            else
            {
                cash = Convert.ToInt32(txtCash.Text);
            }
            int balance = cash - total;
            txtBalance.Text = balance.ToString();
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
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
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Invoice_Master] ([InvoiceDate],[NetAmount],[PaidAmount]) VALUES " + " (getdate(),@netAmount,@paidAmount) select scope_identity()", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@netAmount", txtTotal.Text);
                    cmd.Parameters.AddWithValue("@paidAmount", txtCash.Text);
                    string invoiceID = cmd.ExecuteScalar().ToString();
                    foreach (ListViewItem ListItem in listView1.Items)
                    {
                        SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[Invoice_Detail] ([MasterID],[ItemName],[ItemPrice],[ItemQuantity],[ItemTotal],[Selection]) VALUES " + " (" + invoiceID + ",'" + ListItem.SubItems[0].Text + "'," + ListItem.SubItems[2].Text + "," + ListItem.SubItems[3].Text + "," + ListItem.SubItems[4].Text + ",'" + ListItem.SubItems[1].Text + "')", conn);
                        cmd2.CommandType = CommandType.Text;
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Sale Saved Successfully. Invoice ID =" + invoiceID, "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("No item has been addded", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
