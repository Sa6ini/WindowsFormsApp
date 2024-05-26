using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vetov_2._0
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            //Creating a new login form to pop up when button is clicked
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || username.Text == "" || password.Text == "" || conpass.Text == "")
            {
                Error.Text = "Please fill in all fields!";
                Error.Visible = true;
            }
            else if (password.Text != conpass.Text)
            {
                Error.Text = "Passwords doesn't match!";
                Error.Visible = true;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                Hide();

                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;;Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                string query = "INSERT INTO users (Email, Username, Password) VALUES (@Email, @Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User registered successfully!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error registering user. Please try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //closing the program
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.PasswordChar = '\0';
                conpass.PasswordChar = '\0';
                password.UseSystemPasswordChar = false;
                conpass.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                conpass.UseSystemPasswordChar = true;
            }
        }
        
    }
}
