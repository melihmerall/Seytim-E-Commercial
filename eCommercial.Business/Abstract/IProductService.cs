using eCommercial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);

        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        List<Product> GetAll();
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        bool Update(Product entity, int[] categoryIds);
    }
}
