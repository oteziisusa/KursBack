using ModelDB.ModelDB;
using WebApi.Models;

namespace WebApi.IDatabase
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Добавить категорию.
        /// </summary>
        /// <param name="category">Новая категория.</param>
        void AddCategory(Category category);

        /// <summary>
        /// Обновить категорию.
        /// </summary>
        /// <param name="idCategory">id категории.</param>
        /// <param name="nameCategory">Новое имя категории.</param>
        void UpdateCategory(int idCategory, string nameCategory);

        /// <summary>
        /// Изменить родительскую категорию у категории.
        /// </summary>
        /// <param name="idCategory">id изменяемой категории.</param>
        /// <param name="idNewParentCategory">id новой родительской категории.</param>
        void ChangeCategoryPosition(int idCategory, int? idNewParentCategory);

        /// <summary>
        /// Удалить категорию.
        /// </summary>
        /// <param name="idCategory">id удаляемой категории.</param>
        void DeleteCategory(int idCategory);

        /// <summary>
        /// Получить дерево из категорий и элементов.
        /// </summary>
        /// <returns>Дерево.</returns>
        CategoryTree GetCategoryTree();
    }
}
