using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoyDal;

        public CategoryManager(ICategoryDal categoyDal)
        {
            _categoyDal = categoyDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoyDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoyDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoyDal.Update(category);
        }

        public Category GetById(int id)
        {
           return _categoyDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoyDal.GetListAll();

        }
    }
}
