using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
   public interface IFoodItem
    {
        List<FoodItemDetails> GetAllFoodItems();
        int AddNewFoodItem(FoodItemDetails fd);
        int UpdateFoodItem(FoodItemDetails fd);
        int DeleteFoodItem(int foodid);
        bool CheckFoodItem(string foodName);
    }
}
