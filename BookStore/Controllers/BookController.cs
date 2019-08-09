using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController:Controller
    {
        public IBookRepository _bookRepository;
        public ICategoryRepository _categoryRepository;
        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                books = _bookRepository.Books.OrderBy(p => p.BookId);
                currentCategory = "All books";

            }
            else
            {
                if (string.Equals("Fantasy", _category, StringComparison.OrdinalIgnoreCase))
                    books = _bookRepository.Books
                        .Where(p => p.CategoryId == 1)
                        .OrderBy(p => p.Name);
                else
              
                    books = _bookRepository.Books
                        .Where(p => p.CategoryId == 2)
                        .OrderBy(p => p.Name);

                currentCategory = _category;
            }
            return View(
                new BookListViewModel
                {
                    Books = books,
                    CurrentCategory = currentCategory
                });
        }

    }
}
