using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class logIn : UserControl
    {
        private static logIn _instance;
        public static logIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new logIn();
                return _instance;
            }
        }
        public Button _logIn
        {
            get
            {
                return btnLogIN;
            }
            set
            {
                btnLogIN = value;
            }
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
                cmd.Parameters.AddWithValue("@username", txtUsrName.Text);
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
        private bool checkFormOpen()
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == "adminForm" || frm.Text == "userForm")
                {
                    return true;
                }
            }
            return false;
        }
        public logIn()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5RGNLB5\MSSQLSERVER01;Initial Catalog=collegeproject;Integrated Security=True");
        private void btnLogIN_Click(object sender, EventArgs e)
        {
            if (checkFormOpen() == true)
            {
                MessageBox.Show("Please close other windows before logging in", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsrName.Text == string.Empty || txtUsrPassword.Text == string.Empty)
            {
                txtUsrPassword.Text = string.Empty;
                MessageBox.Show("Enter required datas", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hasuser() == false)
            {
                MessageBox.Show("Invalid data entered", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT [userPassword] FROM [dbo].[userData] WHERE [userName] = @userName", conn);
                    SqlCommand cmd2 = new SqlCommand("SELECT [userID] FROM [dbo].[userData] WHERE [userName] = @userName", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@userName", txtUsrName.Text);
                    cmd2.Parameters.AddWithValue("@userName", txtUsrName.Text);
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else
                    {
                        conn.Open();
                    }
                    string password = (string)cmd.ExecuteScalar();
                    int userID = (int)cmd2.ExecuteScalar();
                    conn.Close();
                    if (txtUsrPassword.Text == password && userID == 1)
                    {
                        adminForm adfrm = new adminForm();
                        adfrm.Show();
                        txtUsrName.Text = "";
                        txtUsrPassword.Text = "";
                    }
                    else if (txtUsrPassword.Text == password && userID != 1)
                    {
                        userForm usrForm = new userForm();
                        usrForm.Show(); ;
                        txtUsrName.Text = "";
                        txtUsrPassword.Text = "";
                    }
                    else
                    {
                        txtUsrPassword.Text = "";
                        MessageBox.Show("Invalid data");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtUsrPassword.Text = "";
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
