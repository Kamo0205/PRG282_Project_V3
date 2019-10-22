namespace PRG282_Project
{
    partial class FrmPreviousMessages
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
            this.LblHeading = new System.Windows.Forms.Label();
            this.LstMessages = new System.Windows.Forms.ListBox();
            this.TxtMessageContent = new System.Windows.Forms.TextBox();
            this.LblMessageContent = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Location = new System.Drawing.Point(13, 13);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(61, 13);
            this.LblHeading.TabIndex = 0;
            this.LblHeading.Text = "Meassages";
            // 
            // LstMessages
            // 
            this.LstMessages.FormattingEnabled = true;
            this.LstMessages.Location = new System.Drawing.Point(16, 45);
            this.LstMessages.Name = "LstMessages";
            this.LstMessages.Size = new System.Drawing.Size(120, 186);
            this.LstMessages.TabIndex = 1;
            // 
            // TxtMessageContent
            // 
            this.TxtMessageContent.Location = new System.Drawing.Point(155, 45);
            this.TxtMessageContent.Multiline = true;
            this.TxtMessageContent.Name = "TxtMessageContent";
            this.TxtMessageContent.Size = new System.Drawing.Size(136, 186);
            this.TxtMessageContent.TabIndex = 2;
            // 
            // LblMessageContent
            // 
            this.LblMessageContent.AutoSize = true;
            this.LblMessageContent.Location = new System.Drawing.Point(178, 13);
            this.LblMessageContent.Name = "LblMessageContent";
            this.LblMessageContent.Size = new System.Drawing.Size(44, 13);
            this.LblMessageContent.TabIndex = 3;
            this.LblMessageContent.Text = "Content";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(16, 238);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // FrmPreviousMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 278);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblMessageContent);
            this.Controls.Add(this.TxtMessageContent);
            this.Controls.Add(this.LstMessages);
            this.Controls.Add(this.LblHeading);
            this.Name = "FrmPreviousMessages";
            this.Text = "Previous Messages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.ListBox LstMessages;
        private System.Windows.Forms.TextBox TxtMessageContent;
        private System.Windows.Forms.Label LblMessageContent;
        private System.Windows.Forms.Button BtnBack;
    }
}