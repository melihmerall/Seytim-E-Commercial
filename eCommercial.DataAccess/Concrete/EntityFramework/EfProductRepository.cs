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
    public class EfProductRepository : EfGenericRepository<Product,CommercialContext>, IProductRepository
    {
        public EfProductRepository(DbContext context) : base(context)
        {
        }
        private CommercialContext CommercialContext
        {
            get { return _context as CommercialContext; }
        }
        public Product GetByIdWithCategories(int id)
        {
            return CommercialContext.Products
                            .Where(i => i.Id == id)
                            .Include(i => i.ProductCategories)
                            .ThenInclude(i => i.Category)
                            .FirstOrDefault();
        }

        public int GetCountByCategory(string category)
        {

            var products = CommercialContext.Products.Where(i => i.IsApproved).AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products
                                .Include(i => i.ProductCategories)
                                .ThenInclude(i => i.Category)
                                .Where(i => i.ProductCategories.Any(a => a.Category.Url == category));
            }

            return products.Count();

        }
        public List<Product> GetHomePageProducts()
        {
            return CommercialContext.Products
                .Where(i => i.IsApproved && i.IsHome).ToList();
        }
        public Product GetProductDetails(string url)
        {
            return CommercialContext.Products
                            .Where(i => i.Url == url)
                            .Include(i => i.ProductCategories)
                            .ThenInclude(i => i.Category)
                            .FirstOrDefault();

        }
        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            var products = CommercialContext
                .Products
                .Where(i => i.IsApproved)
                .AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                products = products
                                .Include(i => i.ProductCategories)
                                .ThenInclude(i => i.Category)
                                .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));
            }

            return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
        public List<Product> GetSearchResult(string searchString)
        {
            var products = CommercialContext
                .Products
                .Where(i => i.IsApproved && (i.Name.ToLower().Contains(searchString.ToLower()) || i.Description.ToLower().Contains(searchString.ToLower())))
                .AsQueryable();

            return products.ToList();
        }

        public void Update(Product entity, int[] categoryIds)
        {
            var product = CommercialContext.Products
                                .Include(i => i.ProductCategories)
                                .FirstOrDefault(i => i.Id == entity.Id);


            if (product != null)
            {
                product.Name = entity.Name;
                product.Price = entity.Price;
                product.Description = entity.Description;
                product.Url = entity.Url;
                product.ImageUrl = entity.ImageUrl;
                product.IsApproved = entity.IsApproved;
                product.IsHome = entity.IsHome;

                product.ProductCategories = categoryIds.Select(catid => new ProductCategory()
                {
                    ProductId = entity.Id,
                    CategoryId = catid
                }).ToList();

            }
        }
    }
}
