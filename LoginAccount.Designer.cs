namespace WinFormsApp1
{
    partial class LoginAccount
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            label3 = new Label();
            createAccountButton = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_oliver_atherton_19353445;
            pictureBox1.Location = new Point(346, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ikea_logo;
            pictureBox2.Location = new Point(112, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(251, 217, 21);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 88, 171);
            textBox1.Location = new Point(12, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 29);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(251, 217, 21);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(0, 88, 171);
            textBox2.Location = new Point(12, 214);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(318, 29);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(251, 217, 21);
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(0, 88, 171);
            loginButton.Location = new Point(112, 279);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(117, 50);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(47, 371);
            label3.Name = "label3";
            label3.Size = new Size(249, 24);
            label3.TabIndex = 7;
            label3.Text = "Don't have an account yet?";
            // 
            // createAccountButton
            // 
            createAccountButton.AutoSize = true;
            createAccountButton.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createAccountButton.LinkColor = Color.Yellow;
            createAccountButton.Location = new Point(115, 395);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(114, 24);
            createAccountButton.TabIndex = 8;
            createAccountButton.TabStop = true;
            createAccountButton.Text = "Create one!";
            createAccountButton.LinkClicked += createAccountButton_LinkClicked;
            // 
            // LoginAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 88, 171);
            ClientSize = new Size(619, 450);
            Controls.Add(createAccountButton);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button loginButton;
        private Label label3;
        private LinkLabel createAccountButton;
    }
}
