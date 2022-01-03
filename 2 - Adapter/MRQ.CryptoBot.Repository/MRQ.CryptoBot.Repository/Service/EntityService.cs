using Microsoft.EntityFrameworkCore;
using MRQ.CryptoBot.Domain.Adapter.Data;

namespace MRQ.CryptoBot.Repository.Service
{
    public class EntityService<T> : ISQLiteEntityAdapter<T> where T : class
    {
        //TODO colocar internalizador de exception {todos os métodos}
        //TODO colocar simplificador de método para teste do context {todos os métodos}
        protected SQLiteContext? context;

        public EntityService(SQLiteContext context)
        {
            this.context = context;
        }

        public async Task<bool> Delete(int Id)
        {
            if (context != null)
            {
                var entity = await GetById(Id);
                if (entity != null)
                {
                    context.Set<T>().Remove(entity);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            if (context != null)
                return await context.Set<T>().AsNoTracking().ToListAsync();
            return Enumerable.Empty<T>();
        }

        public async Task<T> GetById(int Id)
        {
            //TODO resolver esse warning
            return await context.Set<T>().FindAsync(Id);

        }

        public async Task<bool> Insert(T obj)
        {
            if (context != null) {
                await context.Set<T>().AddAsync(obj);
                await context.SaveChangesAsync();
            }

            return true;
        }

        public async Task<bool> Update(T obj)
        {
            if (context != null)
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
            }

            return true;
        }

    }
}
