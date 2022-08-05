using ComicsGallery.Models;
using Microsoft.AspNetCore.Mvc;
using ComicsGallery.Data;

namespace ComicsGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
        public ComicBooksController()
        {
            _comicBookRepository= new ComicBookRepository(); 
        }
        public IActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
                
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook);
        }
    }
}
