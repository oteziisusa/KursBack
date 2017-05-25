using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.IDatabase;
using Newtonsoft.Json;
using WebApi.Models;
using ModelDB;

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
