using ModelDB.ModelDB;
using System;
using System.Web.Http;
using WebApi.IDatabase;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            if(categoryRepository!=null)
            _categoryRepository = categoryRepository;
            else
            {
                throw new Exception();
            }
        }

        CategoryTree GetCategoryTree()
        {
            var categoryTree = _categoryRepository.GetCategoryTree();
            return categoryTree;
        }
        void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
        void UpdateCategory(int idCategory, string nameCategory)
        {
            _categoryRepository.UpdateCategory(idCategory, nameCategory);
        }
        void ChangeCategoryPosition(int idCategory, int idNewParentCategory)
        {
            _categoryRepository.ChangeCategoryPosition(idCategory, idNewParentCategory);
        }
        void DeleteCategory(int idCategory)
        {
            _categoryRepository.DeleteCategory(idCategory);
        }
    }
}
