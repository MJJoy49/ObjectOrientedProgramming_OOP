using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Populate comboBox with nationality options
            string[] nation = new string[] { " ", "Bangladesh", "India", "USA" };
            comboBox1.DataSource = nation;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Gender selection logic
            string gender = "No Selection";
            if (Male.Checked) gender = Male.Text;
            else if (Female.Checked) gender = Female.Text;
            else if (Other.Checked) gender = Other.Text;

            // Get input values
            string name = NameTB.Text;
            string studentId = IdTB.Text;
            string dob = DTP.Value.ToString("yyyy-MM-dd");
            string nationality = comboBox1.Text;
            string address = AddTextBox.Text;

            // Connection string
            string connectionString = @"Data Source=DESKTOP-M4S4J3H\SQLEXPRESS;Initial Catalog=MM;Integrated Security=True";

            // SQL query to insert data
            string sql = "INSERT INTO student (Name, StudentID, DOB, Gender, Nationality, Address) VALUES (@Name, @StudentID, @DOB, @Gender, @Nationality, @Address)";

            try
            {
                // Create and open the connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Create the SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Nationality", nationality);
                        cmd.Parameters.AddWithValue("@Address", address);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Show success message
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
