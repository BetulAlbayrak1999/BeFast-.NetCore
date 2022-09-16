using DataAccess.Abstract.Common;
using DataAccess.Abstract.Interfaces;
using DataAccess.Concrete.Common;
using DataAccess.Data.Contexts;
using Entity.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories.EFRepositories
{
    public class CompanyPaymentRepository : BaseRepository<CompanyPayment>, ICompanyPaymentRepository
    {
        private readonly ApplicationDbContext _context;
        public CompanyPaymentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
