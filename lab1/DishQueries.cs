using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class DishQueries
    {
        public string getAllType = "select name from dishType";
        public string add = "insert into dish(name,price,unit,type) values(@name,@price,(select id from units where name = @unitName),(select id from dishType where name = @typeName))";
        public string getAll = "select dish.id,dish.name,dish.price,dishType.name 'type',units.name 'unit' from dish inner join dishType on(dish.type = dishType.id) inner join units on(dish.unit = units.id)";
        public string delete = "delete from dish where id = @id";
        public string update = "update dish set name = @name, price = @price, unit = (select id from units where name=@unitName),type = (select id from dishType where name=@typeName) where id = @id;";
        public string addRecipes = "insert into recipe(dish_id,product_id,amount) values ((select id from dish where name = @dishName),(select id from product where name = @productName),@amount)";
        public string getAllProducts = "select product.name,recipe.amount,units.name from dish inner join recipe on dish.id=recipe.dish_id inner join product on product.id = recipe.product_id inner join units on product.unit=units.id where dish.name = @dishName";
        public string deleteRecipe = "delete from recipe where dish_id=(select id from dish where name = @dishName)";
        public string getProductPrice = "select units.name from product inner join units on product.unit=units.id where product.name = @productName";

    }
}
