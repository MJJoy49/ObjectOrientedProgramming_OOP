using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NewDatabase1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            
                try
                {
                    sqlConnection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE UserId = @UserId AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", txtUserId.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                        int count = (int)cmd.ExecuteScalar();
                        lblMsg.Text = count > 0 ? "Welcome to the world" : "-_-";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}