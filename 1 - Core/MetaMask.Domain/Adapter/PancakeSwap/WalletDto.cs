namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    //contractAdress, web3Url, contractAbi, adressOfWallet 
    public class WalletDto
    {
        public string? Adress { get; set; }
        public IEnumerable<TokenDto>? Tokens { get; set; }
    }
}
