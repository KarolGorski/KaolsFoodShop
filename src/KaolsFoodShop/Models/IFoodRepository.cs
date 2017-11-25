using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaolsFoodShop.Models
{
    public interface IFoodRepository
    {
        IEnumerable<Food> Foods { get; }
        IEnumerable<Food> FoodsOfTheWeek { get; }

        Food GetFoodById(int FoodId);
    }
}
