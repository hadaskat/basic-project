using AutoMapper;
using Dto;
using Entity;

namespace Bll
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<OrderDTO, Order>();
            CreateMap<Order, OrderDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
        }

    }
}