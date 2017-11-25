using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KaolsFoodShop.Models;

namespace KaolsFoodShop.ViewModels
{
    public class FoodListViewModel
    {
        public IEnumerable<Food> Foods { get; set; }

        public string CurrentCategory { get; set; }
    }
}
