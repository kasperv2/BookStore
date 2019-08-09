using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data.Interfaces;
using BookStore.Data.Models;

namespace BookStore.Repositories
{
    public class FakeCategoryRepository:ICategoryRepository
    {
        IEnumerable<Category> ICategoryRepository.Categories
        {
            get => new List<Category>
            {
                 new Category { CategoryName = "Fantasy", Description = "Кошка" },
                 new Category {CategoryName="Romance", Description="Собака"},
            };

        }
    }
}
