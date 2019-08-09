using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data.Interfaces;
using BookStore.Data.Models;

namespace BookStore.Repositories
{
    public class FakeBookRepository : IBookRepository
    {
       public ICategoryRepository categoryRepository = new FakeCategoryRepository();

        
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book {
                        Name = "Властелин колец",
                        Author = "Джон Толкин",
                        Price = 7.95M,
                        ShortDescription = "фантастика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = categoryRepository.Categories.First(),

                    },
                    new Book {
                        Name = "Дюна",
                        Author = "Фрэнк Герберт",
                        Price = 7.95M,
                        ShortDescription = "фантастика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = categoryRepository.Categories.First(),

                    },

                    new Book {
                        Name = "1984",
                        Author = "Джордж Оруэллт",
                        Price = 7.95M,
                        ShortDescription = "фантастика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = categoryRepository.Categories.First(),

                    },
                    new Book {
                        Name = "Поцелуй навылет",
                        Author = "Фиона Уокер",
                        Price = 7.95M,
                        ShortDescription = "романтика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = categoryRepository.Categories.Last(),

                    },
                    new Book {
                        Name = "Самая долгая поездка",
                        Author = "Николас Спаркс",
                        Price = 7.95M,
                        ShortDescription = "романтика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = categoryRepository.Categories.Last(),

                    },


                };
            }
        }





        public IEnumerable<Book> PopularBooks => throw new NotImplementedException();
    }
}
