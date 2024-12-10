namespace P1
{
    public partial class Form1 : Form
    {
        Page1? P1;
        Page2? P2;

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
                P1.FormClosed += P1_FormClosed;
                P1.MdiParent = this;
                P1.Show();
            }
            else
            {
                P1.Activate();
            }
        }

        private void page2_Click(object sender, EventArgs e)
        {
            if (P2 == null)
            {
                P2 = new Page2();
                P2.FormClosed += P2_FormClosed;
                P2.MdiParent = this;
                P2.Show();
            }

            else
            {
                P2.Activate();
            }
        }

        private void P2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            P2 = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any initialization code for Form1 goes here
        }

        private void P1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            P1 = null;
        }

        private void page2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
