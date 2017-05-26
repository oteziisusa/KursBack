using System.Collections.Generic;
using System.Web.Http;
using WebApi.IDatabase;
using WebApi.Models;
using ModelDB.ModelDB;

namespace WebApi.Controllers
{
    public class ReportController : ApiController
    {
        IReportRepository reporterRepository;

        public IEnumerable<Report> GetFullReport()
        {
            var reports= reporterRepository.GetFullReport();
            return reports;
        }

        public IEnumerable<Report> GetReportItems(IEnumerable<Item> items)
        {
            var reports = reporterRepository.GetReportItems(items);
            return reports;
        }
    }
}
