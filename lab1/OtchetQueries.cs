using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class OtchetQueries
    {
        public string getSumDishesFromOrders = "select sum(dish_order.amount)*dish.price from orders inner join dish_order on orders.id=dish_order.order_id inner join dish on dish_order.dish_id = dish.id group by orders.id,dish.name,orders.price,orders.date,dish.price";
        public string getDishesFromOrders = "select dish.name,sum(dish_order.amount) 'amount',dish.price,sum(dish_order.amount)*dish.price 'Sum', orders.date from orders inner join dish_order on orders.id=dish_order.order_id inner join dish on dish_order.dish_id = dish.id group by orders.id,dish.name,orders.price,orders.date,dish.price";
    }
}
