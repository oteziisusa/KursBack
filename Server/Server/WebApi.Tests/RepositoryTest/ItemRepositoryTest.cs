using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelDB.ModelDB;
using WebApi.Database;
using WebApi.IDatabase;

namespace WebApi.Tests.RepositoryTest
{
    /// <summary>
    /// Сводное описание для ItemRepositoryTest
    /// </summary>
    [TestClass]
    public class ItemRepositoryTest
    {
        readonly IItemRepository _itemRepository;

        public ItemRepositoryTest()
        {
           _itemRepository=new ItemRepository();
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
        public void AddItemTest()
        {
            var item = new Item();
            item.Name = "Test";
            item.CategoryId = 3;
            item.NumberRoom = 404;
            item.RegistrationNumber = "2222222";

           _itemRepository.AddItem(item);
        }

        [TestMethod]
        public void ChangeItemPositionTest()
        {
            _itemRepository.ChangeItemPosition(2,4);
        }

        [TestMethod]
        public void DeleteItemTest()
        {
            _itemRepository.DeleteItem(2);
        }

        [TestMethod]
        public void UpdateItemTest()
        {
            var item = new Item();
            item.Name = "Test1";
            item.CategoryId = 3;
            item.NumberRoom = 404;


            _itemRepository.UpdateItem(1,item);
        }
    }
}
