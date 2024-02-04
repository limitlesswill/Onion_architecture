namespace Onion.Application.Contracts
{
    public interface IRepository<T, TID>
    {
        public IQueryable<T> GetAll();
        public T GetOne(TID primarykey);
        public T Create(T entity);
        public T Update(T entity);
        public bool Delete(T entity);
        public int Save();
    }
}
