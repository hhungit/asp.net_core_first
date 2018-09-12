using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebERP.Repositories;
using WebERP.Models;
using WebERP.Dtos;
namespace WebERP.Controllers
{
    public class AuthorController : Controller
    {
        private IRepository<Author> repoAuthor;
        private IRepository<Book> repoBook;
        public AuthorController(IRepository<Author> repoAuthor, IRepository<Book> repoBook)
        {
            this.repoAuthor = repoAuthor;
            this.repoBook = repoBook;
        }
        public IActionResult Index()
        {
            List<AuthorListingViewModel> model = new List<AuthorListingViewModel>();
            repoAuthor.GetAll().ToList().ForEach(a =>
            {
                AuthorListingViewModel author = new AuthorListingViewModel
                {
                    Id = a.Id,
                    Name = $"{a.FirstName} {a.LastName}",
                    Email = a.Email,
                };
                author.TotalBooks = repoBook.GetAll().Count(x => x.Id == a.Id);
                model.Add(author);
            });
            
            return View("Index", model);
        }
        [HttpGet]
        public PartialViewResult AddAuthor()
        {
            AuthorBookViewModel model = new AuthorBookViewModel();
            return PartialView("_AddAuthor", model);
        }
        public ActionResult AddAuthor(AuthorBookViewModel model)
        {
            Author author = new Author
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                AddedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                Books = new List<Book>
                {
                    new Book
                    {
                        Name = model.BookName,
                        Isbn = model.ISBN,
                        Publisher = model.Publisher,
                         AddedDate = DateTime.UtcNow,
                         ModifiedDate = DateTime.UtcNow,
                    }
                }
            };
            repoAuthor.Insert(author);
            return RedirectToAction("Index");
        }
    }
}