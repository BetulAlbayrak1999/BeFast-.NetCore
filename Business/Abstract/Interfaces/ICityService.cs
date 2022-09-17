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
        Task<bool> AddAsync(CreateCityDto createCityDto);
        Task<bool> AddRangeAsync(List<CreateCityDto> createCityDtos);
        Task<bool> UpdateAsync(UpdateCityDto updateCityDto);
        Task<bool> RemoveAsync(Guid id);
        List<GetCityDto> GetAll(Func<IQueryable<City>, IOrderedQueryable<City>> orderBy = null, bool checkstatus = false, bool tracking = true);
        Task<GetCityDto> GetSingleAsync(Expression<Func<City, bool>> expression, bool checkstatus = false, bool tracking = true);

        Task<List<GetCityDto>> GetAllWithInclude(Expression<Func<City, bool>> predicate, bool checkstatus = false, bool tracking = true, Func<IQueryable<City>, IOrderedQueryable<City>> orderBy = null, params Expression<Func<City, object>>[] includes);

        Task<GetCityDto> GetSingleWtihInclude(Expression<Func<City, bool>> predicate, bool checkstatus = false, bool tracking = true, params Expression<Func<City, object>>[] includes);

    }
}
