using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public string AllComics()
        {
            return "Here are all the comics";
        }
    }
}
