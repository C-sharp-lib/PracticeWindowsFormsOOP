using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private string Code {  get; set; }
        private string Description { get; set; }
        private decimal Price { get; set; }
        public Product() { }
        public Product(string code, string description, decimal price) 
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public string GetDisplayText(string sep)
        {
            return $"{Code}{sep} {Description}{sep} {Price.ToString("C")}";
        }
    }
}
