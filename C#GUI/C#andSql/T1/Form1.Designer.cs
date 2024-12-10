namespace T1
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
            name = new Label();
            userName = new Label();
            nameTextBox = new TextBox();
            UserNametextBox = new TextBox();
            saveInfo = new Button();
            InfoData = new DataGridView();
            showData = new Button();
            ((System.ComponentModel.ISupportInitialize)InfoData).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(142, 24);
            name.Name = "name";
            name.Size = new Size(208, 71);
            name.TabIndex = 0;
            name.Text = "Name :";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.Location = new Point(16, 116);
            userName.Name = "userName";
            userName.Size = new Size(334, 71);
            userName.TabIndex = 1;
            userName.Text = "User Name :";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(356, 31);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(372, 65);
            nameTextBox.TabIndex = 2;
            // 
            // UserNametextBox
            // 
            UserNametextBox.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNametextBox.Location = new Point(356, 122);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(372, 65);
            UserNametextBox.TabIndex = 3;
            // 
            // saveInfo
            // 
            saveInfo.BackColor = SystemColors.ControlDark;
            saveInfo.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveInfo.ForeColor = SystemColors.Info;
            saveInfo.Location = new Point(768, 68);
            saveInfo.Name = "saveInfo";
            saveInfo.Size = new Size(206, 79);
            saveInfo.TabIndex = 4;
            saveInfo.Text = "Save";
            saveInfo.UseVisualStyleBackColor = false;
            saveInfo.Click += saveInfo_Click;
            // 
            // InfoData
            // 
            InfoData.BackgroundColor = Color.Silver;
            InfoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoData.GridColor = SystemColors.GradientActiveCaption;
            InfoData.Location = new Point(94, 265);
            InfoData.Name = "InfoData";
            InfoData.RowHeadersWidth = 82;
            InfoData.Size = new Size(1349, 826);
            InfoData.TabIndex = 5;
            // 
            // showData
            // 
            showData.BackColor = SystemColors.ControlDark;
            showData.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showData.ForeColor = SystemColors.Info;
            showData.Location = new Point(1039, 68);
            showData.Name = "showData";
            showData.Size = new Size(325, 79);
            showData.TabIndex = 6;
            showData.Text = "Show Data";
            showData.UseVisualStyleBackColor = false;
            showData.Click += showData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1549, 1164);
            Controls.Add(showData);
            Controls.Add(InfoData);
            Controls.Add(saveInfo);
            Controls.Add(UserNametextBox);
            Controls.Add(nameTextBox);
            Controls.Add(userName);
            Controls.Add(name);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)InfoData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label userName;
        private TextBox nameTextBox;
        private TextBox UserNametextBox;
        private Button saveInfo;
        private DataGridView InfoData;
        private Button showData;
    }
}
