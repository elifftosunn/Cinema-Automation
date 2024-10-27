using cinemaAutomation.Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace cinemaAutomation
{
    public partial class LoginForm : Form
    {
        private DBConnection conn;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Red;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Firebrick;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            conn = new DBConnection();
            conn.OpenConnection();
            try
            {
                conn = new DBConnection();
                SqlParameter[] parameters = {
                    new SqlParameter("@_username", SqlDbType.VarChar) { Value = usernameTextBox.Text },
                    new SqlParameter("@_password", SqlDbType.VarChar) { Value = passwordTextBox.Text }
                };
                SqlDataReader reader = conn.ExecuteQueryWithReader("SELECT * FROM Users WHERE username=@_username AND password=@_password;", parameters);
                if (reader.Read())
                {
                    MessageBox.Show("Login succesfully!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.fullName = reader["fullName"].ToString();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User record doesn't find! Username or password is incorrect!");
                }
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                usernameTextBox.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}
