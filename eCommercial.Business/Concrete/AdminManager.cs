using eCommercial.Business.Abstract;
using eCommercial.DataAccess.Abstract;
using eCommercial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IUnitOfWork _unitofwork;
        public AdminManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public bool Create(Admin entity)
        {

            _unitofwork.Admins.Create(entity);
            _unitofwork.Save();
            return true;


        }

        public void Delete(Admin entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
