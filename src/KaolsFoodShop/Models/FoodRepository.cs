using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KaolsFoodShop.Models
{
    public class FoodRepository :IFoodRepository
    {
        private readonly AppDbContext _appDbContext;

        public FoodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Food> Foods
        {
            get
            {
                return _appDbContext.Foods.Include(c => c.Category);
            }
        }

        public IEnumerable<Food> FoodsOfTheWeek
        {
            get
            {
                return _appDbContext.Foods.Include(c => c.Category).Where(p => p.IsFoodOfTheWeek);
            }
        }

        public Food GetFoodById(int FoodId)
        {
            return _appDbContext.Foods.FirstOrDefault(p => p.FoodId == FoodId);
        }
    }
}
