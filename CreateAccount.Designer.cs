namespace WinFormsApp1
{
    partial class CreateAccount
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
            createNewAccount = new Button();
            label2 = new Label();
            newPasswordTextbox = new TextBox();
            label1 = new Label();
            newEmailTextbox = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            nameLabel = new Label();
            newNameTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // createNewAccount
            // 
            createNewAccount.BackColor = Color.FromArgb(251, 217, 21);
            createNewAccount.FlatStyle = FlatStyle.Popup;
            createNewAccount.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createNewAccount.ForeColor = Color.FromArgb(0, 88, 171);
            createNewAccount.Location = new Point(72, 353);
            createNewAccount.Name = "createNewAccount";
            createNewAccount.Size = new Size(198, 50);
            createNewAccount.TabIndex = 15;
            createNewAccount.Text = "Create Account";
            createNewAccount.UseVisualStyleBackColor = false;
            createNewAccount.Click += createNewAccount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 251);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // newPasswordTextbox
            // 
            newPasswordTextbox.BackColor = Color.FromArgb(251, 217, 21);
            newPasswordTextbox.BorderStyle = BorderStyle.None;
            newPasswordTextbox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordTextbox.ForeColor = Color.FromArgb(0, 88, 171);
            newPasswordTextbox.Location = new Point(12, 278);
            newPasswordTextbox.Name = "newPasswordTextbox";
            newPasswordTextbox.PasswordChar = '*';
            newPasswordTextbox.Size = new Size(318, 29);
            newPasswordTextbox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 179);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 12;
            label1.Text = "Email";
            // 
            // newEmailTextbox
            // 
            newEmailTextbox.BackColor = Color.FromArgb(251, 217, 21);
            newEmailTextbox.BorderStyle = BorderStyle.None;
            newEmailTextbox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newEmailTextbox.ForeColor = Color.FromArgb(0, 88, 171);
            newEmailTextbox.Location = new Point(12, 206);
            newEmailTextbox.Name = "newEmailTextbox";
            newEmailTextbox.Size = new Size(318, 29);
            newEmailTextbox.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ikea_logo;
            pictureBox2.Location = new Point(111, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_oliver_atherton_19353445;
            pictureBox1.Location = new Point(345, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(12, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 24);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Name";
            // 
            // newNameTextbox
            // 
            newNameTextbox.BackColor = Color.FromArgb(251, 217, 21);
            newNameTextbox.BorderStyle = BorderStyle.None;
            newNameTextbox.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newNameTextbox.ForeColor = Color.FromArgb(0, 88, 171);
            newNameTextbox.Location = new Point(12, 136);
            newNameTextbox.Name = "newNameTextbox";
            newNameTextbox.Size = new Size(318, 29);
            newNameTextbox.TabIndex = 16;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 88, 171);
            ClientSize = new Size(619, 450);
            Controls.Add(nameLabel);
            Controls.Add(newNameTextbox);
            Controls.Add(createNewAccount);
            Controls.Add(label2);
            Controls.Add(newPasswordTextbox);
            Controls.Add(label1);
            Controls.Add(newEmailTextbox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel createAccountButton;
        private Label label3;
        private Button loginButton;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox newEmailTextbox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label nameLabel;
        private TextBox newNameTextbox;
        private TextBox newPasswordTextbox;
        private Button createNewAccount;
    }
}