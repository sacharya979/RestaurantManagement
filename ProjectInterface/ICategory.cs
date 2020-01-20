using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
   public interface ICategory
    {
        List<CategoryDetails> GetAllCategory();
        int AddNewCategory(CategoryDetails cd);
        int UpdateCategory(CategoryDetails cd);
        int DeleteCategory(int categoryid);
        bool CheckCategory(string categoryName);
    }
}
