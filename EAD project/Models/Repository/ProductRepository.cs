using EAD_project.Models.Interface;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace EAD_project.Models
{
    public class ProductRepository : IProduct
    {
        public void createProduct(Product product)
        {
            var context = new online_BookshopContext();
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void addtoList(List<Product> signupList)
        {
            var context = new online_BookshopContext();
            var Products = context.Products;
            foreach(Product p in Products)
            {
                signupList.Add(new Product()
                {
                    Id = p.Id
                ,
                    Title = p.Title
                ,
                    OldPrice = p.OldPrice
                ,
                    NewPrice = p.NewPrice
                ,
                    Image = p.Image
                });
            }
            
        }
        public List<Product> productList()
        {
            var context = new online_BookshopContext();
            var Products = context.Products;
            return Products.ToList();
        }
        public Product Edit(int? id)
        {
            var context = new online_BookshopContext();
            var Products = context.Products.Find(id);
            return Products;
        }
        public Product Details(int? id)
        {
            var context = new online_BookshopContext();
            var Products = context.Products.FirstOrDefault(x => x.Id == id);
            return Products;
        }
        public void Update(Product product)
        {
            var context = new online_BookshopContext();
            context.Products.Update(product);
            context.SaveChanges();
        }
        public bool productExist(int id)
        {
            var context = new online_BookshopContext();
            return context.Products.Any(e => e.Id == id);
        }
        public Product delete(int? id)
        {
            var context = new online_BookshopContext();
            var Products = context.Products.FirstOrDefault(x => x.Id == id);
            return Products;
        }
        public void deleteConfirmed(int id)
        {
            var context = new online_BookshopContext();
            var product =  context.Products.Find(id);
            if (product != null)
            {
                context.Products.Remove(product);
            }

            context.SaveChangesAsync();
        }
        public List<Product> searchbyPrice(int price, string searchTerm)
        {
            var context = new online_BookshopContext();
           return context.Products.Where(x => x.NewPrice == price || searchTerm == null).ToList();
        }
        public List<Product> searchbyTitle(string searchTerm)
        {
            var context = new online_BookshopContext();
            return context.Products.Where(x => x.Title.Contains(searchTerm) || searchTerm == null).ToList();
        }
    }
}
