namespace PRG282_Project
{
    partial class FrmAllDecryptedMessages
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblMessageContent = new System.Windows.Forms.Label();
            this.TxtMessageContent = new System.Windows.Forms.TextBox();
            this.LstMessages = new System.Windows.Forms.ListBox();
            this.LblHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(6, 232);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // LblMessageContent
            // 
            this.LblMessageContent.AutoSize = true;
            this.LblMessageContent.Location = new System.Drawing.Point(152, 104);
            this.LblMessageContent.Name = "LblMessageContent";
            this.LblMessageContent.Size = new System.Drawing.Size(44, 13);
            this.LblMessageContent.TabIndex = 8;
            this.LblMessageContent.Text = "Content";
            // 
            // TxtMessageContent
            // 
            this.TxtMessageContent.Location = new System.Drawing.Point(145, 120);
            this.TxtMessageContent.Multiline = true;
            this.TxtMessageContent.Name = "TxtMessageContent";
            this.TxtMessageContent.Size = new System.Drawing.Size(221, 105);
            this.TxtMessageContent.TabIndex = 7;
            // 
            // LstMessages
            // 
            this.LstMessages.FormattingEnabled = true;
            this.LstMessages.Location = new System.Drawing.Point(6, 39);
            this.LstMessages.Name = "LstMessages";
            this.LstMessages.Size = new System.Drawing.Size(120, 186);
            this.LstMessages.TabIndex = 6;
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Location = new System.Drawing.Point(3, 7);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(61, 13);
            this.LblHeading.TabIndex = 5;
            this.LblHeading.Text = "Meassages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "By Who: ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(150, 72);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(86, 20);
            this.TxtName.TabIndex = 10;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(255, 72);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(86, 20);
            this.TxtSurname.TabIndex = 12;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(163, 56);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 13;
            this.LblName.Text = "Name";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(268, 56);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(49, 13);
            this.LblSurname.TabIndex = 14;
            this.LblSurname.Text = "Surname";
            // 
            // FrmAllDecryptedMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 270);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblMessageContent);
            this.Controls.Add(this.TxtMessageContent);
            this.Controls.Add(this.LstMessages);
            this.Controls.Add(this.LblHeading);
            this.Name = "FrmAllDecryptedMessages";
            this.Text = "All Decrypted Messages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblMessageContent;
        private System.Windows.Forms.TextBox TxtMessageContent;
        private System.Windows.Forms.ListBox LstMessages;
        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
    }
}