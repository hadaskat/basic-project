using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ProductDal : IProductDal
    {
       public  Delivery delivery;
        public ProductDal(Delivery Delivery)
        {
            this.delivery = Delivery;
        }
        public List<Product> AddProduct(Product product)
        {
            delivery.Products.Add(product);
            delivery.SaveChanges();
            return GetAllProducts();
        }

        public void DeleteProduct(int productId)
        {
            var product = delivery.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                delivery.Products.Remove(product);
                delivery.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            return delivery.Products.ToList();
        }


        public Product GetProductById(int productId)
        {
            return delivery.Products.FirstOrDefault(p => p.Id == productId);
        }

        public void UpdateProduct(int Id, Product product)
        {
            delivery.Products.Update(product);
            delivery.SaveChanges();
        }
    }

}









