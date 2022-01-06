using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace MRQ.CryptoBot.Integration.Nethereum
{
    [Function("swapExactTokensForTokens", "uint256[]")]
    public class SwapExactTokensForTokensBase : FunctionMessage
    {
        [Parameter("uint256", "amountIn", 1)]
        public virtual BigInteger AmountIn { get; set; }
        [Parameter("uint256", "amountOutMin", 2)]
        public virtual BigInteger AmountOutMin { get; set; }
        [Parameter("address[]", "path", 3)]
        public virtual List<string>? Path { get; set; }
        [Parameter("address", "to", 4)]
        public virtual string? To { get; set; }
        [Parameter("uint256", "deadline", 5)]
        public virtual BigInteger Deadline { get; set; }
    }
}
