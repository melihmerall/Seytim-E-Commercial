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
    public class EfCategoryRepository: EfGenericRepository<Category,CommercialContext>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
        private CommercialContext CommercialContext
        {
            get { return _context as CommercialContext; }
        }
        public Category GetByIdWithProducts(int categoryId)
        {
            return CommercialContext.Categories
                .Where(i => i.CategoryId == categoryId)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Product)
                .FirstOrDefault();
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            var cmd = "delete from productcategory where ProductId=@p0 and CategoryId=@p1";
            CommercialContext.Database.ExecuteSqlRaw(cmd, productId, categoryId);
        }
    }
}
