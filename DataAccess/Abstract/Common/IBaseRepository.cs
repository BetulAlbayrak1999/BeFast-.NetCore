using Entity.Domains.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Common
{
    public interface IBaseRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);

        Task<bool> AddRangeAsync(IEnumerable<T> entities);


        bool Update(T entity);

        bool Remove(T entity);

        bool RemoveRange(IEnumerable<T> entities);


        public Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true);


        Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, bool tracking = true);


        Task<IEnumerable<T>> GetAllWithIncludeAsync(Expression<Func<T, bool>> expression = null, bool tracking = true, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);

        Task<bool> SaveChangeAsync();

        public Task<T> GetSingleWithIncludeAsync(Expression<Func<T, bool>> expression, bool tracking = true, params Expression<Func<T, object>>[] includes);

    }
}
