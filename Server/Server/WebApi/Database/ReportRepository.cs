using System;
using System.Collections.Generic;
using ModelDB.ModelDB;
using WebApi.IDatabase;
using WebApi.Models;

namespace WebApi.Database
{
    public class ReportRepository : IReportRepository
    {
        public IEnumerable<Report> GetFullReport()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Report> GetReportItems(IEnumerable<Item> items)
        {
            throw new NotImplementedException();
        }
    }
}