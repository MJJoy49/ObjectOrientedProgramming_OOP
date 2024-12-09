namespace P1
{
    public partial class Form1 : Form
    {
        Page1? P1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Page1_Click(object sender, EventArgs e)
        {

            if (P1 == null)
            {
                P1 = new Page1();
                P1.Location = new Point(370, 100);
                P1.FormClosed += P1_FormClosed;
                P1.MdiParent = this;
                P1.Show();
            }
            else
            {
                P1.Activate();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void P1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            P1 = null;
        }
    }
}
