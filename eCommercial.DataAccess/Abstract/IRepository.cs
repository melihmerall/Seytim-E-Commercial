using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.DataAccess.Abstract
{
    public interface IRepository<T> where T : class,new()
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}
