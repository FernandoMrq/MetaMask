namespace MRQ.CryptoBot.Client.Interfaces
{
    partial class ConfigurationInterface
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
            this.pnlGlobal = new System.Windows.Forms.Panel();
            this.pnlTimes = new System.Windows.Forms.Panel();
            this.txtTimeBetweenWalletBalanceUpdate = new System.Windows.Forms.TextBox();
            this.lblTimeBetweenWalletBalanceUpdate = new System.Windows.Forms.Label();
            this.lblTimeBetweenPriceUpdate = new System.Windows.Forms.Label();
            this.txtTimeBetweenPriceUpdate = new System.Windows.Forms.TextBox();
            this.txtTimeForPingConnectionWithWeb3 = new System.Windows.Forms.TextBox();
            this.lblTimeForPingConnectionWithWeb3 = new System.Windows.Forms.Label();
            this.lblTimeForPingConnectionWithInternet = new System.Windows.Forms.Label();
            this.txtTimeForPingConnectionWithInternet = new System.Windows.Forms.TextBox();
            this.pnlMoralisApiKeys = new System.Windows.Forms.Panel();
            this.pnlMoralis = new System.Windows.Forms.Panel();
            this.cbxChainType = new System.Windows.Forms.ComboBox();
            this.lblChainType = new System.Windows.Forms.Label();
            this.lblKeyName = new System.Windows.Forms.Label();
            this.txtKeyName = new System.Windows.Forms.TextBox();
            this.pnlTableRoutersForSwaps = new System.Windows.Forms.Panel();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.lblSlippageTolerance = new System.Windows.Forms.Label();
            this.txtSlippageTolerance = new System.Windows.Forms.TextBox();
            this.txtTokenDefaultContract = new System.Windows.Forms.TextBox();
            this.lblTokenDefaultContract = new System.Windows.Forms.Label();
            this.lblDefaultGas = new System.Windows.Forms.Label();
            this.lblDefaultGasPrice = new System.Windows.Forms.Label();
            this.txtDefaultGas = new System.Windows.Forms.TextBox();
            this.txtDefaultGasPrice = new System.Windows.Forms.TextBox();
            this.txtContractABI = new System.Windows.Forms.TextBox();
            this.txtContractRouterForSwap = new System.Windows.Forms.TextBox();
            this.lblContractRouterForSwap = new System.Windows.Forms.Label();
            this.lblContractABI = new System.Windows.Forms.Label();
            this.lblWeb3Url = new System.Windows.Forms.Label();
            this.txtWeb3Url = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlGlobal.SuspendLayout();
            this.pnlTimes.SuspendLayout();
            this.pnlMoralis.SuspendLayout();
            this.pnlOperation.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGlobal
            // 
            this.pnlGlobal.AutoScroll = true;
            this.pnlGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGlobal.Controls.Add(this.pnlBotoes);
            this.pnlGlobal.Controls.Add(this.pnlTimes);
            this.pnlGlobal.Controls.Add(this.pnlMoralisApiKeys);
            this.pnlGlobal.Controls.Add(this.pnlMoralis);
            this.pnlGlobal.Controls.Add(this.pnlTableRoutersForSwaps);
            this.pnlGlobal.Controls.Add(this.pnlOperation);
            this.pnlGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlobal.Location = new System.Drawing.Point(0, 0);
            this.pnlGlobal.Name = "pnlGlobal";
            this.pnlGlobal.Size = new System.Drawing.Size(802, 441);
            this.pnlGlobal.TabIndex = 0;
            // 
            // pnlTimes
            // 
            this.pnlTimes.Controls.Add(this.txtTimeBetweenWalletBalanceUpdate);
            this.pnlTimes.Controls.Add(this.lblTimeBetweenWalletBalanceUpdate);
            this.pnlTimes.Controls.Add(this.lblTimeBetweenPriceUpdate);
            this.pnlTimes.Controls.Add(this.txtTimeBetweenPriceUpdate);
            this.pnlTimes.Controls.Add(this.txtTimeForPingConnectionWithWeb3);
            this.pnlTimes.Controls.Add(this.lblTimeForPingConnectionWithWeb3);
            this.pnlTimes.Controls.Add(this.lblTimeForPingConnectionWithInternet);
            this.pnlTimes.Controls.Add(this.txtTimeForPingConnectionWithInternet);
            this.pnlTimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimes.Location = new System.Drawing.Point(0, 409);
            this.pnlTimes.Name = "pnlTimes";
            this.pnlTimes.Size = new System.Drawing.Size(783, 100);
            this.pnlTimes.TabIndex = 6;
            // 
            // txtTimeBetweenWalletBalanceUpdate
            // 
            this.txtTimeBetweenWalletBalanceUpdate.Location = new System.Drawing.Point(11, 65);
            this.txtTimeBetweenWalletBalanceUpdate.Name = "txtTimeBetweenWalletBalanceUpdate";
            this.txtTimeBetweenWalletBalanceUpdate.Size = new System.Drawing.Size(217, 23);
            this.txtTimeBetweenWalletBalanceUpdate.TabIndex = 23;
            // 
            // lblTimeBetweenWalletBalanceUpdate
            // 
            this.lblTimeBetweenWalletBalanceUpdate.AutoSize = true;
            this.lblTimeBetweenWalletBalanceUpdate.Location = new System.Drawing.Point(11, 47);
            this.lblTimeBetweenWalletBalanceUpdate.Name = "lblTimeBetweenWalletBalanceUpdate";
            this.lblTimeBetweenWalletBalanceUpdate.Size = new System.Drawing.Size(202, 15);
            this.lblTimeBetweenWalletBalanceUpdate.TabIndex = 22;
            this.lblTimeBetweenWalletBalanceUpdate.Text = "Time Between Wallet Balance Update";
            // 
            // lblTimeBetweenPriceUpdate
            // 
            this.lblTimeBetweenPriceUpdate.AutoSize = true;
            this.lblTimeBetweenPriceUpdate.Location = new System.Drawing.Point(457, 3);
            this.lblTimeBetweenPriceUpdate.Name = "lblTimeBetweenPriceUpdate";
            this.lblTimeBetweenPriceUpdate.Size = new System.Drawing.Size(151, 15);
            this.lblTimeBetweenPriceUpdate.TabIndex = 21;
            this.lblTimeBetweenPriceUpdate.Text = "Time Between Price Update";
            // 
            // txtTimeBetweenPriceUpdate
            // 
            this.txtTimeBetweenPriceUpdate.Location = new System.Drawing.Point(457, 21);
            this.txtTimeBetweenPriceUpdate.Name = "txtTimeBetweenPriceUpdate";
            this.txtTimeBetweenPriceUpdate.Size = new System.Drawing.Size(313, 23);
            this.txtTimeBetweenPriceUpdate.TabIndex = 20;
            // 
            // txtTimeForPingConnectionWithWeb3
            // 
            this.txtTimeForPingConnectionWithWeb3.Location = new System.Drawing.Point(234, 21);
            this.txtTimeForPingConnectionWithWeb3.Name = "txtTimeForPingConnectionWithWeb3";
            this.txtTimeForPingConnectionWithWeb3.Size = new System.Drawing.Size(217, 23);
            this.txtTimeForPingConnectionWithWeb3.TabIndex = 19;
            // 
            // lblTimeForPingConnectionWithWeb3
            // 
            this.lblTimeForPingConnectionWithWeb3.AutoSize = true;
            this.lblTimeForPingConnectionWithWeb3.Location = new System.Drawing.Point(234, 3);
            this.lblTimeForPingConnectionWithWeb3.Name = "lblTimeForPingConnectionWithWeb3";
            this.lblTimeForPingConnectionWithWeb3.Size = new System.Drawing.Size(206, 15);
            this.lblTimeForPingConnectionWithWeb3.TabIndex = 18;
            this.lblTimeForPingConnectionWithWeb3.Text = "Time For Ping Connection With Web3";
            // 
            // lblTimeForPingConnectionWithInternet
            // 
            this.lblTimeForPingConnectionWithInternet.AutoSize = true;
            this.lblTimeForPingConnectionWithInternet.Location = new System.Drawing.Point(11, 3);
            this.lblTimeForPingConnectionWithInternet.Name = "lblTimeForPingConnectionWithInternet";
            this.lblTimeForPingConnectionWithInternet.Size = new System.Drawing.Size(217, 15);
            this.lblTimeForPingConnectionWithInternet.TabIndex = 17;
            this.lblTimeForPingConnectionWithInternet.Text = "Time For Ping Connection With Internet";
            // 
            // txtTimeForPingConnectionWithInternet
            // 
            this.txtTimeForPingConnectionWithInternet.Location = new System.Drawing.Point(11, 21);
            this.txtTimeForPingConnectionWithInternet.Name = "txtTimeForPingConnectionWithInternet";
            this.txtTimeForPingConnectionWithInternet.Size = new System.Drawing.Size(217, 23);
            this.txtTimeForPingConnectionWithInternet.TabIndex = 16;
            // 
            // pnlMoralisApiKeys
            // 
            this.pnlMoralisApiKeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoralisApiKeys.Location = new System.Drawing.Point(0, 309);
            this.pnlMoralisApiKeys.Name = "pnlMoralisApiKeys";
            this.pnlMoralisApiKeys.Size = new System.Drawing.Size(783, 100);
            this.pnlMoralisApiKeys.TabIndex = 5;
            // 
            // pnlMoralis
            // 
            this.pnlMoralis.Controls.Add(this.cbxChainType);
            this.pnlMoralis.Controls.Add(this.lblChainType);
            this.pnlMoralis.Controls.Add(this.lblKeyName);
            this.pnlMoralis.Controls.Add(this.txtKeyName);
            this.pnlMoralis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoralis.Location = new System.Drawing.Point(0, 251);
            this.pnlMoralis.Name = "pnlMoralis";
            this.pnlMoralis.Size = new System.Drawing.Size(783, 58);
            this.pnlMoralis.TabIndex = 3;
            // 
            // cbxChainType
            // 
            this.cbxChainType.FormattingEnabled = true;
            this.cbxChainType.Location = new System.Drawing.Point(202, 21);
            this.cbxChainType.Name = "cbxChainType";
            this.cbxChainType.Size = new System.Drawing.Size(223, 23);
            this.cbxChainType.TabIndex = 17;
            // 
            // lblChainType
            // 
            this.lblChainType.AutoSize = true;
            this.lblChainType.Location = new System.Drawing.Point(202, 3);
            this.lblChainType.Name = "lblChainType";
            this.lblChainType.Size = new System.Drawing.Size(65, 15);
            this.lblChainType.TabIndex = 16;
            this.lblChainType.Text = "Chain Type";
            // 
            // lblKeyName
            // 
            this.lblKeyName.AutoSize = true;
            this.lblKeyName.Location = new System.Drawing.Point(11, 3);
            this.lblKeyName.Name = "lblKeyName";
            this.lblKeyName.Size = new System.Drawing.Size(61, 15);
            this.lblKeyName.TabIndex = 15;
            this.lblKeyName.Text = "Key Name";
            // 
            // txtKeyName
            // 
            this.txtKeyName.Location = new System.Drawing.Point(11, 21);
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.Size = new System.Drawing.Size(185, 23);
            this.txtKeyName.TabIndex = 14;
            // 
            // pnlTableRoutersForSwaps
            // 
            this.pnlTableRoutersForSwaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableRoutersForSwaps.Location = new System.Drawing.Point(0, 151);
            this.pnlTableRoutersForSwaps.Name = "pnlTableRoutersForSwaps";
            this.pnlTableRoutersForSwaps.Size = new System.Drawing.Size(783, 100);
            this.pnlTableRoutersForSwaps.TabIndex = 4;
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.lblSlippageTolerance);
            this.pnlOperation.Controls.Add(this.txtSlippageTolerance);
            this.pnlOperation.Controls.Add(this.txtTokenDefaultContract);
            this.pnlOperation.Controls.Add(this.lblTokenDefaultContract);
            this.pnlOperation.Controls.Add(this.lblDefaultGas);
            this.pnlOperation.Controls.Add(this.lblDefaultGasPrice);
            this.pnlOperation.Controls.Add(this.txtDefaultGas);
            this.pnlOperation.Controls.Add(this.txtDefaultGasPrice);
            this.pnlOperation.Controls.Add(this.txtContractABI);
            this.pnlOperation.Controls.Add(this.txtContractRouterForSwap);
            this.pnlOperation.Controls.Add(this.lblContractRouterForSwap);
            this.pnlOperation.Controls.Add(this.lblContractABI);
            this.pnlOperation.Controls.Add(this.lblWeb3Url);
            this.pnlOperation.Controls.Add(this.txtWeb3Url);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(783, 151);
            this.pnlOperation.TabIndex = 2;
            // 
            // lblSlippageTolerance
            // 
            this.lblSlippageTolerance.AutoSize = true;
            this.lblSlippageTolerance.Location = new System.Drawing.Point(406, 96);
            this.lblSlippageTolerance.Name = "lblSlippageTolerance";
            this.lblSlippageTolerance.Size = new System.Drawing.Size(105, 15);
            this.lblSlippageTolerance.TabIndex = 13;
            this.lblSlippageTolerance.Text = "Slippage Tolerance";
            // 
            // txtSlippageTolerance
            // 
            this.txtSlippageTolerance.Location = new System.Drawing.Point(406, 114);
            this.txtSlippageTolerance.Name = "txtSlippageTolerance";
            this.txtSlippageTolerance.Size = new System.Drawing.Size(185, 23);
            this.txtSlippageTolerance.TabIndex = 12;
            // 
            // txtTokenDefaultContract
            // 
            this.txtTokenDefaultContract.Location = new System.Drawing.Point(11, 114);
            this.txtTokenDefaultContract.Name = "txtTokenDefaultContract";
            this.txtTokenDefaultContract.Size = new System.Drawing.Size(389, 23);
            this.txtTokenDefaultContract.TabIndex = 11;
            // 
            // lblTokenDefaultContract
            // 
            this.lblTokenDefaultContract.AutoSize = true;
            this.lblTokenDefaultContract.Location = new System.Drawing.Point(11, 96);
            this.lblTokenDefaultContract.Name = "lblTokenDefaultContract";
            this.lblTokenDefaultContract.Size = new System.Drawing.Size(128, 15);
            this.lblTokenDefaultContract.TabIndex = 10;
            this.lblTokenDefaultContract.Text = "Token Default Contract";
            // 
            // lblDefaultGas
            // 
            this.lblDefaultGas.AutoSize = true;
            this.lblDefaultGas.Location = new System.Drawing.Point(597, 52);
            this.lblDefaultGas.Name = "lblDefaultGas";
            this.lblDefaultGas.Size = new System.Drawing.Size(101, 15);
            this.lblDefaultGas.TabIndex = 9;
            this.lblDefaultGas.Text = "Default Gas (MIN)";
            // 
            // lblDefaultGasPrice
            // 
            this.lblDefaultGasPrice.AutoSize = true;
            this.lblDefaultGasPrice.Location = new System.Drawing.Point(406, 52);
            this.lblDefaultGasPrice.Name = "lblDefaultGasPrice";
            this.lblDefaultGasPrice.Size = new System.Drawing.Size(133, 15);
            this.lblDefaultGasPrice.TabIndex = 8;
            this.lblDefaultGasPrice.Text = "Default Gas Price (MAX)";
            // 
            // txtDefaultGas
            // 
            this.txtDefaultGas.Location = new System.Drawing.Point(597, 70);
            this.txtDefaultGas.Name = "txtDefaultGas";
            this.txtDefaultGas.Size = new System.Drawing.Size(173, 23);
            this.txtDefaultGas.TabIndex = 7;
            // 
            // txtDefaultGasPrice
            // 
            this.txtDefaultGasPrice.Location = new System.Drawing.Point(406, 70);
            this.txtDefaultGasPrice.Name = "txtDefaultGasPrice";
            this.txtDefaultGasPrice.Size = new System.Drawing.Size(185, 23);
            this.txtDefaultGasPrice.TabIndex = 6;
            // 
            // txtContractABI
            // 
            this.txtContractABI.Location = new System.Drawing.Point(11, 70);
            this.txtContractABI.Name = "txtContractABI";
            this.txtContractABI.Size = new System.Drawing.Size(389, 23);
            this.txtContractABI.TabIndex = 5;
            // 
            // txtContractRouterForSwap
            // 
            this.txtContractRouterForSwap.Location = new System.Drawing.Point(406, 26);
            this.txtContractRouterForSwap.Name = "txtContractRouterForSwap";
            this.txtContractRouterForSwap.Size = new System.Drawing.Size(364, 23);
            this.txtContractRouterForSwap.TabIndex = 4;
            // 
            // lblContractRouterForSwap
            // 
            this.lblContractRouterForSwap.AutoSize = true;
            this.lblContractRouterForSwap.Location = new System.Drawing.Point(406, 8);
            this.lblContractRouterForSwap.Name = "lblContractRouterForSwap";
            this.lblContractRouterForSwap.Size = new System.Drawing.Size(150, 15);
            this.lblContractRouterForSwap.TabIndex = 3;
            this.lblContractRouterForSwap.Text = "Contract of router for swap";
            // 
            // lblContractABI
            // 
            this.lblContractABI.AutoSize = true;
            this.lblContractABI.Location = new System.Drawing.Point(11, 52);
            this.lblContractABI.Name = "lblContractABI";
            this.lblContractABI.Size = new System.Drawing.Size(71, 15);
            this.lblContractABI.TabIndex = 2;
            this.lblContractABI.Text = "ContractABI";
            // 
            // lblWeb3Url
            // 
            this.lblWeb3Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeb3Url.AutoSize = true;
            this.lblWeb3Url.Location = new System.Drawing.Point(11, 8);
            this.lblWeb3Url.Name = "lblWeb3Url";
            this.lblWeb3Url.Size = new System.Drawing.Size(61, 15);
            this.lblWeb3Url.TabIndex = 0;
            this.lblWeb3Url.Text = "URL Web3";
            // 
            // txtWeb3Url
            // 
            this.txtWeb3Url.Location = new System.Drawing.Point(11, 26);
            this.txtWeb3Url.Name = "txtWeb3Url";
            this.txtWeb3Url.Size = new System.Drawing.Size(389, 23);
            this.txtWeb3Url.TabIndex = 1;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 509);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(783, 35);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(695, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ConfigurationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 441);
            this.Controls.Add(this.pnlGlobal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConfigurationInterface";
            this.Text = "ConfigurationInterface";
            this.pnlGlobal.ResumeLayout(false);
            this.pnlTimes.ResumeLayout(false);
            this.pnlTimes.PerformLayout();
            this.pnlMoralis.ResumeLayout(false);
            this.pnlMoralis.PerformLayout();
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlGlobal;
        private TextBox txtWeb3Url;
        private Label lblWeb3Url;
        private Panel pnlOperation;
        private Panel pnlMoralis;
        private Label lblContractRouterForSwap;
        private Label lblContractABI;
        private TextBox txtContractRouterForSwap;
        private TextBox txtContractABI;
        private Label lblDefaultGas;
        private Label lblDefaultGasPrice;
        private TextBox txtDefaultGas;
        private TextBox txtDefaultGasPrice;
        private TextBox txtTokenDefaultContract;
        private Label lblTokenDefaultContract;
        private Panel pnlTableRoutersForSwaps;
        private Label lblSlippageTolerance;
        private TextBox txtSlippageTolerance;
        private Label lblKeyName;
        private TextBox txtKeyName;
        private Panel pnlMoralisApiKeys;
        private ComboBox cbxChainType;
        private Label lblChainType;
        private Panel pnlTimes;
        private Label lblTimeForPingConnectionWithInternet;
        private TextBox txtTimeForPingConnectionWithInternet;
        private TextBox txtTimeForPingConnectionWithWeb3;
        private Label lblTimeForPingConnectionWithWeb3;
        private TextBox txtTimeBetweenPriceUpdate;
        private Label lblTimeBetweenPriceUpdate;
        private TextBox txtTimeBetweenWalletBalanceUpdate;
        private Label lblTimeBetweenWalletBalanceUpdate;
        private Panel pnlBotoes;
        private Button btnSalvar;
    }
}