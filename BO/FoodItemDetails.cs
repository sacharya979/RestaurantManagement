using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class FoodItemDetails
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Price { get; set; }
        public byte Status { get; set; }
        public byte IsSpecial { get; set; }
        public string Discount { get; set; }
        public string ImageUrl { get; set; }
        public string FoodName { get; set; }
    }
}
