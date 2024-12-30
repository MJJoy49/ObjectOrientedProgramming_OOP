namespace Flab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nameLabel = new Label();
            pictureBox1 = new PictureBox();
            idTB = new TextBox();
            passwordTB = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Century", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(330, 150);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 33);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_25;
            pictureBox1.Location = new Point(270, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // idTB
            // 
            idTB.Location = new Point(330, 198);
            idTB.Name = "idTB";
            idTB.Size = new Size(362, 39);
            idTB.TabIndex = 2;
            idTB.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(330, 362);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(362, 39);
            passwordTB.TabIndex = 5;
            passwordTB.TextAlign = HorizontalAlignment.Center;
            passwordTB.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(270, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(330, 314);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(416, 470);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1003, 736);
            Controls.Add(button1);
            Controls.Add(passwordTB);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(idTB);
            Controls.Add(pictureBox1);
            Controls.Add(nameLabel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private PictureBox pictureBox1;
        private TextBox idTB;
        private TextBox passwordTB;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
    }
}
