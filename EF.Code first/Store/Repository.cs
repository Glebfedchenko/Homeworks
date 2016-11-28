using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Store
{
    class Repository
    {
        StoreDB context = new StoreDB();
        public List<Product> GetProducts()
        {
           return context.Products.ToList();
        }
        public void InsertProduct (Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void UpdateProducts(Product product)
        {
           Product ProductUpdate = context.Products.FirstOrDefault(x => x.ID == product.ID);
            ProductUpdate.Name = product.Name;
            ProductUpdate.Price = product.Price;
            context.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            Product ProductRemove = context.Products.FirstOrDefault(x => x.ID == product.ID);
            context.Products.Remove(ProductRemove);
            context.SaveChanges();
        }
    }
}
