﻿namespace PRG282_Project
{
    partial class EncryptDecrypt
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
            this.LblEncryptDecrypt = new System.Windows.Forms.Label();
            this.LblFileLocation = new System.Windows.Forms.Label();
            this.TxtFileLocation = new System.Windows.Forms.TextBox();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblOriginal = new System.Windows.Forms.Label();
            this.TxtOriginal = new System.Windows.Forms.TextBox();
            this.TxtNew = new System.Windows.Forms.TextBox();
            this.LblNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEncryptDecrypt
            // 
            this.LblEncryptDecrypt.AutoSize = true;
            this.LblEncryptDecrypt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncryptDecrypt.Location = new System.Drawing.Point(75, 9);
            this.LblEncryptDecrypt.Name = "LblEncryptDecrypt";
            this.LblEncryptDecrypt.Size = new System.Drawing.Size(181, 24);
            this.LblEncryptDecrypt.TabIndex = 0;
            this.LblEncryptDecrypt.Text = "Encrypt or Decrypt";
            // 
            // LblFileLocation
            // 
            this.LblFileLocation.AutoSize = true;
            this.LblFileLocation.Location = new System.Drawing.Point(34, 40);
            this.LblFileLocation.Name = "LblFileLocation";
            this.LblFileLocation.Size = new System.Drawing.Size(70, 13);
            this.LblFileLocation.TabIndex = 1;
            this.LblFileLocation.Text = "File Location:";
            // 
            // TxtFileLocation
            // 
            this.TxtFileLocation.Location = new System.Drawing.Point(23, 56);
            this.TxtFileLocation.Name = "TxtFileLocation";
            this.TxtFileLocation.Size = new System.Drawing.Size(100, 20);
            this.TxtFileLocation.TabIndex = 2;
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(23, 83);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.BtnDecrypt.TabIndex = 3;
            this.BtnDecrypt.Text = "Decrypt";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Location = new System.Drawing.Point(23, 112);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.BtnEncrypt.TabIndex = 4;
            this.BtnEncrypt.Text = "Encrypt";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(23, 141);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // LblOriginal
            // 
            this.LblOriginal.AutoSize = true;
            this.LblOriginal.Location = new System.Drawing.Point(209, 40);
            this.LblOriginal.Name = "LblOriginal";
            this.LblOriginal.Size = new System.Drawing.Size(45, 13);
            this.LblOriginal.TabIndex = 6;
            this.LblOriginal.Text = "Original:";
            // 
            // TxtOriginal
            // 
            this.TxtOriginal.Location = new System.Drawing.Point(198, 55);
            this.TxtOriginal.Multiline = true;
            this.TxtOriginal.Name = "TxtOriginal";
            this.TxtOriginal.Size = new System.Drawing.Size(126, 80);
            this.TxtOriginal.TabIndex = 7;
            // 
            // TxtNew
            // 
            this.TxtNew.Location = new System.Drawing.Point(198, 156);
            this.TxtNew.Multiline = true;
            this.TxtNew.Name = "TxtNew";
            this.TxtNew.Size = new System.Drawing.Size(126, 98);
            this.TxtNew.TabIndex = 9;
            // 
            // LblNew
            // 
            this.LblNew.AutoSize = true;
            this.LblNew.Location = new System.Drawing.Point(209, 141);
            this.LblNew.Name = "LblNew";
            this.LblNew.Size = new System.Drawing.Size(32, 13);
            this.LblNew.TabIndex = 8;
            this.LblNew.Text = "New:";
            // 
            // EncryptDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 266);
            this.Controls.Add(this.TxtNew);
            this.Controls.Add(this.LblNew);
            this.Controls.Add(this.TxtOriginal);
            this.Controls.Add(this.LblOriginal);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEncrypt);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.TxtFileLocation);
            this.Controls.Add(this.LblFileLocation);
            this.Controls.Add(this.LblEncryptDecrypt);
            this.Name = "EncryptDecrypt";
            this.Text = "EncryptDecrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEncryptDecrypt;
        private System.Windows.Forms.Label LblFileLocation;
        private System.Windows.Forms.TextBox TxtFileLocation;
        private System.Windows.Forms.Button BtnDecrypt;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblOriginal;
        private System.Windows.Forms.TextBox TxtOriginal;
        private System.Windows.Forms.TextBox TxtNew;
        private System.Windows.Forms.Label LblNew;
    }
}