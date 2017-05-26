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
    /// Сводное описание для RoomRepositoryTest
    /// </summary>
    [TestClass]
    public class RoomRepositoryTest
    {
        private IRoomRepository _roomRepository;
        public RoomRepositoryTest()
        {
            _roomRepository = new RoomRepository();
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
        public void GetCategoryInfoTest()
        {
            _roomRepository.GetCategoryInfo(3, 404);
        }

        [TestMethod]
        public void GetRoomInfoTest()
        {
            var categories=new List<Category>();

            categories.Add(new Category(){Name = "Test3", ParentId = 1});

            _roomRepository.GetRoomInfo(404, categories);
        }

        [TestMethod]
        public void GetRoomsTest()
        {
            _roomRepository.GetRooms();
        }

        [TestMethod]
        public void GetRoomsFilterTest()
        {
            var categories = new List<Category>();

            categories.Add(new Category() { Name = "Test3", ParentId = 1 });

            _roomRepository.GetRooms(categories);
        }
    }
}
