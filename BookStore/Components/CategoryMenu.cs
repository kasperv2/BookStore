using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Components
{
    public class CategoryMenu:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
