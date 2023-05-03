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
    public class ProductBll :IProductBll
    {
        IProductDal productDal;
        IMapper mapper;
        public ProductBll(IProductDal productDal, IMapper mapper)
        {
            this.productDal = productDal;
            this.mapper = mapper;
        }
        public void delete(int id)
        {
            productDal.DeleteProduct(id);
        }

        public List<ProductDTO> getAll()
        {
            return mapper.Map<List<ProductDTO>>(this.productDal.GetAllProducts());
        }

        public ProductDTO getById(int id)
        {
            return mapper.Map<ProductDTO>(this.productDal.GetProductById(id));
        }

        public List<ProductDTO> post(ProductDTO product)
        {
            return mapper.Map<List<ProductDTO>>(productDal.AddProduct(mapper.Map<Product>(product)));
        }

        public void put(int id, ProductDTO product)
        {
            productDal.UpdateProduct(id, mapper.Map<Product>(product));
        }
    }
}

