using DataAccess.Abstract.Common;
using DataAccess.Abstract.Interfaces;
using DataAccess.Concrete.Common;
using Entity.Domains;
using System;
using System.Collections.Generic;
using DataAccess.Data.Contexts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories.EFRepositories
{
    public class OrderStatusHistoryRepository : BaseRepository<OrderStatusHistory>, IOrderStatusHistoryRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderStatusHistoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
