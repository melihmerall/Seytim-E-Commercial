using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercial.Entities.Concrete;

namespace eCommercial.DataAccess.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category GetByIdWithProducts(int categoryId);

        void DeleteFromCategory(int productId, int categoryId);
    }
}
