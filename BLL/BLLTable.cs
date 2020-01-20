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
    public class BLLTable : ITable
    {
        RMSDBEntities _db = new RMSDBEntities();
        public int AddNewTable(TableDetails td)
        {
            tbl_table tt = new tbl_table();
            tt.TableNumber = td.TableNumber;
            tt.AddedDate = td.AddedDate;
            _db.tbl_table.Add(tt);
            return _db.SaveChanges();
        }

        public bool CheckTable(string number)
        {
            var tableNumber = _db.tbl_table.Where(c => c.TableNumber == number).FirstOrDefault();

            if (tableNumber != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteTable(int tableid)
        {
            tbl_table td = _db.tbl_table.Where(c => c.Id == tableid).FirstOrDefault();
            _db.tbl_table.Remove(td);
            return _db.SaveChanges();
        }

        public List<TableDetails> GetAllTables()
        {
            List<TableDetails> lsttables = new List<TableDetails>();
            var tables = _db.tbl_table.ToList();
            foreach (var item in tables)
            {
                lsttables.Add(new TableDetails() { Id = item.Id, TableNumber = item.TableNumber, AddedDate = item.AddedDate });
            }
            return lsttables;
        }

        public int UpdateTable(TableDetails td)
        {
            tbl_table tt = _db.tbl_table.Where(c => c.Id == td.Id).FirstOrDefault();
            tt.TableNumber = td.TableNumber;
            tt.AddedDate = td.AddedDate;
            return _db.SaveChanges();
        }
    }
}
