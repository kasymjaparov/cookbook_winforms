using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class ProductQueries
    {
        public string add = "insert into product(name,price,unit) values(@name,@price,(select id from units where name = @unitName))";
        public string getAll = "select product.id,product.name 'Название',price 'Цена' ,units.name 'Ед.изм' from product inner join units on (units.id=product.unit)";
        public string delete = "delete from product where id = @id";
        public string update = "update product set name = @name, price = @price, unit = (select id from units where name=@unitName) where id = @id;";
        public string getProductsName = "select name from product";
    }
}
