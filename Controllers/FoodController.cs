using System.Collections.Generic;
using FastFoodStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodStore.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            var foods = new List<Food>
            {
                new Food { Id = 1, Name = "Burger", Description = "Burger bò thơm ngon", Price = 50000, ImageUrl = "/images/burger.jpg" },
                new Food { Id = 2, Name = "Pizza", Description = "Pizza phô mai béo ngậy", Price = 120000, ImageUrl = "/images/pizza.jpg" }
            };
            return View(foods);
        }

        public IActionResult Details(int id)
        {
            var food = new Food { Id = id, Name = "Burger", Description = "Burger bò thơm ngon", Price = 50000, ImageUrl = "/images/burger.jpg" };
            return View(food);
        }
    }
}