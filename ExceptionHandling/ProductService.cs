using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ProductService
    {
        public Product GetProduct()
        {
            var product1 = new Product(1,20m,"LaFerrari","",10);
            
            return product1;
        }
    }
}
