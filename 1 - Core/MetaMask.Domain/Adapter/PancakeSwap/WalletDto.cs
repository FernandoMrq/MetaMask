namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    //contractAdress, web3Url, contractAbi, adressOfWallet 
    public class WalletDto
    {
        public string? Adress { get; set; }
        public string? PrivateKey { get; set; } //TODO adicionar camadas de segurança
        //TODO adicionar --> public IEnumerable<TokenDto>? Tokens { get; set; } <----- ??????
    }
}
