using System;

namespace BankManagementSystem
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.bankLogo = new System.Windows.Forms.PictureBox();
            this.panelMenuSection3 = new System.Windows.Forms.Panel();
            this.picFolderIcon = new System.Windows.Forms.PictureBox();
            this.lblAccounts3 = new System.Windows.Forms.Label();
            this.panelMenuSection2 = new System.Windows.Forms.Panel();
            this.picViewIcon = new System.Windows.Forms.PictureBox();
            this.lblAccounts2 = new System.Windows.Forms.Label();
            this.panelMenuSection1 = new System.Windows.Forms.Panel();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.lblAccounts1 = new System.Windows.Forms.Label();
            this.picHomeIcon = new System.Windows.Forms.PictureBox();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLogo)).BeginInit();
            this.panelMenuSection3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFolderIcon)).BeginInit();
            this.panelMenuSection2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewIcon)).BeginInit();
            this.panelMenuSection1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(76)))));
            this.mainPanel.Controls.Add(this.lblDate);
            this.mainPanel.Controls.Add(this.lblBankName);
            this.mainPanel.Controls.Add(this.bankLogo);
            this.mainPanel.Controls.Add(this.panelMenuSection3);
            this.mainPanel.Controls.Add(this.panelMenuSection2);
            this.mainPanel.Controls.Add(this.panelMenuSection1);
            this.mainPanel.Controls.Add(this.picHomeIcon);
            this.mainPanel.Controls.Add(this.lblMainMenu);
            this.mainPanel.Controls.Add(this.btnClose);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(320, 600);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint_1);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseUp);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(25, 560);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date: 00/00/00";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.BackColor = System.Drawing.Color.Transparent;
            this.lblBankName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBankName.ForeColor = System.Drawing.Color.White;
            this.lblBankName.Location = new System.Drawing.Point(73, 190);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(185, 32);
            this.lblBankName.TabIndex = 9;
            this.lblBankName.Text = "GreenPay Bank";
            this.lblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bankLogo
            // 
            this.bankLogo.BackColor = System.Drawing.Color.Transparent;
            this.bankLogo.Location = new System.Drawing.Point(115, 90);
            this.bankLogo.Margin = new System.Windows.Forms.Padding(4);
            this.bankLogo.Name = "bankLogo";
            this.bankLogo.Size = new System.Drawing.Size(90, 90);
            this.bankLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bankLogo.TabIndex = 8;
            this.bankLogo.TabStop = false;
            // 
            // panelMenuSection3
            // 
            this.panelMenuSection3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(76)))));
            this.panelMenuSection3.Controls.Add(this.picFolderIcon);
            this.panelMenuSection3.Controls.Add(this.lblAccounts3);
            this.panelMenuSection3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenuSection3.Location = new System.Drawing.Point(25, 420);
            this.panelMenuSection3.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuSection3.Name = "panelMenuSection3";
            this.panelMenuSection3.Size = new System.Drawing.Size(270, 70);
            this.panelMenuSection3.TabIndex = 7;
            this.toolTip.SetToolTip(this.panelMenuSection3, "Open Settings");
            this.panelMenuSection3.Click += new System.EventHandler(this.panelMenuSection3_Click);
            // 
            // picFolderIcon
            // 
            this.picFolderIcon.BackColor = System.Drawing.Color.Transparent;
            this.picFolderIcon.Location = new System.Drawing.Point(20, 15);
            this.picFolderIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picFolderIcon.Name = "picFolderIcon";
            this.picFolderIcon.Size = new System.Drawing.Size(40, 40);
            this.picFolderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFolderIcon.TabIndex = 1;
            this.picFolderIcon.TabStop = false;
            this.picFolderIcon.Click += new System.EventHandler(this.panelMenuSection3_Click);
            // 
            // lblAccounts3
            // 
            this.lblAccounts3.AutoSize = true;
            this.lblAccounts3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccounts3.ForeColor = System.Drawing.Color.White;
            this.lblAccounts3.Location = new System.Drawing.Point(75, 22);
            this.lblAccounts3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccounts3.Name = "lblAccounts3";
            this.lblAccounts3.Size = new System.Drawing.Size(86, 28);
            this.lblAccounts3.TabIndex = 0;
            this.lblAccounts3.Text = "Settings";
            this.lblAccounts3.Click += new System.EventHandler(this.panelMenuSection3_Click);
            // 
            // panelMenuSection2
            // 
            this.panelMenuSection2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(76)))));
            this.panelMenuSection2.Controls.Add(this.picViewIcon);
            this.panelMenuSection2.Controls.Add(this.lblAccounts2);
            this.panelMenuSection2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenuSection2.Location = new System.Drawing.Point(25, 330);
            this.panelMenuSection2.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuSection2.Name = "panelMenuSection2";
            this.panelMenuSection2.Size = new System.Drawing.Size(270, 70);
            this.panelMenuSection2.TabIndex = 6;
            this.toolTip.SetToolTip(this.panelMenuSection2, "Open Transactions");
            this.panelMenuSection2.Click += new System.EventHandler(this.panelMenuSection2_Click);
            // 
            // picViewIcon
            // 
            this.picViewIcon.BackColor = System.Drawing.Color.Transparent;
            this.picViewIcon.Location = new System.Drawing.Point(20, 15);
            this.picViewIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picViewIcon.Name = "picViewIcon";
            this.picViewIcon.Size = new System.Drawing.Size(40, 40);
            this.picViewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewIcon.TabIndex = 1;
            this.picViewIcon.TabStop = false;
            this.picViewIcon.Click += new System.EventHandler(this.panelMenuSection2_Click);
            // 
            // lblAccounts2
            // 
            this.lblAccounts2.AutoSize = true;
            this.lblAccounts2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccounts2.ForeColor = System.Drawing.Color.White;
            this.lblAccounts2.Location = new System.Drawing.Point(75, 22);
            this.lblAccounts2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccounts2.Name = "lblAccounts2";
            this.lblAccounts2.Size = new System.Drawing.Size(123, 28);
            this.lblAccounts2.TabIndex = 0;
            this.lblAccounts2.Text = "Transactions";
            this.lblAccounts2.Click += new System.EventHandler(this.panelMenuSection2_Click);
            // 
            // panelMenuSection1
            // 
            this.panelMenuSection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(76)))));
            this.panelMenuSection1.Controls.Add(this.picUserIcon);
            this.panelMenuSection1.Controls.Add(this.lblAccounts1);
            this.panelMenuSection1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenuSection1.Location = new System.Drawing.Point(25, 240);
            this.panelMenuSection1.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuSection1.Name = "panelMenuSection1";
            this.panelMenuSection1.Size = new System.Drawing.Size(270, 70);
            this.panelMenuSection1.TabIndex = 5;
            this.toolTip.SetToolTip(this.panelMenuSection1, "Open Accounts");
            this.panelMenuSection1.Click += new System.EventHandler(this.panelMenuSection1_Click);
            // 
            // picUserIcon
            // 
            this.picUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.picUserIcon.Location = new System.Drawing.Point(20, 15);
            this.picUserIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(40, 40);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 1;
            this.picUserIcon.TabStop = false;
            this.picUserIcon.Click += new System.EventHandler(this.panelMenuSection1_Click);
            // 
            // lblAccounts1
            // 
            this.lblAccounts1.AutoSize = true;
            this.lblAccounts1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccounts1.ForeColor = System.Drawing.Color.White;
            this.lblAccounts1.Location = new System.Drawing.Point(75, 22);
            this.lblAccounts1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccounts1.Name = "lblAccounts1";
            this.lblAccounts1.Size = new System.Drawing.Size(95, 28);
            this.lblAccounts1.TabIndex = 0;
            this.lblAccounts1.Text = "Accounts";
            this.lblAccounts1.Click += new System.EventHandler(this.panelMenuSection1_Click);
            // 
            // picHomeIcon
            // 
            this.picHomeIcon.BackColor = System.Drawing.Color.Transparent;
            this.picHomeIcon.Location = new System.Drawing.Point(25, 25);
            this.picHomeIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picHomeIcon.Name = "picHomeIcon";
            this.picHomeIcon.Size = new System.Drawing.Size(40, 40);
            this.picHomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHomeIcon.TabIndex = 4;
            this.picHomeIcon.TabStop = false;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblMainMenu.Location = new System.Drawing.Point(80, 25);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(162, 37);
            this.lblMainMenu.TabIndex = 3;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(126)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(283, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.toolTip.SetToolTip(this.btnClose, "Close Application");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Management - Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLogo)).EndInit();
            this.panelMenuSection3.ResumeLayout(false);
            this.panelMenuSection3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFolderIcon)).EndInit();
            this.panelMenuSection2.ResumeLayout(false);
            this.panelMenuSection2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewIcon)).EndInit();
            this.panelMenuSection1.ResumeLayout(false);
            this.panelMenuSection1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomeIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.PictureBox picHomeIcon;
        private System.Windows.Forms.Panel panelMenuSection1;
        private System.Windows.Forms.Label lblAccounts1;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.Panel panelMenuSection2;
        private System.Windows.Forms.Label lblAccounts2;
        private System.Windows.Forms.PictureBox picViewIcon;
        private System.Windows.Forms.Panel panelMenuSection3;
        private System.Windows.Forms.Label lblAccounts3;
        private System.Windows.Forms.PictureBox picFolderIcon;
        private System.Windows.Forms.PictureBox bankLogo;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.ToolTip toolTip;

        // Method to update the date and time display
        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "Date: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}