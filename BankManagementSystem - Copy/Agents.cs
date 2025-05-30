using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
// using System.Linq; // Only needed if you use LINQ methods elsewhere

namespace BankManagementSystem
{
    public partial class Agents : Form
    {
        #region Fields
        private bool isDragging = false;
        private Point lastLocation;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BankDb.mdf;Integrated Security=True;Connect Timeout=30";
        private int Key = 0; 
        #endregion

        #region Constructor and Load Event
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();        // Load agent data into the grid first
            LoadAndApplyTheme();    // Apply theme based on DB setting
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            // Form Dragging Setup for the form itself and key child controls
            Control[] controlsToDrag = { this, panelMain, labelTitle };
            foreach (var control in controlsToDrag)
            {
                control.MouseDown += Form_MouseDown;
                control.MouseMove += Form_MouseMove;
                control.MouseUp += Form_MouseUp;
            }
        }
        #endregion

        #region DataGridView Methods

        // Fetches data from AgentTbl and displays it
        private void DisplayAgents()
        {
            if (AgentDGV == null) return; // Safety check

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Select only necessary columns, avoid password
                    string query = "SELECT AId, AName, APhone, Aaddress FROM AgentTbl ORDER BY AName"; // Added ORDER BY
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    var ds = new DataSet();
                    sda.Fill(ds);

                    // Check if data was retrieved
                    if (ds.Tables.Count > 0)
                    {
                        AgentDGV.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        AgentDGV.DataSource = null; // Clear grid if no data
                    }
                } // Connection automatically closed here

                // Set Column Headers (do this after setting DataSource)
                if (AgentDGV.Columns["AId"] != null) AgentDGV.Columns["AId"].HeaderText = "ID";
                if (AgentDGV.Columns["AName"] != null) AgentDGV.Columns["AName"].HeaderText = "Agent Name";
                if (AgentDGV.Columns["APhone"] != null) AgentDGV.Columns["APhone"].HeaderText = "Phone";
                if (AgentDGV.Columns["Aaddress"] != null) AgentDGV.Columns["Aaddress"].HeaderText = "Address";

