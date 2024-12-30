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
            service = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            about = new Button();
            home = new Button();
            panelContainer = new Panel();
            id = new TextBox();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(service);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(about);
            panel1.Controls.Add(home);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 882);
            panel1.TabIndex = 0;
            // 
            // service
            // 
            service.BackColor = SystemColors.ActiveCaption;
            service.Location = new Point(62, 538);
            service.Name = "service";
            service.Size = new Size(150, 46);
            service.TabIndex = 3;
            service.Text = "Service";
            service.UseVisualStyleBackColor = false;
            service.Click += service_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 658);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 85);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_plus_30;
            pictureBox2.Location = new Point(35, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(97, 26);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Total Income";
            label1.Click += label1_Click;
            label1.DoubleClick += label1_DoubleClick;
            label1.MouseHover += label1_MouseHover;
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
            panelContainer.BackColor = Color.FromArgb(40, 40, 40);
            panelContainer.Controls.Add(button1);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(name);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(id);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(283, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1338, 882);
            panelContainer.TabIndex = 1;
            // 
            // id
            // 
            id.Location = new Point(386, 272);
            id.Name = "id";
            id.Size = new Size(381, 39);
            id.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(396, 214);
            label2.Name = "label2";
            label2.Size = new Size(34, 32);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(396, 395);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // name
            // 
            name.Location = new Point(386, 453);
            name.Name = "name";
            name.Size = new Size(381, 39);
            name.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(489, 619);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button service;
        private Button about;
        private Button home;
        private PictureBox pictureBox1;
        private Panel panelContainer;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox id;
        private Button button1;
        private Label label3;
        private TextBox name;
        private Label label2;
    }
}
