﻿namespace Film
{
    partial class FormResultShare
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
            this.LBResultShare = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBResultShare
            // 
            this.LBResultShare.FormattingEnabled = true;
            this.LBResultShare.Location = new System.Drawing.Point(26, 12);
            this.LBResultShare.Name = "LBResultShare";
            this.LBResultShare.Size = new System.Drawing.Size(733, 407);
            this.LBResultShare.TabIndex = 0;
            // 
            // FormResultShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBResultShare);
            this.Name = "FormResultShare";
            this.Text = "FormResultShare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBResultShare;
    }
}