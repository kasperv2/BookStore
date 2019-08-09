using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        //public string ImageUrl { get; set; }
        //public string ImageThumbNailUrl { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        // public string Category { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public bool IsPopularBook { get; set; }
    }
}
