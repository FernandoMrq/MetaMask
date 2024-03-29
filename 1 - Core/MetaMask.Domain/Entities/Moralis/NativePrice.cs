﻿namespace MRQ.CryptoBot.Domains.Entities.Moralis
{
    public class NativePrice
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int? Decimals { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public Balance Balance { get; set; }
    }
}
