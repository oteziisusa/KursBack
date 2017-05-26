using System.Collections.Generic;
using ModelDB.ModelDB;
using WebApi.Models;

namespace WebApi.IDatabase
{
    public interface IReportRepository
    {
        IEnumerable<Report> GetFullReport();

        IEnumerable<Report> GetReportItems(IEnumerable<Item> items);
    }
}
