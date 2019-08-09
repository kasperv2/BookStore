using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Data
{
    public class SampleData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
            //public ICategoryRepository categoryRepository = new FakeCategoryRepository();
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }


            if (!context.Books.Any())
            {
                context.AddRange
                (
                    new Book
                    {
                        Name = "Властелин колец",
                        Author = "Джон Толкин",
                        Price = 7.95M,
                        ShortDescription = "фантастика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = Categories["Fantasy"]

                    },
                    new Book
                    {
                        Name = "Дюна",
                        Author = "Фрэнк Герберт",
                        Price = 7.95M,
                        ShortDescription = "фантастика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = Categories["Fantasy"]

                    },
                    new Book
                    {
                        Name = "1984",
                        Author = "Джордж Оруэллт",
                        Price = 7.95M,
                        ShortDescription = "фантастика",
                        LongDescription = "интересно читать",
                        CategoryId = 1,
                        Category = Categories["Fantasy"]

                    },
                    new Book
                    {
                        Name = "Поцелуй навылет",
                        Author = "Фиона Уокер",
                        Price = 7.95M,
                        ShortDescription = "романтика",
                        LongDescription = "интересно читать",
                        CategoryId = 2,
                        Category = Categories["Romance"]

                    },
                    new Book
                    {
                        Name = "Самая долгая поездка",
                        Author = "Николас Спаркс",
                        Price = 7.95M,
                        ShortDescription = "романтика",
                        LongDescription = "интересно читать",
                        CategoryId = 2,
                        Category = Categories["Romance"],

                    });

            }
            context.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fantasy", Description="Фантастика" },
                        new Category { CategoryName = "Romance", Description="Романтика" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }


    }
}

