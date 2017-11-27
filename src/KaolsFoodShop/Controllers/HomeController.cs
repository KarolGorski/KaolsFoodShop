using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KaolsFoodShop.Models;
using KaolsFoodShop.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KaolsFoodShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodRepository _foodRepository;

        public HomeController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                FoodOfTheWeek =_foodRepository.FoodsOfTheWeek;
            };
        }
    }
}
