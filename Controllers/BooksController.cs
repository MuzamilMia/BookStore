using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDBContext context;

        public BooksController(ApplicationDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var books = await context.Books.ToListAsync();
            return View(books);
        }
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                await context.SaveChangesAsync();
                return RedirectToAction("Index", "Books");
            }
            return View(book);
        }
    }
}
