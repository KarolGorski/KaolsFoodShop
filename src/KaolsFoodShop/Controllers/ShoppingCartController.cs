using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KaolsFoodShop.Models;

namespace KaolsFoodShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IFoodRepository foodrepository, ShoppingCart shoppingCart)
        {
            _foodRepository = foodrepository;
            _shoppingCart = shoppingCart;
        }

    }
}
