using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ModelDB.ModelDB;
using WebApi.IDatabase;
using WebApi.Models;

namespace WebApi.Database
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ModeDB _model;

        public CategoryRepository()
        {
            _model = new ModeDB();
        }

        public void AddCategory(Category category)
        {
            _model.Category.Add(category);
            _model.SaveChanges();
        }

        public void ChangeCategoryPosition(int idCategory, int? idNewParentCategory)
        {
            var category = _model.Category.Find(idCategory);
            if (category != null)
            {
                category.ParentId = idNewParentCategory;
                _model.SaveChanges();
            }
        }

        public void DeleteCategory(int idCategory)
        {
            var category = _model.Category.Find(idCategory);
            
                if (category == null) return;
                { 
                //if (category.ChildCategories.Count != 0)
                //{
                //    var categories = category.ChildCategories;
                //    foreach (var cat in categories)
                //    {
                //        DeleteChildCategory(cat.Id);
                        _model.Entry<Category>(category).State = EntityState.Deleted;
                   // }
                }
                
                    //DeleteItems(idCategory);

               // _model.Category.Remove(category);
                _model.SaveChanges();
            
            

        }
        public CategoryTree GetCategoryTree()
        {
            var items = _model.Item.ToList();
            var tree = GetTree(items);

            return tree;
        }

        public void UpdateCategory(int idCategory, string nameCategory)
        {
            var category = _model.Category.Find(idCategory);
            if (category != null)
            {
                category.Name = nameCategory;
                _model.SaveChanges();
            }
        }

        private void DeleteItems(int idCategory)
        {
            var items = _model.Item.ToList().FindAll(e => e.CategoryId == idCategory);

            foreach (var item in items)
            {
                _model.Entry<Item>(item).State = EntityState.Deleted;
            }
        }

        private void DeleteChildCategory(int idCategory)
        {
            var category = _model.Category.Find(idCategory);

            if (category == null) return;

            if (category.ChildCategories.Count != 0)
            {
                var categories = category.ChildCategories;
                foreach (var cat in categories)
                {
                    DeleteChildCategory(cat.Id);
                    _model.Entry<Category>(category).State = EntityState.Deleted;
                }
            }
            else
            {
                var items = category.Items;
                foreach (var item in items)
                {
                    DeleteItems(item.Id);
                }
            }
        }

        private static CategoryTree GetTree(List<Item> items)
        {
            return new CategoryTree();
        }
    }
}