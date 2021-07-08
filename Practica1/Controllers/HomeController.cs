using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica1.Models;
using Practica1.DataAccessLayer;

namespace Practica1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PostgreSqlEtkcRepository _etkcRepository;
        private PostgreSql604Repository _repository604;
        
        public HomeController(ILogger<HomeController> logger, PostgreSql604Repository postgreSql604Repository, PostgreSqlEtkcRepository postgreSqlEtkcRepository)
        {
            _logger = logger;
            _etkcRepository = postgreSqlEtkcRepository;
            _repository604 = postgreSql604Repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        public IActionResult Organization()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Organization(Request request)
        {
            _etkcRepository.AddApplicant(request);
            //_repository604.AddApplicant(request);
            
            return View("Success");
        }
    }
}