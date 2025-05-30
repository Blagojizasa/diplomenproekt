namespace BankManagementSystem
{
    partial class AddAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccounts));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.AccountDGV = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.AcNameTbl = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.AcPhoneTbl = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.AcAddressTbl = new System.Windows.Forms.TextBox();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.OccupationTbl = new System.Windows.Forms.TextBox();
            this.labelEducation = new System.Windows.Forms.Label();
            this.EducationCb = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.GenderTbl = new System.Windows.Forms.ComboBox();
            this.labelIncome = new System.Windows.Forms.Label();
            this.IncomeTbl = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.DarkGreen;
            this.panelSidebar.Controls.Add(this.pictureBoxLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(67, 615);
            this.panelSidebar.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 15);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.AccountDGV);
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.AcNameTbl);
            this.panelMain.Controls.Add(this.labelPhone);
            this.panelMain.Controls.Add(this.AcPhoneTbl);
            this.panelMain.Controls.Add(this.labelAddress);
            this.panelMain.Controls.Add(this.AcAddressTbl);
            this.panelMain.Controls.Add(this.labelOccupation);
            this.panelMain.Controls.Add(this.OccupationTbl);
            this.panelMain.Controls.Add(this.labelEducation);
            this.panelMain.Controls.Add(this.EducationCb);
            this.panelMain.Controls.Add(this.labelGender);
            this.panelMain.Controls.Add(this.GenderTbl);
            this.panelMain.Controls.Add(this.labelIncome);
            this.panelMain.Controls.Add(this.IncomeTbl);
            this.panelMain.Controls.Add(this.SubmitBtn);
            this.panelMain.Controls.Add(this.EditBtn);
            this.panelMain.Controls.Add(this.DeleteBtn);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(67, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1266, 615);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // AccountDGV
            // 
            this.AccountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDGV.Location = new System.Drawing.Point(0, 413);
            this.AccountDGV.Name = "AccountDGV";
            this.AccountDGV.RowHeadersWidth = 51;
            this.AccountDGV.RowTemplate.Height = 24;
            this.AccountDGV.Size = new System.Drawing.Size(1254, 199);
            this.AccountDGV.TabIndex = 19;
            this.AccountDGV.SelectionChanged += new System.EventHandler(this.AccountDGV_SelectionChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTitle.Location = new System.Drawing.Point(486, 23);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(217, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "New Account Form";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClose.Location = new System.Drawing.Point(1213, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(133, 98);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // AcNameTbl
            // 
            this.AcNameTbl.Location = new System.Drawing.Point(133, 118);
            this.AcNameTbl.Margin = new System.Windows.Forms.Padding(4);
            this.AcNameTbl.Name = "AcNameTbl";
            this.AcNameTbl.Size = new System.Drawing.Size(239, 22);
            this.AcNameTbl.TabIndex = 2;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(400, 98);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(46, 16);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone";
            // 
            // AcPhoneTbl
            // 
            this.AcPhoneTbl.Location = new System.Drawing.Point(400, 118);
            this.AcPhoneTbl.Margin = new System.Windows.Forms.Padding(4);
            this.AcPhoneTbl.Name = "AcPhoneTbl";
            this.AcPhoneTbl.Size = new System.Drawing.Size(239, 22);
            this.AcPhoneTbl.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(667, 98);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // AcAddressTbl
            // 
            this.AcAddressTbl.Location = new System.Drawing.Point(667, 118);
            this.AcAddressTbl.Margin = new System.Windows.Forms.Padding(4);
            this.AcAddressTbl.Multiline = true;
            this.AcAddressTbl.Name = "AcAddressTbl";
            this.AcAddressTbl.Size = new System.Drawing.Size(239, 86);
            this.AcAddressTbl.TabIndex = 6;
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Location = new System.Drawing.Point(929, 98);
            this.labelOccupation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(75, 16);
            this.labelOccupation.TabIndex = 7;
            this.labelOccupation.Text = "Occupation";
            this.labelOccupation.Click += new System.EventHandler(this.labelOccupation_Click);
            // 
            // OccupationTbl
            // 
            this.OccupationTbl.Location = new System.Drawing.Point(932, 118);
            this.OccupationTbl.Margin = new System.Windows.Forms.Padding(4);
            this.OccupationTbl.Name = "OccupationTbl";
            this.OccupationTbl.Size = new System.Drawing.Size(239, 22);
            this.OccupationTbl.TabIndex = 8;
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(133, 160);
            this.labelEducation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(67, 16);
            this.labelEducation.TabIndex = 9;
            this.labelEducation.Text = "Education";
            // 
            // EducationCb
            // 
            this.EducationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EducationCb.FormattingEnabled = true;
            this.EducationCb.Items.AddRange(new object[] {
            "High School",
            "Associate Degree",
            "Bachelor\'s Degree",
            "Master\'s Degree",
            "Doctorate"});
            this.EducationCb.Location = new System.Drawing.Point(133, 180);
            this.EducationCb.Margin = new System.Windows.Forms.Padding(4);
            this.EducationCb.Name = "EducationCb";
            this.EducationCb.Size = new System.Drawing.Size(239, 24);
            this.EducationCb.TabIndex = 10;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(400, 160);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 16);
            this.labelGender.TabIndex = 11;
            this.labelGender.Text = "Gender";
            // 
            // GenderTbl
            // 
            this.GenderTbl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderTbl.FormattingEnabled = true;
            this.GenderTbl.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderTbl.Location = new System.Drawing.Point(400, 180);
            this.GenderTbl.Margin = new System.Windows.Forms.Padding(4);
            this.GenderTbl.Name = "GenderTbl";
            this.GenderTbl.Size = new System.Drawing.Size(239, 24);
            this.GenderTbl.TabIndex = 12;
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(929, 162);
            this.labelIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(51, 16);
            this.labelIncome.TabIndex = 13;
            this.labelIncome.Text = "Income";
            // 
            // IncomeTbl
            // 
            this.IncomeTbl.Location = new System.Drawing.Point(932, 182);
            this.IncomeTbl.Margin = new System.Windows.Forms.Padding(4);
            this.IncomeTbl.Name = "IncomeTbl";
            this.IncomeTbl.Size = new System.Drawing.Size(239, 22);
            this.IncomeTbl.TabIndex = 14;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(244, 369);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(133, 37);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(431, 369);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(133, 37);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(617, 369);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(133, 37);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Cancel";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddAccounts_Load);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox AcNameTbl;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox AcPhoneTbl;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox AcAddressTbl;
        private System.Windows.Forms.Label labelOccupation;
        private System.Windows.Forms.TextBox OccupationTbl;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.ComboBox EducationCb;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox GenderTbl;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.TextBox IncomeTbl;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView AccountDGV;
    }
}