﻿using DataAccess.Abstract.Common;
using DataAccess.Abstract.Interfaces;
using DataAccess.Concrete.Common;
using Entity.Domains;
using DataAccess.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories.EFRepositories
{
    public class FineRepository : BaseRepository<Fine>, IFineRepository
    {
        private readonly ApplicationDbContext _context;
        public FineRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
