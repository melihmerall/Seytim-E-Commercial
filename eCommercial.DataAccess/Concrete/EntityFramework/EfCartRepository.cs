using eCommercial.DataAccess.Abstract;
using eCommercial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eCommercial.DataAccess.Concrete.EntityFramework
{
    public  class EfCartRepository: EfGenericRepository<Cart,CommercialContext>, ICartRepository

    {
        public EfCartRepository(DbContext context) : base(context)
        {
        }

        private CommercialContext CommercialContext
        {
            get {return _context as CommercialContext;}
        }
        public Cart GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromCart(int cartId, int productId)
        {
            throw new NotImplementedException();
        }

        public void ClearCart(int cartId)
        {
            var cmd = @"delete from CartItems where CartId=@p0";
            CommercialContext.Database.ExecuteSqlRaw(cmd, cartId);
        }
    }
}
