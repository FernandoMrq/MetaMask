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
            this.btnAtualizarToken = new System.Windows.Forms.Button();
            this.valorToken = new System.Windows.Forms.Label();
            this.tokenAdressOrigem = new System.Windows.Forms.TextBox();
            this.walletAdressOrigem = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.btnAtualizarBalance = new System.Windows.Forms.Button();
            this.consoleMessage = new System.Windows.Forms.TextBox();
            this.lblTokenOrigem = new System.Windows.Forms.Label();
            this.lblWalletOrigem = new System.Windows.Forms.Label();
            this.lblTokenDestino = new System.Windows.Forms.Label();
            this.tokenAdressDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.walletAdressDestino = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.privateKeyOrigem = new System.Windows.Forms.TextBox();
            this.btnTransferirParaDestino = new System.Windows.Forms.Button();
            this.btnSwapTokens = new System.Windows.Forms.Button();
            this.quantidadeOrigem = new System.Windows.Forms.TextBox();
            this.lblQuantidadeOrigem = new System.Windows.Forms.Label();
            this.lblQuantidadeDestino = new System.Windows.Forms.Label();
            this.quantidadeDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAtualizarToken
            // 
            this.btnAtualizarToken.Location = new System.Drawing.Point(12, 74);
            this.btnAtualizarToken.Name = "btnAtualizarToken";
            this.btnAtualizarToken.Size = new System.Drawing.Size(122, 22);
            this.btnAtualizarToken.TabIndex = 1;
            this.btnAtualizarToken.Text = "Atualiza Valor Token";
            this.btnAtualizarToken.UseVisualStyleBackColor = true;
            this.btnAtualizarToken.Click += new System.EventHandler(this.btnTokenPrice_ClickAsync);
            // 
            // valorToken
            // 
            this.valorToken.AutoSize = true;
            this.valorToken.Location = new System.Drawing.Point(12, 56);
            this.valorToken.Name = "valorToken";
            this.valorToken.Size = new System.Drawing.Size(33, 15);
            this.valorToken.TabIndex = 2;
            this.valorToken.Text = "Valor";
            // 
            // tokenAdressOrigem
            // 
            this.tokenAdressOrigem.Location = new System.Drawing.Point(12, 30);
            this.tokenAdressOrigem.Name = "tokenAdressOrigem";
            this.tokenAdressOrigem.Size = new System.Drawing.Size(301, 23);
            this.tokenAdressOrigem.TabIndex = 3;
            // 
            // walletAdressOrigem
            // 
            this.walletAdressOrigem.Location = new System.Drawing.Point(487, 30);
            this.walletAdressOrigem.Name = "walletAdressOrigem";
            this.walletAdressOrigem.Size = new System.Drawing.Size(301, 23);
            this.walletAdressOrigem.TabIndex = 4;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(487, 56);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(48, 15);
            this.balance.TabIndex = 5;
            this.balance.Text = "Balance";
            // 
            // btnAtualizarBalance
            // 
            this.btnAtualizarBalance.Location = new System.Drawing.Point(487, 74);
            this.btnAtualizarBalance.Name = "btnAtualizarBalance";
            this.btnAtualizarBalance.Size = new System.Drawing.Size(122, 22);
            this.btnAtualizarBalance.TabIndex = 6;
            this.btnAtualizarBalance.Text = "Atualiza Balance";
            this.btnAtualizarBalance.UseVisualStyleBackColor = true;
            this.btnAtualizarBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // consoleMessage
            // 
            this.consoleMessage.BackColor = System.Drawing.SystemColors.InfoText;
            this.consoleMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.consoleMessage.Location = new System.Drawing.Point(12, 305);
            this.consoleMessage.Multiline = true;
            this.consoleMessage.Name = "consoleMessage";
            this.consoleMessage.Size = new System.Drawing.Size(776, 133);
            this.consoleMessage.TabIndex = 7;
            // 
            // lblTokenOrigem
            // 
            this.lblTokenOrigem.AutoSize = true;
            this.lblTokenOrigem.Location = new System.Drawing.Point(12, 9);
            this.lblTokenOrigem.Name = "lblTokenOrigem";
            this.lblTokenOrigem.Size = new System.Drawing.Size(89, 15);
            this.lblTokenOrigem.TabIndex = 8;
            this.lblTokenOrigem.Text = "Token / Origem";
            // 
            // lblWalletOrigem
            // 
            this.lblWalletOrigem.AutoSize = true;
            this.lblWalletOrigem.Location = new System.Drawing.Point(488, 9);
            this.lblWalletOrigem.Name = "lblWalletOrigem";
            this.lblWalletOrigem.Size = new System.Drawing.Size(91, 15);
            this.lblWalletOrigem.TabIndex = 9;
            this.lblWalletOrigem.Text = "Wallet / Origem";
            // 
            // lblTokenDestino
            // 
            this.lblTokenDestino.AutoSize = true;
            this.lblTokenDestino.Location = new System.Drawing.Point(12, 99);
            this.lblTokenDestino.Name = "lblTokenDestino";
            this.lblTokenDestino.Size = new System.Drawing.Size(89, 15);
            this.lblTokenDestino.TabIndex = 11;
            this.lblTokenDestino.Text = "Token / Destino";
            // 
            // tokenAdressDestino
            // 
            this.tokenAdressDestino.Location = new System.Drawing.Point(12, 117);
            this.tokenAdressDestino.Name = "tokenAdressDestino";
            this.tokenAdressDestino.Size = new System.Drawing.Size(301, 23);
            this.tokenAdressDestino.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wallet / Origem";
            // 
            // walletAdressDestino
            // 
            this.walletAdressDestino.Location = new System.Drawing.Point(487, 117);
            this.walletAdressDestino.Name = "walletAdressDestino";
            this.walletAdressDestino.Size = new System.Drawing.Size(301, 23);
            this.walletAdressDestino.TabIndex = 12;
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(12, 143);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(105, 15);
            this.lblPrivateKey.TabIndex = 15;
            this.lblPrivateKey.Text = "PrivateKey Origem";
            // 
            // privateKeyOrigem
            // 
            this.privateKeyOrigem.Location = new System.Drawing.Point(12, 161);
            this.privateKeyOrigem.Name = "privateKeyOrigem";
            this.privateKeyOrigem.Size = new System.Drawing.Size(301, 23);
            this.privateKeyOrigem.TabIndex = 14;
            this.privateKeyOrigem.UseSystemPasswordChar = true;
            // 
            // btnTransferirParaDestino
            // 
            this.btnTransferirParaDestino.Location = new System.Drawing.Point(487, 277);
            this.btnTransferirParaDestino.Name = "btnTransferirParaDestino";
            this.btnTransferirParaDestino.Size = new System.Drawing.Size(137, 22);
            this.btnTransferirParaDestino.TabIndex = 16;
            this.btnTransferirParaDestino.Text = "Trasferir para destino";
            this.btnTransferirParaDestino.UseVisualStyleBackColor = true;
            this.btnTransferirParaDestino.Click += new System.EventHandler(this.btnTransferirParaDestino_Click);
            // 
            // btnSwapTokens
            // 
            this.btnSwapTokens.Location = new System.Drawing.Point(12, 277);
            this.btnSwapTokens.Name = "btnSwapTokens";
            this.btnSwapTokens.Size = new System.Drawing.Size(137, 22);
            this.btnSwapTokens.TabIndex = 17;
            this.btnSwapTokens.Text = "Swap Tokens";
            this.btnSwapTokens.UseVisualStyleBackColor = true;
            this.btnSwapTokens.Click += new System.EventHandler(this.btnSwapTokens_Click);
            // 
            // quantidadeOrigem
            // 
            this.quantidadeOrigem.Location = new System.Drawing.Point(488, 161);
            this.quantidadeOrigem.Name = "quantidadeOrigem";
            this.quantidadeOrigem.Size = new System.Drawing.Size(301, 23);
            this.quantidadeOrigem.TabIndex = 18;
            // 
            // lblQuantidadeOrigem
            // 
            this.lblQuantidadeOrigem.AutoSize = true;
            this.lblQuantidadeOrigem.Location = new System.Drawing.Point(487, 143);
            this.lblQuantidadeOrigem.Name = "lblQuantidadeOrigem";
            this.lblQuantidadeOrigem.Size = new System.Drawing.Size(112, 15);
            this.lblQuantidadeOrigem.TabIndex = 19;
            this.lblQuantidadeOrigem.Text = "Quantidade Origem";
            // 
            // lblQuantidadeDestino
            // 
            this.lblQuantidadeDestino.AutoSize = true;
            this.lblQuantidadeDestino.Location = new System.Drawing.Point(11, 191);
            this.lblQuantidadeDestino.Name = "lblQuantidadeDestino";
            this.lblQuantidadeDestino.Size = new System.Drawing.Size(112, 15);
            this.lblQuantidadeDestino.TabIndex = 21;
            this.lblQuantidadeDestino.Text = "Quantidade Destino";
            // 
            // quantidadeDestino
            // 
            this.quantidadeDestino.Location = new System.Drawing.Point(12, 209);
            this.quantidadeDestino.Name = "quantidadeDestino";
            this.quantidadeDestino.Size = new System.Drawing.Size(301, 23);
            this.quantidadeDestino.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuantidadeDestino);
            this.Controls.Add(this.quantidadeDestino);
            this.Controls.Add(this.lblQuantidadeOrigem);
            this.Controls.Add(this.quantidadeOrigem);
            this.Controls.Add(this.btnSwapTokens);
            this.Controls.Add(this.btnTransferirParaDestino);
            this.Controls.Add(this.lblPrivateKey);
            this.Controls.Add(this.privateKeyOrigem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.walletAdressDestino);
            this.Controls.Add(this.lblTokenDestino);
            this.Controls.Add(this.tokenAdressDestino);
            this.Controls.Add(this.lblWalletOrigem);
            this.Controls.Add(this.lblTokenOrigem);
            this.Controls.Add(this.consoleMessage);
            this.Controls.Add(this.btnAtualizarBalance);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.walletAdressOrigem);
            this.Controls.Add(this.tokenAdressOrigem);
            this.Controls.Add(this.valorToken);
            this.Controls.Add(this.btnAtualizarToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAtualizarToken;
        private Label valorToken;
        private TextBox tokenAdressOrigem;
        private TextBox walletAdressOrigem;
        private Label balance;
        private Button btnAtualizarBalance;
        private TextBox consoleMessage;
        private Label lblTokenOrigem;
        private Label lblWalletOrigem;
        private Label lblTokenDestino;
        private TextBox tokenAdressDestino;
        private Label label1;
        private TextBox walletAdressDestino;
        private Label lblPrivateKey;
        private TextBox privateKeyOrigem;
        private Button btnTransferirParaDestino;
        private Button btnSwapTokens;
        private TextBox quantidadeOrigem;
        private Label lblQuantidadeOrigem;
        private Label lblQuantidadeDestino;
        private TextBox quantidadeDestino;
    }
}