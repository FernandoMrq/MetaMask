namespace MRQ.CryptoBot.Domain.Adapter.PancakeSwap
{
    public static class ConfigurationExtension
    {
        public static int index = 0;

        //TODO pensar em como fazer genérico
        public static string? NextOf(this IList<string> list)
        {
            if (list.Count == 0)
                return default;

            index = (index == list.Count - 1 ? 0 : index + 1);

            return list[index];
        }
    }
}
