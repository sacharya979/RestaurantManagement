using BO;
using DAL;
using ProjectInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFoodItem : IFoodItem
    {
        RMSDBEntities _db = new RMSDBEntities();
        public int AddNewFoodItem(FoodItemDetails fd)
        {
            tbl_fooditems tf = new tbl_fooditems();
            tf.CategoryName = fd.CategoryName;
            tf.Price = fd.Price;
            tf.Status = fd.Status;
            tf.IsSpecial = fd.IsSpecial;
            tf.Discount = fd.Discount;
            tf.ImageUrl = fd.ImageUrl;
            tf.FoodName = fd.FoodName;
            _db.tbl_fooditems.Add(tf);
            return _db.SaveChanges();
        }

        public bool CheckFoodItem(string foodName)
        {
            var food = _db.tbl_fooditems.Where(c => c.FoodName == foodName).FirstOrDefault();

            if (food != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteFoodItem(int foodid)
        {
            tbl_fooditems tf = _db.tbl_fooditems.Where(c => c.Id == foodid).FirstOrDefault();
            _db.tbl_fooditems.Remove(tf);
            return _db.SaveChanges();
        }

        public List<FoodItemDetails> GetAllFoodItems()
        {
            List<FoodItemDetails> lstfood = new List<FoodItemDetails>();
            var food = _db.tbl_fooditems.ToList();
            foreach (var item in food)
            {
                lstfood.Add(new FoodItemDetails() { Id = item.Id, CategoryName = item.CategoryName, Price = item.Price, Status=item.Status, IsSpecial=item.IsSpecial, Discount=item.Discount, ImageUrl=item.ImageUrl, FoodName=item.FoodName });
            }
            return lstfood;
        }

        public int UpdateFoodItem(FoodItemDetails fd)
        {
            tbl_fooditems tf = _db.tbl_fooditems.Where(c => c.Id == fd.Id).FirstOrDefault();
            tf.CategoryName = fd.CategoryName;
            tf.Price = fd.Price;
            tf.Status = fd.Status;
            tf.IsSpecial = fd.IsSpecial;
            tf.Discount = fd.Discount;
            tf.ImageUrl = fd.ImageUrl;
            tf.FoodName = fd.FoodName;
            return _db.SaveChanges();
        }
    }
}
