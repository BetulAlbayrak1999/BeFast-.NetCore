using DataAccess.Abstract.Common;
using DataAccess.Data.Contexts;
using Entity.Domains.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Field and Constructor

        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _object;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _object = _context.Set<T>();
        }
        #endregion
        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                EntityEntry<T> entityEntry = await _object.AddAsync(entity);
                return entityEntry.State == EntityState.Added;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await _object.AddRangeAsync(entities);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Remove(T entity)
        {
            try
            {
                EntityEntry<T> entityEntry = _object.Remove(entity);
                return entityEntry.State == EntityState.Deleted;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                _object.RemoveRange(entities);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, bool tracking = true)
        {
            try
            {
                var query = _object.AsNoTracking();

                if (orderBy != null)
                {
                    query = orderBy(query);
                }
                if (!tracking)
                    query = query.AsNoTracking();
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<T>> GetAllWithIncludeAsync(Expression<Func<T, bool>> expression = null, bool tracking = true, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {
            try
            {
                IQueryable<T> query = _object;

                if (expression != null)
                {
                    query = query.Where(expression);
                }

                foreach (Expression<Func<T, object>> include in includes)
                {
                    query = query.Include(include);
                }

                if (orderBy != null)
                {
                    query = orderBy(query);
                }

                if (!tracking)
                    query = query.AsNoTracking();
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression = null, bool tracking = true)
        {
            try
            {
                var query = _object.AsQueryable();

                if (expression != null)
                    query = query.Where(expression);


                if (!tracking)
                    query = query.AsNoTracking();

                var value =  query.FirstOrDefaultAsync(expression);

                if (value != null)
                    return await value;
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<T> GetSingleWithIncludeAsync(Expression<Func<T, bool>> expression, bool tracking = true, params Expression<Func<T, object>>[] includes)
        {
            try
            {
                var query =  _object.AsQueryable();

                if (expression != null)
                    query = query.Where(expression);

                query = ApplyIncludes(query, includes);

                if (!tracking)
                    query = query.AsNoTracking();

                var value = query.FirstOrDefaultAsync();

                if (value != null)
                    return await value;
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> SaveChangeAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                EntityEntry<T> entityEntry = _object.Update(entity);
                return entityEntry.State == EntityState.Modified;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static IQueryable<T> ApplyIncludes(IQueryable<T> query, params Expression<Func<T, object>>[] includes)
        {
            if (includes != null)
            {
                foreach (var includeItem in includes)
                {
                    query = query.Include(includeItem);
                }
            }
            return query;
        }

        public IQueryable<T> AsQueryable()
        {
            return _object.AsQueryable();
        }

    }
}

