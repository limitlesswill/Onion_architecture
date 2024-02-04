using Microsoft.EntityFrameworkCore;
using Onion.Application.Contracts;
using Onion.Infrastructure.Context;

namespace Onion.Infrastructure.Repositories
{
    public class Repository<T, TID> : IRepository<T, TID> where T : class
    {
        private OnionContext onioncontext;
        private DbSet<T> dbset;
        public Repository(OnionContext _onioncontext)
        {
            this.onioncontext = _onioncontext;
            dbset = onioncontext.Set<T>();
        }
        public T Create(T entity)
        {
            return dbset.Add(entity).Entity;
        }

        public bool Delete(T entity)
        {
            return dbset.Remove(entity) != null;
        }

        public IQueryable<T> GetAll()
        {
            return dbset;
        }

        public T GetOne(TID primarykey)
        {
            return dbset.Find(primarykey);
        }

        public T Update(T entity)
        {
            return dbset.Update(entity).Entity;
        }
        public int Save()
        {
            return onioncontext.SaveChanges();
        }
    }
}
