using ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.IDatabase;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CategoryTreeController : ApiController
    {
        ICategoryTreeRepository categoryTreeRepository;   
        
        CategoryTree GetCategoryTree()
        {
            var categoryTree = categoryTreeRepository.GetCategoryTree();
            return categoryTree;
        }
        #region Category
        void AddCategory(Category category)
        {
            categoryTreeRepository.AddCategory(category);
        }
        void UpdateCategory(int idCategory, string nameCategory)
        {
            categoryTreeRepository.UpdateCategory(idCategory, nameCategory);
        }
        void ChangeCategoryPosition(int idCategory, int idNewParentCategory)
        {
            categoryTreeRepository.ChangeCategoryPosition(idCategory, idNewParentCategory);
        }
        void DeleteCategory(int idCategory)
        {
            categoryTreeRepository.DeleteCategory(idCategory);
        }
        #endregion

        #region Item
        void AddItem(Item item)
        {
            categoryTreeRepository.AddItem(item);
        }
        void UpdateItem(int idItem, string nameItem)
        {
            categoryTreeRepository.UpdateItem(idItem, nameItem);
        }
        void ChangeItemPosition(int idItem, int idNewParentCategory)
        {
            categoryTreeRepository.ChangeItemPosition(idItem, idNewParentCategory);
        }
        void DeleteItem(int idItem)
        {
            categoryTreeRepository.DeleteItem(idItem);
        }
        #endregion
    }
}
