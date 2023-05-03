using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IProductBll
    {
        public List<ProductDTO> post(ProductDTO product);
        public List<ProductDTO> getAll();
        public ProductDTO getById(int id);
        public void put(int id, ProductDTO product);
        public void delete(int id);

    }
}
