using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BankManagementSystem
{
    public partial class Login : Form
    {
        private bool isDragging = false;
        private Point dragOffset;
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetRoleDefault();
        }
        
        private void SetRoleDefault()
        {
            roleComboBox.Text = "Role";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedIndex == -1 || roleComboBox.Text == "Role")
            {
                MessageBox.Show("Please select your Role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter your Username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string selectedRole = roleComboBox.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "";
            bool loginSuccess = false;

            try
            {
                if (Con.State == ConnectionState.Closed) Con.Open();

                if (selectedRole == "Admin")
                {
                    query = "SELECT COUNT(*) FROM AdminTbl WHERE AdName = @UN AND AdPass = @UP";
                }
                else if (selectedRole == "Agent")
                {
                    query = "SELECT COUNT(*) FROM AgentTbl WHERE AName = @UN AND APass = @UP";
                }
                else
                {
                    MessageBox.Show("Invalid Role selected.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@UN", username);
                cmd.Parameters.AddWithValue("@UP", password);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int count = Convert.ToInt32(result);
                    if (count == 1)
                    {
                        loginSuccess = true;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 208)
                {
                    MessageBox.Show("Login configuration error (Table missing?).\nPlease contact support.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error during login: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }

            if (loginSuccess)
            {
                if (selectedRole == "Admin")
                {
                    Agents agentForm = new Agents(); // Use the correct class name 'Agent'
                    agentForm.Show();
                    this.Hide();
                }
                else
                {
                    MainMenu mainMenuForm = new MainMenu();
                    mainMenuForm.Show();
                    this.Hide();
                }
            }
            else
            {
                if (Con.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Invalid credentials for the selected role. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - this.dragOffset.X,
                                      currentScreenPos.Y - this.dragOffset.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}