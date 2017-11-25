﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaolsFoodShop.Models
{
    public class MockCategoryRepository :ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryId=1, CategoryName="Fruit pies", Description="Yep, fruit pies"},
                    new Category {CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy :D" },
                    new Category {CategoryId=3, CategoryName="Seasonal pies", Description="You can get in the mood of every season with them!" }
                };
            }
        }
    }
}
