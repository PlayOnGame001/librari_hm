using librari_hm.Models;
using Microsoft.AspNetCore.Mvc;

namespace librari_hm.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService BookService)
        {
            _bookService = BookService;
        }

        public IActionResult Index()
        {
            List<BookModel> Books = _bookService.GetAllBooks();

            return View(Books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel BookViewModel)
        {
            if (ModelState.IsValid)
            {
                BookModel Book = new BookModel
                {
                    Title = BookViewModel.Title,
                    Author = BookViewModel.Author,
                    Genre = BookViewModel.Genre,
                    Year = BookViewModel.Year
                };

                _bookService.AddBook(Book);

                return RedirectToAction("Index");
            }

            return View(BookViewModel);
        }
    }
}