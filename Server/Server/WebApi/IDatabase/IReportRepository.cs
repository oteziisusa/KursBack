using ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.IDatabase
{
    public interface IReportRepository
    {
        IEnumerable<Report> GetFullReport();

        IEnumerable<Report> GetReportItems(IEnumerable<Item> items);
    }
}
