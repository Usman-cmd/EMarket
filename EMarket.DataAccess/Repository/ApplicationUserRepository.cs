using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EMarket.DataAccess.Data;
using EMarket.DataAccess.Repository.IRepository;
using EMarket.Models;

namespace EMarket.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
    }
}
