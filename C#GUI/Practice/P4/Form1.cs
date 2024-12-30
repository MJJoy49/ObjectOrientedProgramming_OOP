namespace P4
{
    public partial class Form1 : Form
    {
        private Point startLocation = new Point(125, 173);
        private Point endLocation = new Point(894, 173);
        private Size startSize = new Size(795, 153);
        private Size endSize = new Size(15, 153);
        private int steps = 120; // Total steps (8 seconds / 50ms interval)
        private int currentStep = 0;
        private float deltaWidth;
        private float deltaX;

        public Form1()
        {
            InitializeComponent();

            // Set initial size and location for AnimationPanel
            AnimationPanel.Size = startSize;
            AnimationPanel.Location = startLocation;

            // Calculate step values for size and location
            deltaWidth = (float)(endSize.Width - startSize.Width) / steps;
            deltaX = (float)(endLocation.X - startLocation.X) / steps;

            timer1.Interval = 50; // Set timer interval to 50ms
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentStep < steps)
            {
                // Update size and location incrementally
                AnimationPanel.Size = new Size(
                    (int)(startSize.Width + deltaWidth * currentStep),
                    startSize.Height
                );
                AnimationPanel.Location = new Point(
                    (int)(startLocation.X + deltaX * currentStep),
                    startLocation.Y
                );
                currentStep++;
            }
            else
            {
                // Stop the timer when the animation is complete
                timer1.Stop();
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Animation for pictureBox1 is canceled
        }

        private void AnimationPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom drawing logic here if needed
        }
    }
}
