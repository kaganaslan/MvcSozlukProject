using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
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

        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        //public int GetTotalCategoryCount()
        //{
        //    return _categorydal.List().Count;
        //}

        //public int GetYazilimCategoryCount()
        //{
        //    //var category = _categorydal.List().Where(c => c.CategoryName == "Dizi").FirstOrDefault();
        //    //return category != null ? category.Headings.Count : 0;
        //    return _categorydal.List().Count;
        //}

        //public int GetDifferenceBetweenTrueAndFalseCategories()
        //{
        //    var trueCategoryCount = _categorydal.List().Count(c => c.CategoryStatus);
        //    var falseCategoryCount = _categorydal.List().Count(c => !c.CategoryStatus);
        //    return trueCategoryCount - falseCategoryCount;
        //}

        ////public string categoryWithMostHeadings()
        ////{
        ////    var categorywithmostheadingscount = _categorydal.List()
        ////        .OrderByDescending(c => c.Headings?.Count ?? 0)
        ////        .FirstOrDefault();
        ////    return categorywithmostheadingscount?.CategoryName;
        ////}

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.update(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);

        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }


    }
}
