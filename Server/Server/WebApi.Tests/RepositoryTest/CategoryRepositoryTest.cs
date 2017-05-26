using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.IDatabase;
using ModelDB.ModelDB;
using WebApi.Database;

namespace WebApi.Tests.RepositoryTest
{
    /// <summary>
    /// Сводное описание для CategoryRepositoryTest
    /// </summary>
    [TestClass]
    public class CategoryRepositoryTest
    {
        readonly ICategoryRepository _categoryRepository;

        public CategoryRepositoryTest()
        {
            _categoryRepository=new CategoryRepository();
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetCategoryTreeTest()
        {
            var tree = _categoryRepository.GetCategoryTree();
        }

        [TestMethod]
        public void AddCategoryTest()
        {
            var category = new Category();
            category.Name = "Test";
            category.ParentId = 1;

            _categoryRepository.AddCategory(category);
        }

        [TestMethod]
        public void ChangeCategoryPositionTest()
        {
            _categoryRepository.ChangeCategoryPosition(4, 3);
        }

        [TestMethod]
        public void UpdateCategoryTest()
        {
            _categoryRepository.UpdateCategory(1,"Test1");
        }

        [TestMethod]
        public void DeleteCategoryTest()
        {
           _categoryRepository.DeleteCategory(3);
        }
    }
}
