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
        public string getOrderPrice = "select dish.price,sum(dish_order.amount) 'amount'from orders inner join dish_order on orders.id=dish_order.order_id inner join dish on dish_order.dish_id = dish.id inner join units on dish.unit = units.id where orders.id=@orderId group by dish.price,units.name";
        public string getAmountOfOrder = "select amount from dish_order where order_id=@orderId and dish_id=(select id from dish where name=@dishName)";
        public string getDescAboutorder = "select dish.name,sum(dish_order.amount) 'amount',units.name from orders inner join dish_order on orders.id=dish_order.order_id inner join dish on dish_order.dish_id = dish.id inner join units on dish.unit = units.id where orders.id=@orderId group by dish.name,units.name";
        public string getFullInfoOrder = "select dish.name,sum(dish_order.amount) 'amount',dish.price,orders.price, orders.date from orders inner join dish_order on orders.id=dish_order.order_id inner join dish on dish_order.dish_id = dish.id where orders.id=@orderId group by dish.name,orders.price,orders.date,dish.price";
    
}
}
