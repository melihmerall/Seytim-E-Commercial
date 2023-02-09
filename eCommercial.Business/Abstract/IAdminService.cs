using eCommercial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.Business.Abstract
{
    public interface IAdminService
    {
        List<Product> GetAll();
        bool Create(Admin entity);
        void Update(Admin entity);
        void Delete(Admin entity);
    }
}
