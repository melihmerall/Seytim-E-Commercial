using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercial.DataAccess.Abstract;

namespace eCommercial.DataAccess.Concrete.EntityFramework
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly CommercialContext _context;
        public UnitOfWork(CommercialContext context)
        {
            _context = context;
        }

        private EfCartRepository _cartRepository;
        private EfCategoryRepository _categoryRepository;
        private EfOrderRepository _orderRepository;
        private EfProductRepository _productRepository;

        public ICartRepository Carts =>
            _cartRepository = _cartRepository ?? new EfCartRepository(_context);

        public ICategoryRepository Categories =>
            _categoryRepository = _categoryRepository ?? new EfCategoryRepository(_context);

        public IOrderRepository Orders =>
            _orderRepository = _orderRepository ?? new EfOrderRepository(_context);

        public IProductRepository Products =>
            _productRepository = _productRepository ?? new EfProductRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
