using Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ProductServices
{
    public class ProductRepository : IProductRepository 
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product(){ID = 1 ,ImgPath = "1.jpg" ,ProductName = "Chevorlet" , Price = 1000 , Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                new Product(){ID = 2 ,ImgPath = "2.jpg" , ProductName = "Ferrari" , Price = 2000 , Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Product(){ID = 3 ,ImgPath = "3.jpg" , ProductName = "Audi" , Price = 3000, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Product(){ID = 4 ,ImgPath = "4.jpg" , ProductName = "Benz" , Price = 4000, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
            };
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return products;
        }

        public void Delete(int productid)
        {
            var findproduct = products.First(p => p.ID == productid);
            products.Remove(findproduct);
        }

        public void Edit(int id, string name, int price)
        {
            var findproduct = products.First(p => p.ID == id);
            findproduct.ProductName = name;
            findproduct.Price = price;
        }

        public Product GetProductById(int id)
        {
            var findproduct = products.First(p => p.ID == id);
            return findproduct;
        }
    }
}

