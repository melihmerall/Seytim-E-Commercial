using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercial.Business.Abstract;
using eCommercial.DataAccess.Abstract;
using eCommercial.Entities.Concrete;

namespace eCommercial.Business.Concrete
{
    public class CategoryManager: ICategoryService
    {
        private readonly IUnitOfWork _unitofwork;
        public CategoryManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public string ErrorMessage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Create(Category entity)
        {
            _unitofwork.Categories.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(Category entity)
        {
            _unitofwork.Categories.Delete(entity);
            _unitofwork.Save();
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            _unitofwork.Categories.DeleteFromCategory(productId, categoryId);
        }

        public List<Category> GetAll()
        {
            return _unitofwork.Categories.GetAll();
        }

        public Category GetById(int id)
        {
            return _unitofwork.Categories.GetById(id);
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            return _unitofwork.Categories.GetByIdWithProducts(categoryId);
        }

        public void Update(Category entity)
        {
            _unitofwork.Categories.Update(entity);
            _unitofwork.Save();
        }

        public bool Validation(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
