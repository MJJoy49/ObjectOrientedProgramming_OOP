namespace P1
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
            closeButton = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Page1 = new Button();
            page2 = new Button();
            page3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(closeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1688, 90);
            panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.Image = Properties.Resources.close;
            closeButton.Location = new Point(1619, 19);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(45, 48);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.TabIndex = 0;
            closeButton.TabStop = false;
            closeButton.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel1.Controls.Add(Page1);
            flowLayoutPanel1.Controls.Add(page2);
            flowLayoutPanel1.Controls.Add(page3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 90);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 991);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Page1
            // 
            Page1.AccessibleRole = AccessibleRole.None;
            Page1.Font = new Font("Roboto Slab", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page1.Location = new Point(5, 5);
            Page1.Margin = new Padding(5);
            Page1.Name = "Page1";
            Page1.Size = new Size(347, 96);
            Page1.TabIndex = 2;
            Page1.Text = "page1";
            Page1.UseVisualStyleBackColor = true;
            Page1.Click += Page1_Click;
            // 
            // page2
            // 
            page2.Font = new Font("Roboto Slab", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page2.Location = new Point(5, 111);
            page2.Margin = new Padding(5);
            page2.Name = "page2";
            page2.Size = new Size(347, 96);
            page2.TabIndex = 3;
            page2.Text = "page2";
            page2.UseVisualStyleBackColor = true;
            // 
            // page3
            // 
            page3.Font = new Font("Roboto Slab", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page3.Location = new Point(5, 217);
            page3.Margin = new Padding(5);
            page3.Name = "page3";
            page3.Size = new Size(347, 96);
            page3.TabIndex = 4;
            page3.Text = "page3";
            page3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 1081);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox closeButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Page1;
        private Button page2;
        private Button page3;
    }
}
