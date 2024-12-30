namespace Flab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTB.Text == "123" && passwordTB.Text == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                this.Visible = false;
                adminPanel.Show();
            }

            else 
            {
                MessageBox.Show("id or password wrong");
            }
        }
    }
}
