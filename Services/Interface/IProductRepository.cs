using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        void Delete(int productid);
        Product GetProductById(int id);
        public void Edit(int id, string name, int price);
    }
}
