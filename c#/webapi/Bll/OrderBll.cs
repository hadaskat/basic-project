using AutoMapper;
using Dal;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class OrderBll : IOrderBll
    {
        IOrderDal orderDal;
        IMapper mapper;
        public OrderBll(IOrderDal orderDal, IMapper mapper)
        {
            this.orderDal = orderDal;
            this.mapper = mapper;
        }
        public void delete(int id)
        {
            orderDal.DeleteOrder(id);
        }

        public List<OrderDTO> getAll()
        {
            return mapper.Map<List<OrderDTO>>(this.orderDal.GetAllOrders());
        }

        public OrderDTO getById(int id)
        {
            return mapper.Map<OrderDTO>(this.orderDal.GetOrderById(id));
        }

        public List<OrderDTO> post(OrderDTO order)
        {
            return mapper.Map<List<OrderDTO>>(orderDal.AddOrder(mapper.Map<Order>(order)));
        }

        public void put(int id, OrderDTO order)
        {
            orderDal.UpdateOrder(id, mapper.Map<Order>(order));
        }
    }
}

