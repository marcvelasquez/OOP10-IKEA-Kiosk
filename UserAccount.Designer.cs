namespace WinFormsApp1
{
    partial class UserAccount
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ikea_logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 12);
            label1.Name = "label1";
            label1.Size = new Size(215, 45);
            label1.TabIndex = 2;
            label1.Text = "User Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 133);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(327, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 31);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 5;
            label3.Text = "New Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(327, 31);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 247);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 7;
            label4.Text = "Confirm New Email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(345, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(327, 31);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 247);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 11;
            label5.Text = "Confirm New Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(345, 213);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(327, 31);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 185);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 9;
            label6.Text = "New Password";
            // 
            // button1
            // 
            button1.Location = new Point(12, 312);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 13;
            button1.Text = "Delete Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(442, 312);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(560, 312);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 15;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(345, 133);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(327, 31);
            textBox6.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 105);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 16;
            label7.Text = "Phone Number";
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 371);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAccount";
            Text = "UserAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox6;
        private Label label7;
    }
}