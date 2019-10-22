namespace PRG282_Project
{
    partial class FrmWelcomeScreen
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
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnDecryptMessage = new System.Windows.Forms.Button();
            this.BtnEncryptMessage = new System.Windows.Forms.Button();
            this.BtnViewPreviousMessages = new System.Windows.Forms.Button();
            this.BtnViewDecryptedMessages = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.Location = new System.Drawing.Point(68, 9);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(234, 40);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Wlecome User";
            // 
            // BtnDecryptMessage
            // 
            this.BtnDecryptMessage.Location = new System.Drawing.Point(75, 62);
            this.BtnDecryptMessage.Name = "BtnDecryptMessage";
            this.BtnDecryptMessage.Size = new System.Drawing.Size(118, 23);
            this.BtnDecryptMessage.TabIndex = 1;
            this.BtnDecryptMessage.Text = "Decrypt Message";
            this.BtnDecryptMessage.UseVisualStyleBackColor = true;
            // 
            // BtnEncryptMessage
            // 
            this.BtnEncryptMessage.Location = new System.Drawing.Point(199, 62);
            this.BtnEncryptMessage.Name = "BtnEncryptMessage";
            this.BtnEncryptMessage.Size = new System.Drawing.Size(118, 23);
            this.BtnEncryptMessage.TabIndex = 2;
            this.BtnEncryptMessage.Text = "Encrypt Message";
            this.BtnEncryptMessage.UseVisualStyleBackColor = true;
            this.BtnEncryptMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnViewPreviousMessages
            // 
            this.BtnViewPreviousMessages.Location = new System.Drawing.Point(75, 96);
            this.BtnViewPreviousMessages.Name = "BtnViewPreviousMessages";
            this.BtnViewPreviousMessages.Size = new System.Drawing.Size(118, 34);
            this.BtnViewPreviousMessages.TabIndex = 3;
            this.BtnViewPreviousMessages.Text = "View Previous Messages";
            this.BtnViewPreviousMessages.UseVisualStyleBackColor = true;
            // 
            // BtnViewDecryptedMessages
            // 
            this.BtnViewDecryptedMessages.Location = new System.Drawing.Point(199, 95);
            this.BtnViewDecryptedMessages.Name = "BtnViewDecryptedMessages";
            this.BtnViewDecryptedMessages.Size = new System.Drawing.Size(118, 35);
            this.BtnViewDecryptedMessages.TabIndex = 4;
            this.BtnViewDecryptedMessages.Text = "View Decrypted Messages";
            this.BtnViewDecryptedMessages.UseVisualStyleBackColor = true;
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(143, 146);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(118, 23);
            this.BtnQuit.TabIndex = 5;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            // 
            // FrmWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 187);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnViewDecryptedMessages);
            this.Controls.Add(this.BtnViewPreviousMessages);
            this.Controls.Add(this.BtnEncryptMessage);
            this.Controls.Add(this.BtnDecryptMessage);
            this.Controls.Add(this.LblWelcome);
            this.Name = "FrmWelcomeScreen";
            this.Text = "Welcom Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Button BtnDecryptMessage;
        private System.Windows.Forms.Button BtnEncryptMessage;
        private System.Windows.Forms.Button BtnViewPreviousMessages;
        private System.Windows.Forms.Button BtnViewDecryptedMessages;
        private System.Windows.Forms.Button BtnQuit;
    }
}