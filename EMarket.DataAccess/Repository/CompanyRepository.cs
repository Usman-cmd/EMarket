using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMarket.DataAccess.Data;
using EMarket.DataAccess.Repository.IRepository;
using EMarket.Models;

namespace EMarket.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {

        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}

