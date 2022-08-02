using Microsoft.AspNetCore.Mvc;

namespace ComicsGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Detail()
        {
            return View();
        }
    }
}
