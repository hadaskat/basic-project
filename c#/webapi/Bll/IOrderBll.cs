using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IOrderBll
    {
        public List<OrderDTO> post(OrderDTO order);
        public List<OrderDTO> getAll();
        public OrderDTO getById(int id);
        public void put(int id, OrderDTO order);
        public void delete(int id);
    }
}
