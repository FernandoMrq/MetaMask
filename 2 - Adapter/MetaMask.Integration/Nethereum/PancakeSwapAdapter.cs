using MRQ.CryptoBot.Domain.Adapter.PancakeSwap;
using MRQ.ReturnContent;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Util;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System.Numerics;

namespace MRQ.CryptoBot.Integration.Nethereum
{
    public class PancakeSwapAdapter : IBlockChainOperationAdapter
    {
        private readonly Returned _returned;
        //TODO Clean the code

        public PancakeSwapAdapter()
        {
            //TODO make the configuration from the form
            ConfigurationDto.Web3Url = @"https://bsc-dataseed.binance.org";
            ConfigurationDto.ContractABI = @"[{""inputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""constructor""},{""anonymous"":false,""inputs"":[{""indexed"":true,""internalType"":""address"",""name"":""owner"",""type"":""address""},{""indexed"":true,""internalType"":""address"",""name"":""spender"",""type"":""address""},{""indexed"":false,""internalType"":""uint256"",""name"":""value"",""type"":""uint256""}],""name"":""Approval"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""internalType"":""address"",""name"":""sender"",""type"":""address""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount0"",""type"":""uint256""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount1"",""type"":""uint256""},{""indexed"":true,""internalType"":""address"",""name"":""to"",""type"":""address""}],""name"":""Burn"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""internalType"":""address"",""name"":""sender"",""type"":""address""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount0"",""type"":""uint256""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount1"",""type"":""uint256""}],""name"":""Mint"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""internalType"":""address"",""name"":""sender"",""type"":""address""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount0In"",""type"":""uint256""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount1In"",""type"":""uint256""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount0Out"",""type"":""uint256""},{""indexed"":false,""internalType"":""uint256"",""name"":""amount1Out"",""type"":""uint256""},{""indexed"":true,""internalType"":""address"",""name"":""to"",""type"":""address""}],""name"":""Swap"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":false,""internalType"":""uint112"",""name"":""reserve0"",""type"":""uint112""},{""indexed"":false,""internalType"":""uint112"",""name"":""reserve1"",""type"":""uint112""}],""name"":""Sync"",""type"":""event""},{""anonymous"":false,""inputs"":[{""indexed"":true,""internalType"":""address"",""name"":""from"",""type"":""address""},{""indexed"":true,""internalType"":""address"",""name"":""to"",""type"":""address""},{""indexed"":false,""internalType"":""uint256"",""name"":""value"",""type"":""uint256""}],""name"":""Transfer"",""type"":""event""},{""constant"":true,""inputs"":[],""name"":""DOMAIN_SEPARATOR"",""outputs"":[{""internalType"":""bytes32"",""name"":"""",""type"":""bytes32""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""MINIMUM_LIQUIDITY"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""PERMIT_TYPEHASH"",""outputs"":[{""internalType"":""bytes32"",""name"":"""",""type"":""bytes32""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[{""internalType"":""address"",""name"":"""",""type"":""address""},{""internalType"":""address"",""name"":"""",""type"":""address""}],""name"":""allowance"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""spender"",""type"":""address""},{""internalType"":""uint256"",""name"":""value"",""type"":""uint256""}],""name"":""approve"",""outputs"":[{""internalType"":""bool"",""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[{""internalType"":""address"",""name"":"""",""type"":""address""}],""name"":""balanceOf"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""to"",""type"":""address""}],""name"":""burn"",""outputs"":[{""internalType"":""uint256"",""name"":""amount0"",""type"":""uint256""},{""internalType"":""uint256"",""name"":""amount1"",""type"":""uint256""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""decimals"",""outputs"":[{""internalType"":""uint8"",""name"":"""",""type"":""uint8""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""factory"",""outputs"":[{""internalType"":""address"",""name"":"""",""type"":""address""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""getReserves"",""outputs"":[{""internalType"":""uint112"",""name"":""_reserve0"",""type"":""uint112""},{""internalType"":""uint112"",""name"":""_reserve1"",""type"":""uint112""},{""internalType"":""uint32"",""name"":""_blockTimestampLast"",""type"":""uint32""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""_token0"",""type"":""address""},{""internalType"":""address"",""name"":""_token1"",""type"":""address""}],""name"":""initialize"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""kLast"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""to"",""type"":""address""}],""name"":""mint"",""outputs"":[{""internalType"":""uint256"",""name"":""liquidity"",""type"":""uint256""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""name"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[{""internalType"":""address"",""name"":"""",""type"":""address""}],""name"":""nonces"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""owner"",""type"":""address""},{""internalType"":""address"",""name"":""spender"",""type"":""address""},{""internalType"":""uint256"",""name"":""value"",""type"":""uint256""},{""internalType"":""uint256"",""name"":""deadline"",""type"":""uint256""},{""internalType"":""uint8"",""name"":""v"",""type"":""uint8""},{""internalType"":""bytes32"",""name"":""r"",""type"":""bytes32""},{""internalType"":""bytes32"",""name"":""s"",""type"":""bytes32""}],""name"":""permit"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""price0CumulativeLast"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""price1CumulativeLast"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""to"",""type"":""address""}],""name"":""skim"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""uint256"",""name"":""amount0Out"",""type"":""uint256""},{""internalType"":""uint256"",""name"":""amount1Out"",""type"":""uint256""},{""internalType"":""address"",""name"":""to"",""type"":""address""},{""internalType"":""bytes"",""name"":""data"",""type"":""bytes""}],""name"":""swap"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""symbol"",""outputs"":[{""internalType"":""string"",""name"":"""",""type"":""string""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[],""name"":""sync"",""outputs"":[],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""token0"",""outputs"":[{""internalType"":""address"",""name"":"""",""type"":""address""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""token1"",""outputs"":[{""internalType"":""address"",""name"":"""",""type"":""address""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":true,""inputs"":[],""name"":""totalSupply"",""outputs"":[{""internalType"":""uint256"",""name"":"""",""type"":""uint256""}],""payable"":false,""stateMutability"":""view"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""to"",""type"":""address""},{""internalType"":""uint256"",""name"":""value"",""type"":""uint256""}],""name"":""transfer"",""outputs"":[{""internalType"":""bool"",""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""},{""constant"":false,""inputs"":[{""internalType"":""address"",""name"":""from"",""type"":""address""},{""internalType"":""address"",""name"":""to"",""type"":""address""},{""internalType"":""uint256"",""name"":""value"",""type"":""uint256""}],""name"":""transferFrom"",""outputs"":[{""internalType"":""bool"",""name"":"""",""type"":""bool""}],""payable"":false,""stateMutability"":""nonpayable"",""type"":""function""}]";
            ConfigurationDto.RouterForSwap = "0x10ED43C718714eb63d5aA57B78B54704E256024E";
            ConfigurationDto.ToakenDefaultCOntract = "0xbb4CdB9CBd36B01bD1cBaEBF2De08d9173bc095c";
            ConfigurationDto.SlippageTolerance = 0.90M; //10%
            ConfigurationDto.GasPrice = 5000000000;
            ConfigurationDto.Gas = 290000;

            _returned = ReturnedExtension.CreateReturned();
        }

        //contractAdress, web3Url, contractAbi, adressOfWallet 
        public async Task GetWalletBalanceOfTokenAsync(WalletDto walletDto, TokenDto tokenDto)
        {
            _returned.InsertLogMessage("PancakeSwapAdapter - Inicio GetTokenBalance");

            var web3 = new Web3(ConfigurationDto.Web3Url);

            try
            {
                var contract = web3.Eth.GetContract(ConfigurationDto.ContractABI, tokenDto.Adress);
                var balanceFunctionFromAbi = contract.GetFunction("balanceOf");
                var nameFunctionFromAbi = await contract.GetFunction("name").CallAsync<string>();
                var balance = await balanceFunctionFromAbi.CallAsync<BigInteger>(walletDto.Adress);

                tokenDto.BalanceWei = decimal.Parse(balance.ToString());
                tokenDto.Balance = Web3.Convert.FromWei(balance);
                tokenDto.Name = nameFunctionFromAbi;
            }
            catch (Exception ex)
            {
                _returned.InsertLogMessage(string.Format("**PancakeSwapAdapter** Error: ", ex.Message), true);
            }

            _returned.InsertLogMessage("PancakeSwapAdapter - Fim GetTokenBalance");
        }

        public async Task<Returned> SwapTokensAsync(WalletDto walletDto, TokenDto tokenOrigin, TokenDto tokenDestination)
        {
            _returned.InsertLogMessage("PancakeSwapAdapter - Inicio Swap");
            try
            { 
                var url = ConfigurationDto.Web3Url;
                var myWallet = walletDto.Adress;
                var privateKey = walletDto.PrivateKey;
                var contractAddress = ConfigurationDto.RouterForSwap;

                var account = new Account(privateKey, 56);
                var web3 = new Web3(account, url);
                var transactionManager = web3.TransactionManager;

                var swapHandler = web3.Eth.GetContractTransactionHandler<SwapExactTokensForTokens>();

                var camtidadBUSD = Web3.Convert.ToWei(tokenDestination.Balance);
                var camtidadToken = Web3.Convert.ToWei(tokenDestination.Balance * ConfigurationDto.SlippageTolerance);

                //string tokens = "";


                //tokens = string.Concat(tokens,",", ConfigurationDto.ToakenDefaultCOntract);

                //tokens = string.Concat(tokenOrigin.Adress.ToLower());

                //if (tokenOrigin.Adress.ToLower() != ConfigurationDto.ToakenDefaultCOntract.ToLower())
                //    tokens = string.Concat(tokens, ",", ConfigurationDto.ToakenDefaultCOntract);

                //if (tokenDestination.Adress.ToLower() != ConfigurationDto.ToakenDefaultCOntract.ToLower())
                //    tokens = string.Concat(tokens, ",", tokenDestination.Adress.ToLower());

                var swapDTO = new SwapExactTokensForTokens()
                {
                    AmountIn = camtidadBUSD,
                    AmountOutMin = camtidadToken, //MINIMO DE TOKENS A RECIBIR
                    Path = new List<string>
                {
                    //tokens
                    tokenOrigin.Adress, //CONTRATO ORIGEM
                    //ConfigurationDto.ToakenDefaultCOntract, //CONTRATO DEFAULT
                    tokenDestination.Adress //CONTRATO DESTINO
                },
                    To = myWallet,
                    Deadline = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds() + 260,
                    GasPrice = ConfigurationDto.GasPrice,
                    Gas = ConfigurationDto.Gas
                };

                //TODO observar o artigo https://fenixbb.com/bot-de-trading-para-binance-smart-chain-bsc-usando-c-parte-2/ e colocar as demais formas de fazer o swap, inclusive as que precisam de taxa.

                _returned.InsertLogMessage("PancakeSwapAdapter - Manda Requisição BlockChain");
                var transactionSwapReceipt = await swapHandler.SendRequestAndWaitForReceiptAsync(contractAddress, swapDTO);
                _returned.InsertLogMessage("PancakeSwapAdapter - Fim Requisição BlockChain");

                _returned.InsertLogMessage(String.Format("PancakeSwapAdapter - Transaction hash: {0}", transactionSwapReceipt.TransactionHash), true);
                //TODO criar objeto para operação, contendo hash da operação e outros detalhes da mesma

                _returned.AlterReturnedState(State.OK);

                //TODO preencher returned
            }
            catch (Exception ex)
            {
                _returned.InsertLogMessage(string.Format("**PancakeSwapAdapter** Error: ", ex.Message), true);

            }

            _returned.InsertLogMessage("PancakeSwapAdapter - Fim Swap");
            return _returned;
        }

        public async Task<Returned> SendToWalletAsync(WalletDto walletOrigem, WalletDto walletDestino, TokenDto tokenOrigem)
        {
            _returned.InsertLogMessage("PancakeSwapAdapter - Inicio SentToWallet");
            try
            {
                var privateKey = walletOrigem.PrivateKey;
                var account = new Account(privateKey, 56);
                var camtidadBNB = Web3.Convert.ToWei(tokenOrigem.Balance);
                string hexBNB = camtidadBNB.ToString("X2"); //TODO verificar o que é isso

                //Console.WriteLine("Our account: " + account.Address);

                var web3 = new Web3(account, "https://bsc-dataseed.binance.org/");

                var toAddress = walletDestino.Adress;//DIRECCION QUE VA A RECIBIR
                var transactionManager = web3.TransactionManager;

                var txnInput = new TransactionInput()//PRIMERA TRANSACCION PARA ESTIMAR EL GAS
                {
                    From = account.Address,
                    To = toAddress,
                    Value = new HexBigInteger(hexBNB),
                };

                var gasEstimate = await transactionManager.EstimateGasAsync(txnInput);
                //Console.WriteLine("gas estimado " + gasEstimate.Value);
                txnInput.Gas = gasEstimate;

                string hexGas = gasEstimate.Value.ToString("X2");

                var txnInput2 = new TransactionInput() //SEGUNDA TRANSACCION, LA DEFINITIVA
                {
                    From = account.Address,
                    To = toAddress,
                    Gas = new HexBigInteger(hexGas),
                    Value = new HexBigInteger(hexBNB),
                };

                var gasPrice = await web3.Eth.GasPrice.SendRequestAsync();

                txnInput2.GasPrice = new HexBigInteger(gasPrice.Value + Web3.Convert.ToWei(1, UnitConversion.EthUnit.Gwei));

                var txnHash2 = await transactionManager.SendTransactionAsync(txnInput2);

                _returned.InsertLogMessage(String.Concat("PancakeSwapAdapter - Hash: ", txnHash2));
            }
            catch (Exception ex)
            {
                _returned.InsertLogMessage(string.Format("**PancakeSwapAdapter** Error: ", ex.Message), true);

            }

            _returned.InsertLogMessage("PancakeSwapAdapter - Fim SentToWallet");
            return _returned;
        }
    }
}
