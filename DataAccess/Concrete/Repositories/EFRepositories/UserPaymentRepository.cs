﻿using DataAccess.Abstract.Common;
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
    public class UserPaymentRepository : BaseRepository<UserPayment>, IUserPaymentRepository
    {
        private readonly ApplicationDbContext _context;
        public UserPaymentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
