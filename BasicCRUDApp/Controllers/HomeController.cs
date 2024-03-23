using BasicCRUDApp.Models;
using BasicCRUDApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicCRUDApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IRepository repo;
        public HomeController(IRepository _repo)
        {
            repo= _repo;    
           // _logger = logger;
        }

        public IActionResult Index()
        {
            var model = repo.GetItems();
            return View(model);
        }

        
        public IActionResult ItemDetails()
        {
            return View();
        }

        public IActionResult Books()
        {
            var model = repo.GetBooks();
            return View(model);
        }


        public IActionResult CreateBooks()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateBooks(Book book)
        {
            if(ModelState.IsValid)
            {
                repo.CreateBooks(book);
                return RedirectToAction("Books");
            }
            return View(book);
        }

        [HttpGet("{id}")]
        public IActionResult BookDetails(int id)
        {
            var model = repo.BookById(id);
            return View(model);
        }

        [HttpGet("update/{id}")]
        public IActionResult UpdateBook(int id)
        {
            var book = repo.BookById(id);   
            return View(book);
        }

        [HttpPost("update/{bookId}")]
        public async Task<IActionResult> UpdateBook(int bookId,Book model)
        {
            if (ModelState.IsValid)
            {
               await repo.UpdateBook(model);
                return RedirectToAction("BookDetails","Home",new {id=bookId});
            }
            return View(model);
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if(id != 0)
            {
               await repo.DeleteBook(id);
            }
            return RedirectToAction("Books", "Home");
        }
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Products()
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
