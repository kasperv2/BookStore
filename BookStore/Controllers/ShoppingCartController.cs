﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IBookRepository _bookRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBookRepository bookRepository, ShoppingCart shoppingCart)
        {
            _bookRepository = bookRepository;
            _shoppingCart = shoppingCart;
        }

        //[Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        // [Authorize]
        public RedirectToActionResult AddToShoppingCart(int bookId)
        {
            var selectedBook = _bookRepository.Books.FirstOrDefault(p => p.BookId == bookId);
            if (selectedBook != null)
            {
                _shoppingCart.AddToCart(selectedBook, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int bookId)
        {
            var selectedBook = _bookRepository.Books.FirstOrDefault(p => p.BookId == bookId);
            if (selectedBook != null)
            {
                _shoppingCart.RemoveFromCart(selectedBook);
            }
            return RedirectToAction("Index");
        }

    }
}
