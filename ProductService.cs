using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public static class ProductService
    {
        public static List<Product> GetProducts()
        {
            //string[,] products = new string[3, 3]
            //{
            //    {"gs1","PlayStation","399.99"},
            //    {"gs2","XBox One","299.99"},
            //    {"gs3","Nintendo Switch","199.99"}
            //};
            return new List<Product>()
            {
                new Product("gs1","PlayStation", 399.99m),
                new Product("gs2","XBox One",299.99m),
                new Product("gs3","Nintendo Switch",199.99m)
            };
        }
    }
}
