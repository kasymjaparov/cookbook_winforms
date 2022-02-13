using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class OrdersQueries
    {
        public string getDishes = "select name from dish";
        public string getAllOrders = "select id, price 'Цена (сомы)', date 'Время заказа' from orders";
        public string delete = "delete from orders where id = @id";
        public string addEmpty = "INSERT INTO orders (price,date) VALUES(null,null);SELECT SCOPE_IDENTITY()";
        public string add ="insert into dish_order (dish_id,order_id,amount) values((select id from dish where name = @dishName),@orderId,@amount)";
        public string updateOrder = "update orders set price = @price, date = @date where id=@id";
        public string getPrice = "select price from dish where name = @dishName";
        public string getDescAboutorder = "select dish.name,dish_order.amount,units.name from orders inner join dish_order on orders.id=dish_order.order_id inner join dish on dish_order.dish_id = dish.id inner join units on dish.unit = units.id where orders.id=@orderId";
    
}
}
