using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace BankManagementSystem
{
    public partial class Settings : Form
    {
        private bool isDragging = false;
        private Point lastLocation;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadSettings();
            SetupFormDragging();
        }

        private void LoadSettings()
        {
            string defaultTheme = "Green";
            if (comboTheme.Items.Contains(defaultTheme))
            {
                comboTheme.SelectedItem = defaultTheme;
            }
            else if (comboTheme.Items.Count > 0)
            {
                comboTheme.SelectedIndex = 0;
                defaultTheme = comboTheme.Items[0].ToString();
            }
            ApplyTheme(defaultTheme);
        }

        private void SetupFormDragging()
        {
            Control[] controlsToDrag = { this, panelMain, labelTitle };
            foreach (var control in controlsToDrag)
            {
                control.MouseDown += Form_MouseDown;
                control.MouseMove += Form_MouseMove;
                control.MouseUp += Form_MouseUp;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastLocation = e.Location;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplyPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
                return;
            }
            if (txtAdminPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE AdminTbl SET AdPass=@AdminPass WHERE AdId=1", connection);
                    cmd.Parameters.AddWithValue("@AdminPass", txtAdminPassword.Text);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Admin password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdminPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password. Admin record (AdId=1) not found or database issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error updating password: {sqlEx.Message}\n\nPlease ensure the 'AdminTbl' table exists and has AdId=1.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplyTheme_Click(object sender, EventArgs e)
        {
            if (comboTheme.SelectedItem == null)
            {
                MessageBox.Show("Please select a theme.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTheme = comboTheme.SelectedItem.ToString();
            ApplyTheme(selectedTheme);
        }

        private void ApplyTheme(string themeName)
        {
            Color sidebarColor;

            switch (themeName?.ToLower())
            {
                case "blue":
                    sidebarColor = Color.FromArgb(0, 71, 160);
                    break;
                case "dark":
                    sidebarColor = Color.FromArgb(45, 45, 48);
                    break;
                case "light":
                    sidebarColor = Color.FromArgb(220, 220, 220);
                    break;
                case "green":
                default:
                    sidebarColor = Color.DarkGreen;
                    break;
            }
            panelSidebar.BackColor = sidebarColor;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reset theme selection to Green (visual only) and clear the password field?",
                "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string defaultTheme = "Green";
                if (comboTheme.Items.Contains(defaultTheme))
                {
                    comboTheme.SelectedItem = defaultTheme;
                }
                else if (comboTheme.Items.Count > 0)
                {
                    comboTheme.SelectedIndex = 0;
                    defaultTheme = comboTheme.SelectedItem.ToString();
                }

                txtAdminPassword.Clear();

                ApplyTheme(defaultTheme);

                MessageBox.Show("Visual theme reset to default. Admin password field cleared.", "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}