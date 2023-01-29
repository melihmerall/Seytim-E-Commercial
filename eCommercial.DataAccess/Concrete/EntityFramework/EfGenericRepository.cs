using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercial.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eCommercial.DataAccess.Concrete.EntityFramework
{
    public class EfGenericRepository<TEntity,TContext>:IRepository<TEntity>
    where TEntity : class, new()
    where TContext : class, new()
    {
        protected readonly DbContext _context;
        public EfGenericRepository(DbContext context)
        {
            _context = context;
        }
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