                AgentDGV.ClearSelection(); // Deselect initially
                Reset(); // Clear fields when grid is refreshed
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error loading agents: {sqlEx.Message}\nError Number: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading agent data: " + ex.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles selecting an agent from the grid
        private void AgentDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (AgentDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = AgentDGV.SelectedRows[0];
                if (row != null && row.Cells["AId"]?.Value != null) // Check if row and ID cell are valid
                {
                    ANameTb.Text = row.Cells["AName"]?.Value?.ToString() ?? "";
                    PasswordTb.Text = ""; // Clear password field on select for security
                    APhoneTb.Text = row.Cells["APhone"]?.Value?.ToString() ?? "";
                    AAddressTb.Text = row.Cells["Aaddress"]?.Value?.ToString() ?? "";

                    // Safely get the Primary Key (AId)
                    if (int.TryParse(row.Cells["AId"].Value.ToString(), out int selectedKey))
                    {
                        Key = selectedKey;
                    }
                    else
                    {
                        Key = 0; // Reset key if conversion fails
                        Reset(); // Clear fields if ID is invalid
                    }
                }
                else
                {
                    Key = 0; // No valid row selected
                    Reset();
                }
            }
            else
            {
                Key = 0; // No row selected
                // Optionally call Reset() here if you want fields cleared when selection is lost
                // Reset();
            }
        }
        #endregion

        #region Form Action Methods

        // Clears input fields and resets selection state
        private void Reset()
        {
            ANameTb.Text = "";
            PasswordTb.Text = "";
            APhoneTb.Text = "";
            AAddressTb.Text = "";
            Key = 0; // Reset the selected agent ID
            if (AgentDGV != null)
            {
                AgentDGV.ClearSelection(); // Clear grid selection
            }
            if (ANameTb != null && !ANameTb.IsDisposed)
            {
                ANameTb.Focus(); // Set focus back to the name field
            }
        }

        // --- Button Click Handlers ---
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        // Opens the Settings form
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Ensure the Settings form class exists in your project
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog(this); // Show modally, parented to this form
            // Re-apply theme after Settings form is closed, in case it was changed
            LoadAndApplyTheme();
        }

        // SUBMIT (Add New Agent)
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Basic Validation
            if (string.IsNullOrWhiteSpace(ANameTb.Text) || string.IsNullOrWhiteSpace(PasswordTb.Text) ||
                string.IsNullOrWhiteSpace(APhoneTb.Text) || string.IsNullOrWhiteSpace(AAddressTb.Text))
            {
                MessageBox.Show("Missing Information. Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Add more specific validation if needed (e.g., phone format, password complexity)

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Use parameterized query to prevent SQL injection
                    string query = "INSERT INTO AgentTbl(AName, APass, APhone, Aaddress) VALUES(@AN, @APass, @AP, @Aadd)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AN", ANameTb.Text.Trim());
                        // !! SECURITY WARNING: HASH THE PASSWORD BEFORE SAVING !!
                        // Example: cmd.Parameters.AddWithValue("@APass", HashPasswordFunction(PasswordTb.Text));
                        cmd.Parameters.AddWithValue("@APass", PasswordTb.Text); // Storing plain text is insecure
                        cmd.Parameters.AddWithValue("@AP", APhoneTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Aadd", AAddressTb.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Agent Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                DisplayAgents(); // Refresh grid to show the new agent
                // Reset(); // Reset is called within DisplayAgents now
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error adding agent: {sqlEx.Message}\nError Number: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EDIT (Update Selected Agent)
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select the Agent to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Re-validate all fields for update, including password re-entry
            if (string.IsNullOrWhiteSpace(ANameTb.Text) || string.IsNullOrWhiteSpace(PasswordTb.Text) ||
                string.IsNullOrWhiteSpace(APhoneTb.Text) || string.IsNullOrWhiteSpace(AAddressTb.Text))
            {
                MessageBox.Show("Missing Information. Please fill all fields including password to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE AgentTbl SET AName=@AN, APass=@APass, APhone=@AP, Aaddress=@Aadd WHERE AId=@AKey";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AN", ANameTb.Text.Trim());
                        // !! SECURITY WARNING: Update with hashed password if hashing is implemented !!
                        cmd.Parameters.AddWithValue("@APass", PasswordTb.Text); // Updating plain text is insecure
                        cmd.Parameters.AddWithValue("@AP", APhoneTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Aadd", AAddressTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@AKey", Key); // The primary key from the selected row

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Agent Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Agent not found or no changes were made.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information); // Or Warning
                    }
                }
                DisplayAgents(); // Refresh grid
                // Reset(); // Reset is called within DisplayAgents
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error updating agent: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE (Delete Selected Agent) - Changed from CancelBtn
        private void CancelBtn_Click(object sender, EventArgs e) // Button is named CancelBtn but performs Delete
        {
            if (Key == 0)
            {
                MessageBox.Show("Please select the Agent to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation Dialog
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete agent '{ANameTb.Text}' (ID: {Key})?\nThis action cannot be undone.",
                                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); // Default to No

            if (confirm == DialogResult.No) return; // User cancelled

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM AgentTbl WHERE AId=@AKey";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AKey", Key);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Agent Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Agent not found.", "Delete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Agent might have been deleted by another user
                    }
                }
                DisplayAgents(); // Refresh grid
                // Reset(); // Reset is called within DisplayAgents
            }
            catch (SqlException sqlEx)
            {
                // Handle potential foreign key constraints if agents are linked elsewhere
                MessageBox.Show($"Database Error deleting agent: {sqlEx.Message}\nCould not delete agent. They might be linked to other records.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Theme Methods

        private void LoadAndApplyTheme()
        {
            string currentTheme = "Green"; // Sensible default
            try
            {
                // Check connection string validity early
                if (string.IsNullOrWhiteSpace(connectionString) || !connectionString.ToLower().Contains("data source"))
                {
                    Console.WriteLine("Theme Load Warning: Database connection string appears invalid or empty.");
                    // Apply default without showing user error unless crucial
                }
                else
                {
                    using (SqlConnection themeCon = new SqlConnection(connectionString))
                    {
                        themeCon.Open();
                        // Ensure ThemeSettings table and columns exist and query is correct
                        SqlCommand cmd = new SqlCommand("SELECT TOP 1 ThemeName FROM ThemeSettings WHERE IsActive = 1", themeCon);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            currentTheme = result.ToString();
                        }
                        else
                        {
                            Console.WriteLine("Theme Load Info: No active theme found in ThemeSettings table, using default.");
                        }
                    } // Connection automatically closed
                }
            }
            catch (SqlException sqlEx)
            {
                // Log specific SQL errors, inform user generically
                Console.WriteLine($"SQL Error Loading Theme: {sqlEx.Message} (Number: {sqlEx.Number})");
                // Avoid disruptive message boxes unless absolutely necessary
                // MessageBox.Show($"Could not load theme settings (DB Error {sqlEx.Number}), using default.", "Theme Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Log general errors
                Console.WriteLine("General Error Loading Theme: " + ex.Message);
                // MessageBox.Show("Could not load theme settings, using default.", "Theme Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally // Ensure theme is applied even if DB fails
            {
                ApplyTheme(currentTheme);
            }
        }

        private void ApplyTheme(string themeName)
        {
            // Define colors based on theme
            Color mainColor, textColor, backgroundColor, buttonForeColor, gridHeaderBackColor, gridHeaderForeColor,
                  gridDefaultBackColor, gridDefaultForeColor, gridSelectionBackColor, gridSelectionForeColor,
                  textBoxBackColor, gridLineColor;

            // --- Color definitions based on themeName ---
            switch (themeName?.ToLower())
            {
                case "blue":
                    mainColor = Color.FromArgb(0, 71, 160);         // Dark Blue
                    textColor = Color.Black;
                    backgroundColor = Color.AliceBlue;              // Very light blue
                    buttonForeColor = Color.White;                  // White text on blue buttons
                    gridHeaderBackColor = mainColor;
                    gridHeaderForeColor = Color.White;
                    gridDefaultBackColor = Color.White;
                    gridDefaultForeColor = Color.Black;
                    gridSelectionBackColor = Color.RoyalBlue;       // Medium blue
                    gridSelectionForeColor = Color.White;
                    textBoxBackColor = Color.White;
                    gridLineColor = Color.LightGray;
                    break;

                case "dark":
                    mainColor = Color.FromArgb(45, 45, 48);         // Dark Gray (VS Dark)
                    textColor = Color.FromArgb(220, 220, 220);      // Light Gray Text
                    backgroundColor = Color.FromArgb(28, 28, 28);   // Very Dark Gray Background
                    buttonForeColor = Color.White;                  // White text on dark buttons
                    gridHeaderBackColor = mainColor;
                    gridHeaderForeColor = textColor;
                    gridDefaultBackColor = Color.FromArgb(50, 50, 55); // Slightly lighter dark gray
                    gridDefaultForeColor = textColor;
                    gridSelectionBackColor = Color.FromArgb(0, 122, 204); // VS Selection Blue
                    gridSelectionForeColor = Color.White;
                    textBoxBackColor = Color.FromArgb(60, 60, 65);   // Dark Textbox Background
                    gridLineColor = Color.FromArgb(70, 70, 70);     // Dark Grid Lines
                    break;

                case "light":
                    mainColor = Color.FromArgb(220, 220, 220);      // Light Gray
                    textColor = Color.Black;
                    backgroundColor = Color.WhiteSmoke;             // Off-white background
                    buttonForeColor = Color.Black;                  // Black text on light buttons
                    gridHeaderBackColor = mainColor;
                    gridHeaderForeColor = Color.Black;
                    gridDefaultBackColor = Color.White;
                    gridDefaultForeColor = Color.Black;
                    gridSelectionBackColor = Color.Gainsboro;       // Slightly darker gray selection
                    gridSelectionForeColor = Color.Black;
                    textBoxBackColor = Color.White;
                    gridLineColor = Color.Gainsboro;
                    break;

                case "green":
                default: // Default to Green theme
                    mainColor = Color.DarkGreen;
                    textColor = Color.Black;
                    backgroundColor = Color.White;
                    buttonForeColor = Color.White;                  // White text on green buttons
                    gridHeaderBackColor = mainColor;
                    gridHeaderForeColor = Color.White;
                    gridDefaultBackColor = Color.White;
                    gridDefaultForeColor = Color.Black;
                    gridSelectionBackColor = Color.ForestGreen;     // Lighter Green
                    gridSelectionForeColor = Color.White;
                    textBoxBackColor = Color.White;
                    gridLineColor = Color.Gainsboro;
                    themeName = "green"; // Ensure themeName is set if default is used
                    break;
            }
            // --- End Color definitions ---


            // Apply colors to Form and Panels
            this.BackColor = backgroundColor;
            panelSidebar.BackColor = mainColor;
            panelMain.BackColor = backgroundColor;

            // Title and Top Buttons
            labelTitle.ForeColor = mainColor;

            if (btnClose != null)
            {
                btnClose.ForeColor = mainColor;
                btnClose.BackColor = backgroundColor; // Blend with panel
                btnClose.FlatStyle = FlatStyle.Flat;
                btnClose.FlatAppearance.BorderSize = 0;
            }

            // --- Apply theme to TEXT Settings button ---
            if (btnSettings != null)
            {
                btnSettings.BackColor = mainColor;         // Background like other buttons
                btnSettings.ForeColor = buttonForeColor;   // Text color from theme
                btnSettings.FlatStyle = FlatStyle.Flat;
                btnSettings.FlatAppearance.BorderSize = 0;
            }
            // --- End Settings button theme ---

            // Labels
            Label[] labels = { labelName, labelPassword, labelAddress, labelPhone };
            foreach (var lbl in labels) { if (lbl != null) lbl.ForeColor = textColor; }

            // TextBoxes
            TextBox[] textboxes = { ANameTb, PasswordTb, AAddressTb, APhoneTb };
            foreach (var tb in textboxes)
            {
                if (tb != null)
                {
                    tb.BackColor = textBoxBackColor;
                    tb.ForeColor = textColor;
                    tb.BorderStyle = BorderStyle.FixedSingle; // Keep border consistent
                }
            }

            // Buttons (Submit, Edit, Delete/Cancel)
            Button[] actionButtons = { SubmitBtn, EditBtn, CancelBtn };
            foreach (var btn in actionButtons)
            {
                if (btn != null)
                {
                    btn.BackColor = mainColor;
                    btn.ForeColor = buttonForeColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }

            // DataGridView Styles
            if (AgentDGV != null)
            {
                // Basic Properties
                AgentDGV.BackgroundColor = backgroundColor;
                AgentDGV.GridColor = gridLineColor;
                AgentDGV.BorderStyle = BorderStyle.None; // Cleaner look
                AgentDGV.EnableHeadersVisualStyles = false; // REQUIRED for custom header colors

                // Header Style
                AgentDGV.ColumnHeadersDefaultCellStyle.BackColor = gridHeaderBackColor;
                AgentDGV.ColumnHeadersDefaultCellStyle.ForeColor = gridHeaderForeColor;
                AgentDGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = gridHeaderBackColor; // Prevent selection change color
                AgentDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                AgentDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Cleaner header
                AgentDGV.ColumnHeadersHeight = 30;

                // Default Cell Style
                AgentDGV.DefaultCellStyle.BackColor = gridDefaultBackColor;
                AgentDGV.DefaultCellStyle.ForeColor = gridDefaultForeColor;
                AgentDGV.DefaultCellStyle.SelectionBackColor = gridSelectionBackColor;
                AgentDGV.DefaultCellStyle.SelectionForeColor = gridSelectionForeColor;
                AgentDGV.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.5F); // Slightly smaller font for data
                AgentDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Horizontal lines only

                // Row Headers (usually hidden, but style anyway)
                AgentDGV.RowHeadersDefaultCellStyle.BackColor = gridHeaderBackColor;
                AgentDGV.RowHeadersDefaultCellStyle.ForeColor = gridHeaderForeColor;
                AgentDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                AgentDGV.RowHeadersVisible = false; // Hide row headers

                AgentDGV.Refresh(); // Apply changes visually
            }
        }

        #endregion Theme Methods

        #region Form Dragging Methods
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastLocation = e.Location; // Store the location where the mouse was pressed
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new form position
                Point currentScreenPos = this.PointToScreen(e.Location);
                Point newLocation = new Point(currentScreenPos.X - this.lastLocation.X,
                                             currentScreenPos.Y - this.lastLocation.Y);
                this.Location = newLocation;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        #endregion

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 