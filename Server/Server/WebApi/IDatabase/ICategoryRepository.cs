using ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.IDatabase
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void UpdateCategory(int idCategory, string nameCategory);
        void ChangeCategoryPosition(int idCategory, int idNewParentCategory);
        void DeleteCategory(int idCategory);
    }
}
