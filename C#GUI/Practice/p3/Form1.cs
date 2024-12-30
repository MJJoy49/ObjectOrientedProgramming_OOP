namespace p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserHome home = new UserHome();
            addUserControl(home);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void home_Click(object sender, EventArgs e)
        {
            UserHome home = new UserHome();
            addUserControl(home);
        }

        private void about_Click(object sender, EventArgs e)
        {
            UserAbout about = new UserAbout();
            addUserControl(about);
        }

        private void service_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            addUserControl(service);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("this is siam");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");

        }
    }
}
