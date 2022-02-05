namespace MRQ.CryptoBot.Domains.Adapter.Data
{
    public interface ISQLiteEntityAdapter<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(int Id);
        public Task<bool> Insert(T obj);
        public Task<bool> Update(T obj);
        public Task<bool> Delete(int Id);
    }
}
