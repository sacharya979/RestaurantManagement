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
    public class BLLWaiter : IWaiter
    {
        RMSDBEntities _db = new RMSDBEntities();
        public int AddNewWaiter(WaiterDetails wd)
        {
            tbl_waiter tw = new tbl_waiter();
            tw.WaiterName = wd.WaiterName;
            tw.WaiterContact = wd.WaiterContact;
            tw.WaiterAddress = wd.WaiterAddress;
            _db.tbl_waiter.Add(tw);
            return _db.SaveChanges();
        }

        public bool CheckContact(string contact)
        {
            var Contact = _db.tbl_waiter.Where(c => c.WaiterContact == contact).FirstOrDefault();

            if (Contact != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteWaiter(int Waiterid)
        {
            tbl_waiter td = _db.tbl_waiter.Where(c => c.WaiterID == Waiterid).FirstOrDefault();
            _db.tbl_waiter.Remove(td);
            return _db.SaveChanges();
        }

        public List<WaiterDetails> GetAllWaiters()
        {
            List<WaiterDetails> lstwaiters = new List<WaiterDetails>();
            var waiters = _db.tbl_waiter.ToList();
            foreach (var item in waiters)
            {
                lstwaiters.Add(new WaiterDetails() { WaiterID = item.WaiterID, WaiterName = item.WaiterName, WaiterContact = item.WaiterContact, WaiterAddress = item.WaiterAddress });
            }
            return lstwaiters;
        }

        public int UpdateWaiter(WaiterDetails wd)
        {
            tbl_waiter td = _db.tbl_waiter.Where(c => c.WaiterID == wd.WaiterID).FirstOrDefault();
            td.WaiterName = wd.WaiterName;
            td.WaiterContact = wd.WaiterContact;
            td.WaiterAddress = wd.WaiterAddress;
            return _db.SaveChanges();
        }
    }
}
