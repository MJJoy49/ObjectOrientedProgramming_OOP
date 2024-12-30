namespace FLab1
{
    partial class Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(207, 199);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(880, 372);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 858);
            Controls.Add(richTextBox1);
            Name = "Details";
            Text = "Details";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}