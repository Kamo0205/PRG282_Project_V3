namespace PRG282_Project
{
    partial class FrmModifyUsers
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
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblRank = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.CmbRank = new System.Windows.Forms.ComboBox();
            this.LstUsers = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(13, 13);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(127, 24);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Modify Users";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(17, 51);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(20, 68);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(141, 68);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtSurname.TabIndex = 4;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(138, 51);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(49, 13);
            this.LblSurname.TabIndex = 3;
            this.LblSurname.Text = "Surname";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(20, 117);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 20);
            this.TxtAge.TabIndex = 6;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(17, 100);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(26, 13);
            this.LblAge.TabIndex = 5;
            this.LblAge.Text = "Age";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Enabled = false;
            this.TxtUsername.Location = new System.Drawing.Point(141, 117);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(100, 20);
            this.TxtUsername.TabIndex = 8;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(138, 100);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(55, 13);
            this.LblUsername.TabIndex = 7;
            this.LblUsername.Text = "Username";
            // 
            // LblRank
            // 
            this.LblRank.AutoSize = true;
            this.LblRank.Location = new System.Drawing.Point(17, 152);
            this.LblRank.Name = "LblRank";
            this.LblRank.Size = new System.Drawing.Size(33, 13);
            this.LblRank.TabIndex = 9;
            this.LblRank.Text = "Rank";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(141, 169);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 12;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(138, 152);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 11;
            this.LblPassword.Text = "Password";
            // 
            // CmbRank
            // 
            this.CmbRank.FormattingEnabled = true;
            this.CmbRank.Location = new System.Drawing.Point(17, 167);
            this.CmbRank.Name = "CmbRank";
            this.CmbRank.Size = new System.Drawing.Size(103, 21);
            this.CmbRank.TabIndex = 15;
            // 
            // LstUsers
            // 
            this.LstUsers.FormattingEnabled = true;
            this.LstUsers.Location = new System.Drawing.Point(274, 29);
            this.LstUsers.Name = "LstUsers";
            this.LstUsers.Size = new System.Drawing.Size(384, 160);
            this.LstUsers.TabIndex = 16;
            this.LstUsers.SelectedIndexChanged += new System.EventHandler(this.LstUsers_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(17, 200);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(104, 200);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 18;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(193, 200);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 19;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(332, 200);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 20;
            this.BtnPrevious.Text = "<<";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(520, 200);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 21;
            this.BtnNext.Text = ">>";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // FrmModifyUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 233);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstUsers);
            this.Controls.Add(this.CmbRank);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblRank);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblHeader);
            this.Name = "FrmModifyUsers";
            this.Text = "ModifyUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblRank;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.ComboBox CmbRank;
        private System.Windows.Forms.ListBox LstUsers;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
    }
}