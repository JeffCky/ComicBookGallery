using ComicsGallery.Data;
using ComicsGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComicsGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ComicBookRepository _comicBookRepository = null;
        
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _comicBookRepository = new ComicBookRepository();
        }

        public IActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
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