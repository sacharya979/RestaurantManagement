using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
    public interface IWaiter
    {
        List<WaiterDetails> GetAllWaiters();
        int AddNewWaiter(WaiterDetails wd);
        int UpdateWaiter(WaiterDetails wd);
        int DeleteWaiter(int Waiterid);
        bool CheckContact(string contact);
    }
}
