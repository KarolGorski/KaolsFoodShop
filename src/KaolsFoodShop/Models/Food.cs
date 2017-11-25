using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaolsFoodShop.Models
{
    public class Food
    {
        public int FoodId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string AllergyInformation { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl{ get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsFoodOfTheWeek { get; set; }

        public bool InStock { get; set; }

        public int CategoryIdd { get; set; }

        public virtual Category Category { get; set; }
    }
}
