using eCommercial.DataAccess.Abstract;
using eCommercial.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.DataAccess.Concrete.EntityFramework
{
    public class EfAdminRepository:EfGenericRepository<Admin, CommercialContext>, IAdminRepository
    {
        public EfAdminRepository(DbContext context) : base(context)
        {
        }
        private CommercialContext CommercialContext;
    }
}
