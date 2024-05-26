namespace Vetov_2._0
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            Label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            email = new TextBox();
            username = new TextBox();
            password = new TextBox();
            conpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            Error = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(100, 66);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(145, 149);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(145, 209);
            Label3.Name = "Label3";
            Label3.Size = new Size(60, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 262);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 319);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password";
            // 
            // email
            // 
            email.Location = new Point(159, 167);
            email.Name = "email";
            email.Size = new Size(116, 23);
            email.TabIndex = 6;
            // 
            // username
            // 
            username.Location = new Point(159, 227);
            username.Name = "username";
            username.Size = new Size(116, 23);
            username.TabIndex = 7;
            // 
            // password
            // 
            password.Location = new Point(159, 280);
            password.Name = "password";
            password.PasswordChar = '●';
            password.Size = new Size(116, 23);
            password.TabIndex = 8;
            // 
            // conpass
            // 
            conpass.Location = new Point(159, 337);
            conpass.Name = "conpass";
            conpass.PasswordChar = '●';
            conpass.Size = new Size(116, 23);
            conpass.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(410, 0);
            button1.Name = "button1";
            button1.Size = new Size(38, 40);
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-3, 0);
            button2.Name = "button2";
            button2.Size = new Size(162, 40);
            button2.TabIndex = 11;
            button2.Text = "GO TO LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.GhostWhite;
            button3.Location = new Point(159, 448);
            button3.Name = "button3";
            button3.Size = new Size(149, 47);
            button3.TabIndex = 12;
            button3.Text = "REGISTER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(176, 381);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show Password?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Error.Location = new Point(145, 424);
            Error.Name = "Error";
            Error.Size = new Size(47, 21);
            Error.TabIndex = 14;
            Error.Text = "Error";
            Error.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 505);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 585);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(Error);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(conpass);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(email);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Label3;
        private Label label4;
        private Label label5;
        private TextBox email;
        private TextBox username;
        private TextBox password;
        private TextBox conpass;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private Label Error;
        private Label label6;
    }
}