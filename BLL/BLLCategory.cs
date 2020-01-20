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
    public class BLLCategory : ICategory
    {
        RMSDBEntities _db = new RMSDBEntities();
        public int AddNewCategory(CategoryDetails cd)
        {
            tbl_category tc = new tbl_category();
            tc.CategoryName = cd.CategoryName;
            tc.AddedDate = cd.AddedDate;
            _db.tbl_category.Add(tc);
            return _db.SaveChanges();
        }

        public bool CheckCategory(string categoryName)
        {
            var category = _db.tbl_category.Where(c => c.CategoryName == categoryName).FirstOrDefault();

            if (category != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteCategory(int categoryid)
        {
            tbl_category tc = _db.tbl_category.Where(c => c.Id == categoryid).FirstOrDefault();
            _db.tbl_category.Remove(tc);
            return _db.SaveChanges();
        }

        public List<CategoryDetails> GetAllCategory()
        {
            List<CategoryDetails> lstcat = new List<CategoryDetails>();
            var category = _db.tbl_category.ToList();
            foreach (var item in category)
            {
                lstcat.Add(new CategoryDetails() { Id = item.Id, CategoryName = item.CategoryName, AddedDate = item.AddedDate });
            }
            return lstcat;
        }

        public int UpdateCategory(CategoryDetails cd)
        {
            tbl_category tc = _db.tbl_category.Where(c => c.Id == cd.Id).FirstOrDefault();
            tc.CategoryName = cd.CategoryName;
            tc.AddedDate = cd.AddedDate;
            return _db.SaveChanges();
        }
    }
}
