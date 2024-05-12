using AccessControl.EF;
using Microsoft.EntityFrameworkCore;

namespace AccessControl.Data
{
    public class GenericRepository<T>   where T : class
    {
        private DemoContext Context;

        public GenericRepository(DemoContext Context)
        {
            this.Context = Context;
        }
        public async Task<T> Add(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            Context.Entry(entity).State = EntityState.Added;
            Context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            var res = Context.Set<T>();
            return res.ToList();
        }

        public T? GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.Entry(entity).State = EntityState.Deleted;
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
            Context.Entry(entity).State = EntityState.Modified;

        }
    }
}