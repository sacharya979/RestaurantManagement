using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
    public interface ITable
    {
        List<TableDetails> GetAllTables();
        int AddNewTable(TableDetails td);
        int UpdateTable(TableDetails td);
        int DeleteTable(int tableid);
        bool CheckTable(string number);
    }
}
