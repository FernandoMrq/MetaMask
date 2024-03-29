﻿namespace MRQ.CryptoBot.Domains.Application.Configurations
{
    public class RoutersForSwapDto
    {
        public int Id { get; set; }
        public int ConfigurationId { get; set; }
        public int Priority { get; set; }
        public IList<RouterDto>? Router { get; set; }
    }
}