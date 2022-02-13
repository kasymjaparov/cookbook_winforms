using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class DishTypeQueries
    {
        public string getAll = "select * from dishType";
        public string add = "insert into dishType (name) values (@name)";
        public string delete = "delete from dishType where id = @id";
        public string update = "update dishType set name = @name where id = @id";
        public string getAllUnitForComboBox = "select name from dishType";
    }
}
