using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class OrderDal : IOrderDal
    {
        public Delivery delivery;

        public OrderDal(Delivery Delivery)
        {
            this.delivery = Delivery;
        }

        public List<Order> AddOrder(Order order)
        {
            delivery.Orders.Add(order);
            delivery.SaveChanges();
            return GetAllOrders();
        }

        public void DeleteOrder(int orderId)
        {
            var order = delivery.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                delivery.Orders.Remove(order);
                delivery.SaveChanges();
            }
        }

        public List<Order> GetAllOrders()
        {
            return delivery.Orders.ToList();
        }


        public Order GetOrderById(int orderId)
        {
            return delivery.Orders.FirstOrDefault(o => o.Id == orderId);
        }


        public void UpdateOrder(int Id, Order order)
        {
            delivery.Orders.Update(order);
            delivery.SaveChanges();
        }
    }
}
