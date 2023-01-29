using eCommercial.DataAccess.Abstract;
using eCommercial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercial.Business.Abstract;

namespace eCommercial.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IUnitOfWork _unitofwork;
        public OrderManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public void Create(Order entity)
        {
            _unitofwork.Orders.Create(entity);
            _unitofwork.Save();
        }

        public List<Order> GetOrders(string userId)
        {
            return _unitofwork.Orders.GetOrders(userId);
        }
    }
}
