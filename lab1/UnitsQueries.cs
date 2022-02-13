using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class UnitsQueries
    {
        public string getAll = "select * from units";
        public string add = "insert into units (name) values (@name)";
        public string delete = "delete from units where id = @id";
        public string update = "update units set name = @name where id = @id";
        public string getAllUnitForComboBox = "select name from units";
    }
}
