namespace MRQ.CryptoBot.Client
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
            this.button1 = new System.Windows.Forms.Button();
            this.valorToken = new System.Windows.Forms.Label();
            this.tokenAdress = new System.Windows.Forms.TextBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualiza Valor Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // valorToken
            // 
            this.valorToken.AutoSize = true;
            this.valorToken.Location = new System.Drawing.Point(27, 382);
            this.valorToken.Name = "valorToken";
            this.valorToken.Size = new System.Drawing.Size(33, 15);
            this.valorToken.TabIndex = 2;
            this.valorToken.Text = "Valor";
            // 
            // tokenAdress
            // 
            this.tokenAdress.Location = new System.Drawing.Point(27, 347);
            this.tokenAdress.Name = "tokenAdress";
            this.tokenAdress.Size = new System.Drawing.Size(301, 23);
            this.tokenAdress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tokenAdress);
            this.Controls.Add(this.valorToken);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iniciaChrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button iniciaChrome;
        private Button button1;
        private Label valorToken;
        private TextBox tokenAdress;
    }
}