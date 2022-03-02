using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class UserDataControl : UserControl
    {
        public UserDataControl()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RGNLB5\MSSQLSERVER01;Initial Catalog=collegeproject;Integrated Security=True");
        private void UserDataControl_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
        private bool hasuser()
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
                SqlCommand cmd = new SqlCommand(@"SELECT [userName] FROM [dbo].[userData] WHERE [userName] = @userName", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
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
        private bool hasUserByID()
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
                SqlCommand cmd = new SqlCommand(@"SELECT [userName] FROM [dbo].[userData] WHERE [userID] = @userID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userID", txtUserID.Text);
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
        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            if (txtUserID.Text == string.Empty || txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasuser() == true || hasUserByID() == true)
            {

                MessageBox.Show("There is already a user with this username or ID. Please use different values", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be of at least 6 characters", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string userPassword = txtUserPassword.Text;
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[userData] ([userID],[userName],[userPassword]) VALUES (@userID,@userName,@userPassword)", conn);
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
                    cmd.Parameters.AddWithValue("@userID", Convert.ToInt32(txtUserID.Text));
                    cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@userPassword", userPassword);
                    int a = cmd.ExecuteNonQuery();
                    if (a == 0)
                    {
                        MessageBox.Show("Unsuccessful during execution of query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("User data has been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == string.Empty || txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasuser() == false || hasUserByID() == false)
            {
                MessageBox.Show("There is no user with this username or ID.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be of at least 6 characters.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[userData] SET [userPassword] = @userPassword WHERE [userName] = @userName", conn);
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
                    cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@userPassword", txtUserPassword.Text);
                    int a = cmd.ExecuteNonQuery();
                    if (a == 0)
                    {
                        MessageBox.Show("No success");
                    }
                    else
                    {
                        MessageBox.Show("Success");
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

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user data?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtUserID.Text == string.Empty || txtUserName.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUserName.Text == "admin")
                {
                    MessageBox.Show("Admin cannot be deleted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (hasuser() == false || hasUserByID() == false)
                {
                    MessageBox.Show("There is no user with this username or ID", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[userData] WHERE [userName] = @userName", conn);
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
                        cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                        int a = cmd.ExecuteNonQuery();
                        if (a == 0)
                        {
                            MessageBox.Show("There is no user with this username");
                        }
                        else
                        {
                            MessageBox.Show("The data of " + txtUserName.Text.ToUpper() + " has been deleted.");
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
            else if (result == DialogResult.No)
            {
                MessageBox.Show("The user data has not been deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }
        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT [userName] FROM [dbo].[userData]", conn);
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
                txtUserName.AutoCompleteCustomSource = searchCollection;
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

        private void btnSerachFromUsername_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the required Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasuser() == false)
            {
                txtUserID.Text = string.Empty;
                try
                {
                    string query = "SELECT MIN(userID)+1 from userData WHERE userID+1 NOT IN (Select userID from userData)";
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
                    lblRecommend.Visible = true;
                    lblRecommend.Text = "Recommended ID =" + recc.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                MessageBox.Show("The user with this name doesn't exist", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(@"SELECT [userID] FROM [dbo].[userData] WHERE [userName] = @userName", conn);
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
                    cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                    if (cmd.ExecuteScalar() == null)
                    {

                        MessageBox.Show("There is user with this name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int userID = (int)cmd.ExecuteScalar();
                        txtUserID.Text = userID.ToString();
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
    }
}
