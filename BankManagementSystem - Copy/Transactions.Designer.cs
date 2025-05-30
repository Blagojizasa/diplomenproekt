namespace BankManagementSystem
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.balancePanel = new System.Windows.Forms.Panel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.checkBalanceLabel = new System.Windows.Forms.Label();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawAmountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountLabel = new System.Windows.Forms.Label();
            this.withdrawAccountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAccountLabel = new System.Windows.Forms.Label();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositAmountTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.depositAccountTextBox = new System.Windows.Forms.TextBox();
            this.depositAccountLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.transferPanel = new System.Windows.Forms.Panel();
            this.transferButton = new System.Windows.Forms.Button();
            this.transferAmountTextBox = new System.Windows.Forms.TextBox();
            this.transferAmountLabel = new System.Windows.Forms.Label();
            this.toAccountTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromAccountTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.transferLabel = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.balancePanel.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.depositPanel.SuspendLayout();
            this.transferPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkGreen;
            this.sidePanel.Controls.Add(this.logoBox);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(67, 620);
            this.sidePanel.TabIndex = 10;
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(4, 4);
            this.logoBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(54, 52);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.titleLabel.Location = new System.Drawing.Point(410, 15);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(173, 38);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Transactions";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.closeButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.closeButton.Location = new System.Drawing.Point(940, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // balancePanel
            // 
            this.balancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balancePanel.Controls.Add(this.balanceLabel);
            this.balancePanel.Controls.Add(this.checkButton);
            this.balancePanel.Controls.Add(this.balanceTextBox);
            this.balancePanel.Controls.Add(this.checkBalanceLabel);
            this.balancePanel.Location = new System.Drawing.Point(100, 70);
            this.balancePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.balancePanel.Name = "balancePanel";
            this.balancePanel.Size = new System.Drawing.Size(850, 90);
            this.balancePanel.TabIndex = 0;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.balanceLabel.Location = new System.Drawing.Point(579, 42);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(106, 28);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "$0,000.00";
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.DarkGreen;
            this.checkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(390, 35);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(120, 35);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.balanceTextBox.Location = new System.Drawing.Point(25, 40);
            this.balanceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(340, 30);
            this.balanceTextBox.TabIndex = 1;
            // 
            // checkBalanceLabel
            // 
            this.checkBalanceLabel.AutoSize = true;
            this.checkBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBalanceLabel.Location = new System.Drawing.Point(21, 10);
            this.checkBalanceLabel.Name = "checkBalanceLabel";
            this.checkBalanceLabel.Size = new System.Drawing.Size(188, 23);
            this.checkBalanceLabel.TabIndex = 0;
            this.checkBalanceLabel.Text = "Check Account Balance";
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.withdrawPanel.Controls.Add(this.withdrawButton);
            this.withdrawPanel.Controls.Add(this.withdrawAmountTextBox);
            this.withdrawPanel.Controls.Add(this.withdrawAmountLabel);
            this.withdrawPanel.Controls.Add(this.withdrawAccountTextBox);
            this.withdrawPanel.Controls.Add(this.withdrawAccountLabel);
            this.withdrawPanel.Controls.Add(this.withdrawLabel);
            this.withdrawPanel.Location = new System.Drawing.Point(100, 180);
            this.withdrawPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(415, 190);
            this.withdrawPanel.TabIndex = 1;
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.DarkGreen;
            this.withdrawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdrawButton.FlatAppearance.BorderSize = 0;
            this.withdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.withdrawButton.ForeColor = System.Drawing.Color.White;
            this.withdrawButton.Location = new System.Drawing.Point(260, 135);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(120, 35);
            this.withdrawButton.TabIndex = 5;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawAmountTextBox
            // 
            this.withdrawAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.withdrawAmountTextBox.Location = new System.Drawing.Point(140, 90);
            this.withdrawAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            this.withdrawAmountTextBox.Size = new System.Drawing.Size(240, 30);
            this.withdrawAmountTextBox.TabIndex = 4;
            // 
            // withdrawAmountLabel
            // 
            this.withdrawAmountLabel.AutoSize = true;
            this.withdrawAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.withdrawAmountLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.withdrawAmountLabel.Location = new System.Drawing.Point(21, 95);
            this.withdrawAmountLabel.Name = "withdrawAmountLabel";
            this.withdrawAmountLabel.Size = new System.Drawing.Size(65, 20);
            this.withdrawAmountLabel.TabIndex = 3;
            this.withdrawAmountLabel.Text = "Amount:";
            // 
            // withdrawAccountTextBox
            // 
            this.withdrawAccountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.withdrawAccountTextBox.Location = new System.Drawing.Point(140, 50);
            this.withdrawAccountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawAccountTextBox.Name = "withdrawAccountTextBox";
            this.withdrawAccountTextBox.Size = new System.Drawing.Size(240, 30);
            this.withdrawAccountTextBox.TabIndex = 2;
            // 
            // withdrawAccountLabel
            // 
            this.withdrawAccountLabel.AutoSize = true;
            this.withdrawAccountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.withdrawAccountLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.withdrawAccountLabel.Location = new System.Drawing.Point(21, 55);
            this.withdrawAccountLabel.Name = "withdrawAccountLabel";
            this.withdrawAccountLabel.Size = new System.Drawing.Size(90, 20);
            this.withdrawAccountLabel.TabIndex = 1;
            this.withdrawAccountLabel.Text = "Account No:";
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.withdrawLabel.Location = new System.Drawing.Point(20, 10);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(116, 25);
            this.withdrawLabel.TabIndex = 0;
            this.withdrawLabel.Text = "WITHDRAW";
            // 
            // depositPanel
            // 
            this.depositPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depositPanel.Controls.Add(this.depositButton);
            this.depositPanel.Controls.Add(this.depositAmountTextBox);
            this.depositPanel.Controls.Add(this.depositAmountLabel);
            this.depositPanel.Controls.Add(this.depositAccountTextBox);
            this.depositPanel.Controls.Add(this.depositAccountLabel);
            this.depositPanel.Controls.Add(this.depositLabel);
            this.depositPanel.Location = new System.Drawing.Point(535, 180);
            this.depositPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(415, 190);
            this.depositPanel.TabIndex = 2;
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.DarkGreen;
            this.depositButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositButton.FlatAppearance.BorderSize = 0;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.depositButton.ForeColor = System.Drawing.Color.White;
            this.depositButton.Location = new System.Drawing.Point(260, 135);
            this.depositButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(120, 35);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositAmountTextBox
            // 
            this.depositAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.depositAmountTextBox.Location = new System.Drawing.Point(140, 90);
            this.depositAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositAmountTextBox.Name = "depositAmountTextBox";
            this.depositAmountTextBox.Size = new System.Drawing.Size(240, 30);
            this.depositAmountTextBox.TabIndex = 4;
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.depositAmountLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.depositAmountLabel.Location = new System.Drawing.Point(21, 95);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(65, 20);
            this.depositAmountLabel.TabIndex = 3;
            this.depositAmountLabel.Text = "Amount:";
            // 
            // depositAccountTextBox
            // 
            this.depositAccountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.depositAccountTextBox.Location = new System.Drawing.Point(140, 50);
            this.depositAccountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositAccountTextBox.Name = "depositAccountTextBox";
            this.depositAccountTextBox.Size = new System.Drawing.Size(240, 30);
            this.depositAccountTextBox.TabIndex = 2;
            // 
            // depositAccountLabel
            // 
            this.depositAccountLabel.AutoSize = true;
            this.depositAccountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.depositAccountLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.depositAccountLabel.Location = new System.Drawing.Point(21, 55);
            this.depositAccountLabel.Name = "depositAccountLabel";
            this.depositAccountLabel.Size = new System.Drawing.Size(90, 20);
            this.depositAccountLabel.TabIndex = 1;
            this.depositAccountLabel.Text = "Account No:";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.depositLabel.Location = new System.Drawing.Point(20, 10);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(87, 25);
            this.depositLabel.TabIndex = 0;
            this.depositLabel.Text = "DEPOSIT";
            // 
            // transferPanel
            // 
            this.transferPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transferPanel.Controls.Add(this.transferButton);
            this.transferPanel.Controls.Add(this.transferAmountTextBox);
            this.transferPanel.Controls.Add(this.transferAmountLabel);
            this.transferPanel.Controls.Add(this.toAccountTextBox);
            this.transferPanel.Controls.Add(this.toLabel);
            this.transferPanel.Controls.Add(this.fromAccountTextBox);
            this.transferPanel.Controls.Add(this.fromLabel);
            this.transferPanel.Controls.Add(this.transferLabel);
            this.transferPanel.Location = new System.Drawing.Point(100, 390);
            this.transferPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transferPanel.Name = "transferPanel";
            this.transferPanel.Size = new System.Drawing.Size(850, 190);
            this.transferPanel.TabIndex = 3;
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.DarkGreen;
            this.transferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferButton.FlatAppearance.BorderSize = 0;
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.transferButton.ForeColor = System.Drawing.Color.White;
            this.transferButton.Location = new System.Drawing.Point(670, 135);
            this.transferButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(140, 35);
            this.transferButton.TabIndex = 9;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // transferAmountTextBox
            // 
            this.transferAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.transferAmountTextBox.Location = new System.Drawing.Point(460, 80);
            this.transferAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transferAmountTextBox.Name = "transferAmountTextBox";
            this.transferAmountTextBox.Size = new System.Drawing.Size(350, 30);
            this.transferAmountTextBox.TabIndex = 8;
            // 
            // transferAmountLabel
            // 
            this.transferAmountLabel.AutoSize = true;
            this.transferAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transferAmountLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.transferAmountLabel.Location = new System.Drawing.Point(456, 55);
            this.transferAmountLabel.Name = "transferAmountLabel";
            this.transferAmountLabel.Size = new System.Drawing.Size(121, 20);
            this.transferAmountLabel.TabIndex = 7;
            this.transferAmountLabel.Text = "Transfer Amount:";
            // 
            // toAccountTextBox
            // 
            this.toAccountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.toAccountTextBox.Location = new System.Drawing.Point(25, 140);
            this.toAccountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toAccountTextBox.Name = "toAccountTextBox";
            this.toAccountTextBox.Size = new System.Drawing.Size(350, 30);
            this.toAccountTextBox.TabIndex = 5;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.toLabel.Location = new System.Drawing.Point(21, 115);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(144, 20);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To Account Number:";
            // 
            // fromAccountTextBox
            // 
            this.fromAccountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.fromAccountTextBox.Location = new System.Drawing.Point(25, 80);
            this.fromAccountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromAccountTextBox.Name = "fromAccountTextBox";
            this.fromAccountTextBox.Size = new System.Drawing.Size(350, 30);
            this.fromAccountTextBox.TabIndex = 2;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.fromLabel.Location = new System.Drawing.Point(21, 55);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(162, 20);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From Account Number:";
            // 
            // transferLabel
            // 
            this.transferLabel.AutoSize = true;
            this.transferLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferLabel.ForeColor = System.Drawing.Color.Purple;
            this.transferLabel.Location = new System.Drawing.Point(20, 10);
            this.transferLabel.Name = "transferLabel";
            this.transferLabel.Size = new System.Drawing.Size(103, 25);
            this.transferLabel.TabIndex = 0;
            this.transferLabel.Text = "TRANSFER";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 620);
            this.Controls.Add(this.transferPanel);
            this.Controls.Add(this.depositPanel);
            this.Controls.Add(this.withdrawPanel);
            this.Controls.Add(this.balancePanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Transactions_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Transactions_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Transactions_MouseUp);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.balancePanel.ResumeLayout(false);
            this.balancePanel.PerformLayout();
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.transferPanel.ResumeLayout(false);
            this.transferPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Corrected variable declarations to match controls
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel balancePanel;
        private System.Windows.Forms.Label checkBalanceLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.Label withdrawAccountLabel;
        private System.Windows.Forms.TextBox withdrawAccountTextBox;
        private System.Windows.Forms.Label withdrawAmountLabel;
        private System.Windows.Forms.TextBox withdrawAmountTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label depositAccountLabel;
        private System.Windows.Forms.TextBox depositAccountTextBox;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.TextBox depositAmountTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Panel transferPanel;
        private System.Windows.Forms.Label transferLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox fromAccountTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toAccountTextBox;
        private System.Windows.Forms.Label transferAmountLabel;
        private System.Windows.Forms.TextBox transferAmountTextBox;
        private System.Windows.Forms.Button transferButton;
        // Removed search buttons as they weren't implemented
    }
}