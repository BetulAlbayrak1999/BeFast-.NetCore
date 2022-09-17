using Business.Dtos;
using DataAccess.Abstract.Common;
using Entity.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Interfaces
{
    public interface ICityService 
    {
        Task<bool> AddAsync(CityDto cityDto);
        Task<bool> AddRangeAsync(List<CityDto> cityDtos);
        Task<bool> UpdateAsync(CityDto cityDto);
        Task<bool> RemoveAsync(int id);
        List<CityDto> GetAll(Func<IQueryable<City>, IOrderedQueryable<City>> orderBy = null, bool checkstatus = false, bool tracking = true);
        Task<CityDto> GetSingleAsync(Expression<Func<City, bool>> expression, bool checkstatus = false, bool tracking = true);

        Task<List<CityDto>> GetAllWithIncludeAsync(Expression<Func<City, bool>> predicate, bool checkstatus = false, bool tracking = true, Func<IQueryable<City>, IOrderedQueryable<City>> orderBy = null, params Expression<Func<City, object>>[] includes);

        Task<CityDto> GetSingleWtihIncludeAsync(Expression<Func<City, bool>> predicate, bool checkstatus = false, bool tracking = true, params Expression<Func<City, object>>[] includes);

    }
}
