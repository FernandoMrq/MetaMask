﻿namespace MetaMask.Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iniciaChrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciaChrome
            // 
            this.iniciaChrome.Location = new System.Drawing.Point(27, 19);
            this.iniciaChrome.Name = "iniciaChrome";
            this.iniciaChrome.Size = new System.Drawing.Size(111, 23);
            this.iniciaChrome.TabIndex = 0;
            this.iniciaChrome.Text = "Inicia Chrome";
            this.iniciaChrome.UseVisualStyleBackColor = true;
            this.iniciaChrome.Click += new System.EventHandler(this.iniciaChrome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iniciaChrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button iniciaChrome;
    }
}