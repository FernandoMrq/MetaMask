﻿namespace MRQ.CryptoBot.Domain.Adapter.Moralis
{
    public class Balance
    {
        public NativePrice? NativePrice { get; set; }
        public Decimal UsdPrice { get; set; }
        public string? ExchangeAddress { get; set; }
        public string? ExchangeName { get; set; }
    }
}
