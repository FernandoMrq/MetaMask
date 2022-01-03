namespace MRQ.CryptoBot.Domain.Adapter.Data
{
    public interface ISQLiteEntityAdapter<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int Id);
        Task<bool> Insert(T obj);
        Task<bool> Update(T obj);
        Task<bool> Delete(int Id);
    }
}
