using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZhihuService.Home
{
    public abstract class Repository<TEntity> : DbContext, IRepository<TEntity> where TEntity : class {
        private DbContext _dbContext;

        public Repository(DbContext dbContext) {
            _dbContext = dbContext;
        }

        public virtual List<TEntity> GetAll() {
            var result = _dbContext.Set<TEntity>().ToList();
            return result;
        }

        public virtual TEntity Get(Int32 id) {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public virtual void Add(TEntity entity) {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual void Update(TEntity entity) {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public virtual void Delete(TEntity entity) {
            _dbContext.Set<TEntity>().Remove(entity);
        }        
    }
}
