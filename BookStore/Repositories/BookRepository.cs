using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Data.Interfaces;
using BookStore.Data.Models;

namespace BookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> Books => _appDbContext.Books;

        public IEnumerable<Book> PopularBooks => _appDbContext.Books
            .Where(p => p.IsPopularBook == true)
            ;
    }
}
