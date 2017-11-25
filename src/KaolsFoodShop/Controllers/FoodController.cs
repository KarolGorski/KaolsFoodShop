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
    public class FoodController : Controller
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;

        public FoodController(IFoodRepository foodRepository, ICategoryRepository categoryRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            FoodListViewModel foodListViewModel = new FoodListViewModel();
            foodListViewModel.Foods = _foodRepository.Foods;

            foodListViewModel.CurrentCategory = "Cheese cakes";
            return View(foodListViewModel);
        }
    }
}
