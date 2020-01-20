using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
   public interface IUser
    {
        List<UserDetails> GetAllUsers();
        int AddNewUser(UserDetails ud);
        int UpdateUser(UserDetails ud);
        int DeleteUser(int userid);
        bool CheckEmail(string email);
    }
}
