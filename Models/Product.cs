using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public Guid Barcode { get; private set; }
        public long Price { get; set; }
        public string ImgPath { get; set; }
        public string Description { get; set; }

        public Product()
        {
            Barcode = Guid.NewGuid();
        }
    }
}
