using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;



namespace T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveInfo_Click(object sender, EventArgs e)
        {
            //address of SQL server and database
            string connnectionDB = "Data Source=DESKTOP-M4S4J3H\\SQLEXPRESS;Initial Catalog=joydb;Integrated Security=True;Trust Server Certificate=True";


            //establish connection add->(using System.Data.SqlClient;)
            SqlConnection con = new SqlConnection(connnectionDB);



            //open connection
            con.Open();




            //prepare query
            string name = nameTextBox.Text;
            string username = UserNametextBox.Text;
            string query = $"INSERT INTO Info (Name, UserName) VALUES ('{name}', '{username}');";


            //execute query
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();


            //close connection
            con.Close();


            MessageBox.Show("data has been save.");
        }

        private void showData_Click(object sender, EventArgs e)
        {
            //address of SQL server and database
            string connnectionDB = "Data Source=DESKTOP-M4S4J3H\\SQLEXPRESS;Initial Catalog=joydb;Integrated Security=True;Trust Server Certificate=True";


            //establish connection add->(using System.Data.SqlClient;)
            SqlConnection con = new SqlConnection(connnectionDB);

            //open connection
            con.Open();


            //prepare query
            string query = $"select * from Info;";
            SqlCommand cmd = new SqlCommand(query, con);


            //execute query
            var reader=cmd.ExecuteReader();
            DataTable dataTable=new DataTable();

            dataTable.Load(reader);
            InfoData.DataSource = dataTable;


            //close connection
            con.Close();


        }
    }
}
