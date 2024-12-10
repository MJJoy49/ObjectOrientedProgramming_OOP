namespace p3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            service = new Button();
            about = new Button();
            home = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(service);
            panel1.Controls.Add(about);
            panel1.Controls.Add(home);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 882);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.closeFill;
            pictureBox1.Location = new Point(97, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // service
            // 
            service.BackColor = SystemColors.ActiveCaption;
            service.Location = new Point(62, 568);
            service.Name = "service";
            service.Size = new Size(150, 46);
            service.TabIndex = 3;
            service.Text = "Service";
            service.UseVisualStyleBackColor = false;
            service.Click += service_Click;
            // 
            // about
            // 
            about.BackColor = SystemColors.ActiveCaption;
            about.Location = new Point(62, 394);
            about.Name = "about";
            about.Size = new Size(150, 46);
            about.TabIndex = 2;
            about.Text = "About";
            about.UseVisualStyleBackColor = false;
            about.Click += about_Click;
            // 
            // home
            // 
            home.BackColor = SystemColors.ActiveCaption;
            home.Location = new Point(62, 233);
            home.Name = "home";
            home.Size = new Size(150, 46);
            home.TabIndex = 1;
            home.Text = "HOME";
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(283, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1338, 882);
            panelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1621, 882);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button service;
        private Button about;
        private Button home;
        private PictureBox pictureBox1;
        private Panel panelContainer;
    }
}
