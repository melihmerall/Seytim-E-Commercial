using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercial.DataAccess.Abstract;
using eCommercial.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace eCommercial.DataAccess.Concrete.EntityFramework
{
    public class EfOrderRepository:EfGenericRepository<Order,CommercialContext>, IOrderRepository
    {
        public EfOrderRepository(DbContext context) : base(context)
        {
        }
        private CommercialContext CommercialContext
        {
            get { return _context as CommercialContext; }
        }
        public List<Order> GetOrders(string userId)
        {
            var orders = CommercialContext.Orders
                .Include(i => i.OrderItems)
                .ThenInclude(i => i.Product)
                .AsQueryable();

            if (!string.IsNullOrEmpty(userId))
            {
                orders = orders.Where(i => i.UserId == userId);
            }

            return orders.ToList();
        }
    }
}
