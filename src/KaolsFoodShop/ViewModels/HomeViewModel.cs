using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaolsFoodShop.Models;

namespace KaolsFoodShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Food> FoodOfTheWeek { get; set; }
    }
}
