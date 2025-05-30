using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class MainMenu : Form
    {
        private bool isDragging = false;
        private Point dragOffset;

        private Color primaryColor = Color.FromArgb(18, 140, 76);   
        private Color darkColor = Color.FromArgb(12, 90, 50);      
        private Color accentColor = Color.FromArgb(76, 187, 126);     
        private Color textColor = Color.White;
        private Color hoverColor = Color.FromArgb(28, 160, 96);      

        private Panel activePanel = null;

        public MainMenu()
        {
            InitializeComponent();

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,    
            int nTopRect,    
            int nRightRect,  
            int nBottomRect,   
            int nWidthEllipse,
            int nHeightEllipse 
        );

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersToMenuPanels();

            SetActivePanel(panelMenuSection1);

            SetupIcons();

            mainPanel.Paint += MainPanel_Paint;

            AddHoverEffects();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                mainPanel.ClientRectangle,
                darkColor,
                primaryColor,              
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, mainPanel.ClientRectangle);
            }
        }

        private void ApplyRoundedCornersToMenuPanels()
        {
            foreach (Control ctrl in mainPanel.Controls)
            {
                if (ctrl is Panel panel && panel.Name.StartsWith("panelMenuSection"))
                {
                    panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 15, 15));

                    panel.Paint += MenuPanel_Paint;
                }
            }
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            Color startColor = (panel == activePanel) ? accentColor : primaryColor;
            Color endColor = (panel == activePanel) ? primaryColor : darkColor;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel.ClientRectangle,
                startColor,                
                endColor,                    
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, panel.ClientRectangle);
            }

            using (Pen borderPen = new Pen(Color.FromArgb(100, Color.White), 1))
            {
                Rectangle borderRect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                e.Graphics.DrawRoundedRectangle(borderPen, borderRect, 15);
            }
        }

        private void AddHoverEffects()
        {
            foreach (Control ctrl in mainPanel.Controls)
            {
                if (ctrl is Panel panel && panel.Name.StartsWith("panelMenuSection"))
                {
                    panel.MouseEnter += Panel_MouseEnter;
                    panel.MouseLeave += Panel_MouseLeave;

                    foreach (Control child in panel.Controls)
                    {
                        child.MouseEnter += (s, e) => Panel_MouseEnter(panel, e);
                        child.MouseLeave += (s, e) => Panel_MouseLeave(panel, e);
                    }
                }
            }
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != activePanel)
            {
                panel.BackColor = hoverColor;
                panel.Invalidate(); 

                this.Cursor = Cursors.Hand;
            }
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != activePanel)
            {
                panel.BackColor = primaryColor;
                panel.Invalidate();  

                this.Cursor = Cursors.Default;
            }
        }

        private void SetActivePanel(Panel panel)
        {
            if (activePanel != null)
            {
                activePanel.BackColor = primaryColor;
                activePanel.Invalidate();
            }

            activePanel = panel;
            panel.BackColor = accentColor;
            panel.Invalidate();
        }

        #region Icon Setup (Modern Icons)
        private void SetupIcons()
        {
            try
            {
                // Assign modern styled icons
                picHomeIcon.Image = CreateModernHomeIcon();
                picUserIcon.Image = CreateModernUserIcon();
                picViewIcon.Image = CreateModernViewIcon();
                picFolderIcon.Image = CreateModernFolderIcon();

                // Add shadow effect to icons
                ApplyShadowEffect(picHomeIcon);
                ApplyShadowEffect(picUserIcon);
                ApplyShadowEffect(picViewIcon);
                ApplyShadowEffect(picFolderIcon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading icons: " + ex.Message, "Icon Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyShadowEffect(PictureBox pictureBox)
        {
            if (pictureBox.Image == null) return;

            Bitmap originalImage = (Bitmap)pictureBox.Image;
            Bitmap shadowImage = new Bitmap(originalImage.Width + 4, originalImage.Height + 4);

            using (Graphics g = Graphics.FromImage(shadowImage))
            {
                g.Clear(Color.Transparent);

                // Draw shadow (slightly offset)
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(80, Color.Black)))
                {
                    g.FillEllipse(shadowBrush, 4, 4, originalImage.Width, originalImage.Height);
                }

                // Draw original image
                g.DrawImage(originalImage, 0, 0);
            }

            pictureBox.Image = shadowImage;
        }

        private Bitmap CreateModernHomeIcon()
        {
            Bitmap bmp = new Bitmap(40, 40);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // House shape
                Point[] housePoints = {
                    new Point(20, 5),
                    new Point(38, 18),
                    new Point(31, 18),
                    new Point(31, 35),
                    new Point(9, 35),
                    new Point(9, 18),
                    new Point(2, 18),
                    new Point(20, 5)
                };

                // Fill with gradient
                using (LinearGradientBrush houseBrush = new LinearGradientBrush(
                    new Rectangle(2, 5, 36, 30),
                    Color.White,
                    Color.FromArgb(240, 240, 240),
                    LinearGradientMode.Vertical))
                {
                    g.FillPolygon(houseBrush, housePoints);
                }

                // Add outline
                using (Pen outlinePen = new Pen(Color.FromArgb(220, 220, 220), 1.5f))
                {
                    g.DrawPolygon(outlinePen, housePoints);
                }

                // Door with rounded top
                Rectangle doorRect = new Rectangle(16, 25, 8, 10);
                using (SolidBrush doorBrush = new SolidBrush(accentColor))
                {
                    g.FillRectangle(doorBrush, doorRect);
                }

                // Window
                Rectangle windowRect = new Rectangle(14, 15, 12, 6);
                using (SolidBrush windowBrush = new SolidBrush(Color.FromArgb(200, 230, 255)))
                {
                    g.FillRectangle(windowBrush, windowRect);
                }
                using (Pen windowPen = new Pen(Color.FromArgb(180, 180, 180), 1))
                {
                    g.DrawLine(windowPen, 20, 15, 20, 21);
                }
            }
            return bmp;
        }

        private Bitmap CreateModernUserIcon()
        {
            Bitmap bmp = new Bitmap(40, 40);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Head
                using (LinearGradientBrush headBrush = new LinearGradientBrush(
                    new Rectangle(13, 5, 14, 14),
                    Color.White,
                    Color.FromArgb(240, 240, 240),
                    LinearGradientMode.ForwardDiagonal))
                {
                    g.FillEllipse(headBrush, 13, 5, 14, 14);
                }

                // Body with rounded corners
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(8, 20, 10, 10, 180, 90);           // Top-left corner
                    path.AddArc(22, 20, 10, 10, 270, 90);          // Top-right corner
                    path.AddArc(22, 28, 10, 10, 0, 90);            // Bottom-right corner
                    path.AddArc(8, 28, 10, 10, 90, 90);            // Bottom-left corner
                    path.CloseFigure();

                    using (LinearGradientBrush bodyBrush = new LinearGradientBrush(
                        new Rectangle(8, 20, 24, 18),
                        Color.White,
                        Color.FromArgb(240, 240, 240),
                        LinearGradientMode.Vertical))
                    {
                        g.FillPath(bodyBrush, path);
                    }
                }

                // Add subtle details (tie/collar)
                using (SolidBrush detailBrush = new SolidBrush(accentColor))
                {
                    Point[] tiePath = {
                        new Point(20, 20),
                        new Point(22, 24),
                        new Point(20, 35),
                        new Point(18, 24),
                        new Point(20, 20)
                    };
                    g.FillPolygon(detailBrush, tiePath);
                }
            }
            return bmp;
        }

        private Bitmap CreateModernViewIcon()
        {
            Bitmap bmp = new Bitmap(40, 40);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Eye shape
                using (LinearGradientBrush eyeBrush = new LinearGradientBrush(
                    new Rectangle(6, 13, 28, 14),
                    Color.White,
                    Color.FromArgb(240, 240, 240),
                    LinearGradientMode.Vertical))
                {
                    g.FillEllipse(eyeBrush, 6, 13, 28, 14);
                }

                // Outline
                using (Pen outlinePen = new Pen(Color.FromArgb(220, 220, 220), 1.5f))
                {
                    g.DrawEllipse(outlinePen, 6, 13, 28, 14);
                }

                // Pupil with gradient
                using (LinearGradientBrush pupilBrush = new LinearGradientBrush(
                    new Rectangle(16, 16, 8, 8),
                    accentColor,
                    darkColor,
                    LinearGradientMode.ForwardDiagonal))
                {
                    g.FillEllipse(pupilBrush, 16, 16, 8, 8);
                }

                // Highlight/shine
                using (SolidBrush shineBrush = new SolidBrush(Color.FromArgb(150, 255, 255, 255)))
                {
                    g.FillEllipse(shineBrush, 18, 18, 3, 3);
                }
            }
            return bmp;
        }

        private Bitmap CreateModernFolderIcon()
        {
            Bitmap bmp = new Bitmap(40, 40);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Create folder shape with rounded corners
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Bottom part of folder
                    path.AddArc(5, 10, 8, 8, 180, 90);             // Top-left corner
                    path.AddArc(27, 10, 8, 8, 270, 90);            // Top-right corner
                    path.AddArc(27, 24, 8, 8, 0, 90);              // Bottom-right corner
                    path.AddArc(5, 24, 8, 8, 90, 90);              // Bottom-left corner
                    path.CloseFigure();

                    // Folder tab (top part)
                    path.AddArc(9, 6, 4, 4, 180, 90);              // Tab top-left
                    path.AddArc(17, 6, 4, 4, 270, 90);             // Tab top-right
                    path.AddLine(21, 10, 9, 10);                   // Bottom of tab
                    path.CloseFigure();

                    // Fill with gradient
                    using (LinearGradientBrush folderBrush = new LinearGradientBrush(
                        new Rectangle(5, 6, 30, 26),
                        Color.White,
                        Color.FromArgb(240, 240, 240),
                        LinearGradientMode.Vertical))
                    {
                        g.FillPath(folderBrush, path);
                    }

                    // Add outline
                    using (Pen outlinePen = new Pen(Color.FromArgb(220, 220, 220), 1))
                    {
                        g.DrawPath(outlinePen, path);
                    }
                }

                // Add folder detail lines
                using (Pen detailPen = new Pen(Color.FromArgb(150, accentColor), 1))
                {
                    g.DrawLine(detailPen, 10, 20, 30, 20);
                    g.DrawLine(detailPen, 10, 25, 30, 25);
                }
            }
            return bmp;
        }
        #endregion

        #region Top Control Buttons (Close, Minimize, Maximize)

        // Close Button - Exits the entire application
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize Button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Maximize Button (Optional - usually not needed for fixed-size menu)
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            // If just normal size:
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        #region Mouse Events for Dragging
        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(-dragOffset.X, -dragOffset.Y);
                Location = newPoint;
            }
        }

        private void MainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        #endregion

        #region Menu Panel Click Events (Navigation Logic)

        // --- ACCOUNTS Section Click ---
        private void panelMenuSection1_Click(object sender, EventArgs e)
        {
            // Visual feedback - highlight the selected panel
            SetActivePanel(panelMenuSection1);

            // Open the AddAccounts form
            AddAccounts accountsForm = new AddAccounts();
            accountsForm.Show();
        }

        // --- TRANSACTIONS Section Click ---
        private void panelMenuSection2_Click(object sender, EventArgs e)
        {
            // Visual feedback - highlight the selected panel
            SetActivePanel(panelMenuSection2);

            // Open the Transactions form
            Transactions transactionsForm = new Transactions();
            transactionsForm.Show();
        }

        // --- SETTINGS Section Click ---
        private void panelMenuSection3_Click(object sender, EventArgs e)
        {
            // Visual feedback - highlight the selected panel
            SetActivePanel(panelMenuSection3);

            // Open the Settings form
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }
        #endregion

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    } 

    public static class GraphicsExtensions
    {
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (pen == null)
                throw new ArgumentNullException("pen");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius))
            {
                graphics.DrawPath(pen, path);
            }
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

         
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}