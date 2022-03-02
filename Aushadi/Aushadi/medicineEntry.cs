using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class medicineEntry : UserControl
    {
        private static medicineEntry _instance;
        public static medicineEntry Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new medicineEntry();
                return _instance;
            }
        }
        public medicineEntry()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-5RGNLB5;Initial Catalog=CollegeProjectDB;Integrated Security=True";
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RGNLB5\MSSQLSERVER01;Initial Catalog=collegeproject;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid() == false || txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasProduct(txtProductName.Text) == true || hasProductByID() == true)
            {
                MessageBox.Show("A product with this name/ID already exists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[productData] ([productID],[productName],[priceSingle],[priceMass],[productQuantity]) VALUES (@productID,@productName,@priceSingle,@priceMass,@productQuantity)", conn);
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@productID", Convert.ToInt32(txtMedicineID.Text));
                    cmd.Parameters.AddWithValue("@productName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@priceSingle", Convert.ToInt32(txtSinglePrice.Text));
                    cmd.Parameters.AddWithValue("@priceMass", Convert.ToInt32(txtMassPrice.Text));
                    cmd.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(txtQuantity.Text));
                    int a = cmd.ExecuteNonQuery();
                    if (a == 0)
                    {
                        MessageBox.Show("Item not added.Query is not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Item has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool isValid()
        {
            if (txtProductName.Text == string.Empty || txtSinglePrice.Text == string.Empty || txtMassPrice.Text == string.Empty)
            {
                return false;
            }
            return true;
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
        private bool hasProductByID()
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
                SqlCommand cmd = new SqlCommand(@"SELECT [productName] FROM [dbo].[productData] WHERE [productID] = @productID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@productID", txtMedicineID.Text);
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

        private void txtMedicineID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSinglePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMassPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isValid() || txtProductUpdt.Text == string.Empty || txtMedicineID.Text == string.Empty || txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasProduct(txtProductName.Text) == false || hasProductByID() == false)
            {
                MessageBox.Show("A product with this name or ID doesn't exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasProduct(txtProductUpdt.Text) == true)
            {
                MessageBox.Show("The name cannot be updated as there is already a product with this name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[productData] SET [productName] = @productUpdtName,[priceSingle] = @priceSingle,[priceMass] = @priceMass,[productQuantity] = @productQuantity WHERE [productID] = @productID", conn);
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@productID", Convert.ToInt32(txtMedicineID.Text));
                    cmd.Parameters.AddWithValue("@productUpdtName", txtProductUpdt.Text);
                    cmd.Parameters.AddWithValue("@priceSingle", Convert.ToInt32(txtSinglePrice.Text));
                    cmd.Parameters.AddWithValue("@priceMass", Convert.ToInt32(txtMassPrice.Text));
                    cmd.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(txtQuantity.Text));
                    int a = cmd.ExecuteNonQuery();
                    if (a == 0)
                    {
                        MessageBox.Show("Item cannot be updated due to query problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Item has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                if (txtMedicineID.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (hasProductByID() == false)
                {
                    MessageBox.Show("A product with this ID doesn't exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[productData] WHERE [productID] = @productID", conn);
                        if (conn.State != ConnectionState.Closed)
                        {
                            conn.Close();
                            conn.Open();
                        }
                        else
                        {
                            conn.Open();
                        }
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@productID", Convert.ToInt32(txtMedicineID.Text));
                        int a = cmd.ExecuteNonQuery();
                        if (a == 0)
                        {
                            MessageBox.Show("Item not found in the database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Item has been deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("The data has not been deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void medicineEntry_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void btnSearchFromID_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasProductByID() == false)
            {
                MessageBox.Show("There is no product with this ID", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int productQuantity, priceSingle, priceMass = 0;
                    string productName;
                    SqlCommand cmd = new SqlCommand(@"SELECT [productName] FROM [dbo].[productData] WHERE [productID] = @productID", conn);
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@productID", Convert.ToInt32(txtMedicineID.Text));
                    productName = (string)cmd.ExecuteScalar();
                    SqlCommand cmd2 = new SqlCommand(@"SELECT [priceSingle] FROM [dbo].[productData] WHERE [productID] = @productID", conn);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("@productID", Convert.ToInt32(txtMedicineID.Text));
                    if (cmd2.ExecuteScalar() == null)
                    {
                        priceSingle = 0;
                    }
                    else
                    {
                        priceSingle = (int)cmd2.ExecuteScalar();
                    }
                    SqlCommand cmd3 = new SqlCommand(@"SELECT [priceMass] FROM [dbo].[productData] WHERE [productID] = @productID", conn);
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.AddWithValue("@productID", Convert.ToInt32(txtMedicineID.Text));
                    if (cmd3.ExecuteScalar() == null)
                    {
                        priceMass = 0;
                    }
                    else
                    {
                        priceMass = (int)cmd3.ExecuteScalar();
                    }
                    SqlCommand cmd4 = new SqlCommand(@"SELECT [productQuantity] FROM [dbo].[productData] WHERE [productID] = @productID", conn);
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Parameters.AddWithValue("@productID", txtMedicineID.Text);
                    if (cmd4.ExecuteScalar() == null)
                    {
                        productQuantity = 0;
                    }
                    else
                    {
                        productQuantity = (int)cmd4.ExecuteScalar();
                    }
                    if (productName.Length == 0 || priceSingle == 0 || priceMass == 0)
                    {

                        MessageBox.Show("There is product with this ID", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtProductName.Text = productName;
                        txtSinglePrice.Text = priceSingle.ToString();
                        txtMassPrice.Text = priceMass.ToString();
                        txtQuantity.Text = productQuantity.ToString();
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

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasProduct(txtProductName.Text) == false)
            {
                try
                {
                    string query = "SELECT MIN(productID)+1 from productData WHERE productID+1 NOT IN (Select productID from productData)";
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    int recc = (int)cmd.ExecuteScalar();
                    lblRequired.Visible = true;
                    lblRequired.Text = "Recommended ID =" + recc.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                MessageBox.Show("There is no product with this name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int productQuantity, productID, priceSingle, priceMass = 0;
                    SqlCommand cmd = new SqlCommand(@"SELECT [productID] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@productName", txtProductName.Text);
                    if (cmd.ExecuteScalar() == null)
                    {
                        productID = 0;
                    }
                    else
                    {
                        productID = (int)cmd.ExecuteScalar();
                    }
                    SqlCommand cmd2 = new SqlCommand(@"SELECT [priceSingle] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("@productName", txtProductName.Text);
                    if (cmd2.ExecuteScalar() == null)
                    {
                        priceSingle = 0;
                    }
                    else
                    {
                        priceSingle = (int)cmd2.ExecuteScalar();
                    }
                    SqlCommand cmd3 = new SqlCommand(@"SELECT [priceMass] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.AddWithValue("@productName", txtProductName.Text);
                    if (cmd3.ExecuteScalar() == null)
                    {
                        priceMass = 0;
                    }
                    else
                    {
                        priceMass = (int)cmd3.ExecuteScalar();
                    }
                    SqlCommand cmd4 = new SqlCommand(@"SELECT [productQuantity] FROM [dbo].[productData] WHERE [productName] = @productName", conn);
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Parameters.AddWithValue("@productName", txtProductName.Text);
                    if (cmd4.ExecuteScalar() == null)
                    {
                        productQuantity = 0;
                    }
                    else
                    {
                        productQuantity = (int)cmd4.ExecuteScalar();
                    }
                    if (productID == 0 || priceSingle == 0 || priceMass == 0)
                    {
                        MessageBox.Show("There is product with this name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtMedicineID.Text = productID.ToString();
                        txtSinglePrice.Text = priceSingle.ToString();
                        txtMassPrice.Text = priceMass.ToString();
                        txtQuantity.Text = productQuantity.ToString();
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

        private void txtProductName_MouseClick(object sender, MouseEventArgs e)
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
                txtProductName.AutoCompleteCustomSource = searchCollection;
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
}
