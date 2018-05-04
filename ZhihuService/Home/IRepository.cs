using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZhihuService.Home
{
    public interface IRepository<TEntity> {
        List<TEntity> GetAll();
        TEntity Get(Int32 id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity id);
    }
}
