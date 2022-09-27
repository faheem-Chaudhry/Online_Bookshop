using System.Collections.Generic;

namespace EAD_project.Models.Interface
{
    public interface IProduct
    {
        public void createProduct(Product product);
        public void addtoList(List<Product> signupList);
        public List<Product> productList();
        public Product Edit(int? id);
        public Product Details(int? id);
        public bool productExist(int id);
        public void Update(Product product);
        public Product delete(int? id);

        public void deleteConfirmed(int id);

        public List<Product> searchbyPrice(int price,string searchTerm);
        public List<Product> searchbyTitle( string searchTerm);
    }
}
