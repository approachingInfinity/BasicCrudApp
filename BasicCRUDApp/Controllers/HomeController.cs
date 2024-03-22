using BasicCRUDApp.Models;
using BasicCRUDApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicCRUDApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository repo;
        public HomeController(IRepository _repo,ILogger<HomeController> logger)
        {
            repo= _repo;    
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = repo.GetItems();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
