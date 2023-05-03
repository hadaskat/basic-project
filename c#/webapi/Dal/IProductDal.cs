using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;



namespace Dal
{
    public interface IProductDal
    {
        List<Product> GetAllProducts();
        List<Product> AddProduct(Product product);
        void UpdateProduct(int Id, Product product);
        void DeleteProduct(int Id);
        Product GetProductById(int Id);
    }
}
