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
            this.walletadress = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            // walletadress
            // 
            this.walletadress.Location = new System.Drawing.Point(374, 347);
            this.walletadress.Name = "walletadress";
            this.walletadress.Size = new System.Drawing.Size(301, 23);
            this.walletadress.TabIndex = 4;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(374, 382);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(48, 15);
            this.balance.TabIndex = 5;
            this.balance.Text = "Balance";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Atualiza Balance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.walletadress);
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
        private TextBox walletadress;
        private Label balance;
        private Button button2;
    }
}