namespace FLab1
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
            label1 = new Label();
            NameTB = new TextBox();
            IdTB = new TextBox();
            IdLabel = new Label();
            SubmitBtn = new Button();
            DOB = new Label();
            DTP = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            Add = new Label();
            AddTextBox = new RichTextBox();
            Male = new RadioButton();
            Female = new RadioButton();
            Other = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 133);
            label1.Name = "label1";
            label1.Size = new Size(93, 37);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // NameTB
            // 
            NameTB.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTB.Location = new Point(436, 134);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(401, 43);
            NameTB.TabIndex = 1;
            NameTB.TextAlign = HorizontalAlignment.Center;
            // 
            // IdTB
            // 
            IdTB.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdTB.Location = new Point(436, 252);
            IdTB.Name = "IdTB";
            IdTB.Size = new Size(401, 43);
            IdTB.TabIndex = 3;
            IdTB.TextAlign = HorizontalAlignment.Center;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdLabel.Location = new Point(302, 251);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(46, 37);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "ID";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(751, 907);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(150, 46);
            SubmitBtn.TabIndex = 4;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // DOB
            // 
            DOB.AutoSize = true;
            DOB.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DOB.Location = new Point(302, 353);
            DOB.Name = "DOB";
            DOB.Size = new Size(74, 37);
            DOB.TabIndex = 5;
            DOB.Text = "DOB";
            // 
            // DTP
            // 
            DTP.Location = new Point(436, 353);
            DTP.Name = "DTP";
            DTP.Size = new Size(400, 39);
            DTP.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 448);
            label2.Name = "label2";
            label2.Size = new Size(110, 37);
            label2.TabIndex = 7;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 541);
            label3.Name = "label3";
            label3.Size = new Size(162, 37);
            label3.TabIndex = 11;
            label3.Text = "Nationality";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(498, 538);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 40);
            comboBox1.TabIndex = 13;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(302, 643);
            Add.Name = "Add";
            Add.Size = new Size(120, 37);
            Add.TabIndex = 14;
            Add.Text = "Address";
            // 
            // AddTextBox
            // 
            AddTextBox.Location = new Point(498, 653);
            AddTextBox.Name = "AddTextBox";
            AddTextBox.Size = new Size(627, 192);
            AddTextBox.TabIndex = 15;
            AddTextBox.Text = "";
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(451, 448);
            Male.Name = "Male";
            Male.Size = new Size(98, 36);
            Male.TabIndex = 16;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(600, 448);
            Female.Name = "Female";
            Female.Size = new Size(122, 36);
            Female.TabIndex = 17;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            Other.AutoSize = true;
            Other.Location = new Point(760, 448);
            Other.Name = "Other";
            Other.Size = new Size(106, 36);
            Other.TabIndex = 18;
            Other.TabStop = true;
            Other.Text = "Other";
            Other.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1393, 1076);
            Controls.Add(Other);
            Controls.Add(Female);
            Controls.Add(Male);
            Controls.Add(AddTextBox);
            Controls.Add(Add);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DTP);
            Controls.Add(DOB);
            Controls.Add(SubmitBtn);
            Controls.Add(IdTB);
            Controls.Add(IdLabel);
            Controls.Add(NameTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTB;
        private TextBox IdTB;
        private Label IdLabel;
        private Button SubmitBtn;
        private Label DOB;
        private DateTimePicker DTP;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label Add;
        private RichTextBox AddTextBox;
        private RadioButton Male;
        private RadioButton Female;
        private RadioButton Other;
    }
}
