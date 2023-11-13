using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlTraning
{
    public class CountTable
    {
        public string SizeTable(int tableElem)
        {
            if (tableElem <= 0)
            {
                return "Елементів у таблиці немає";
            }
            else if(tableElem <= 100)
            {
                return "Маленька таблиця";
            }
            else if(tableElem <= 1000)
            {
                return "Середня таблиця";
            }
            return "Велика таблиця";
        }
    }
}
