using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelDB.ModelDB;
using WebApi.Database;
using WebApi.IDatabase;

namespace WebApi.Tests.RepositoryTest
{
    /// <summary>
    /// Сводное описание для ReportRepositoryTest
    /// </summary>
    [TestClass]
    public class ReportRepositoryTest
    {

        readonly IReportRepository _reportRepository;

        public ReportRepositoryTest()
        {
            _reportRepository = new ReportRepository();
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
        public void GetFullReportTest()
        {
            var report =_reportRepository.GetFullReport();
        }

        [TestMethod]
        public void GetReportItemsTest()
        {
            var items = new List<Item>();
            items.Add(new Item() { Name = "Test2", NumberRoom = 404, CategoryId = 3, RegistrationNumber = "3333" });
            items.Add(new Item() { Name = "Test2", NumberRoom = 404, CategoryId = 3, RegistrationNumber = "3333" });


            var report = _reportRepository.GetReportItems(items);
        }
    }
}
