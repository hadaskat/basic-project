using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface IOrderDal
    {
        List<Order> GetAllOrders();
        List<Order> AddOrder(Order order);
        void UpdateOrder(int Id, Order order);
        void DeleteOrder(int Id);
        Order GetOrderById(int Id);
    }
}
