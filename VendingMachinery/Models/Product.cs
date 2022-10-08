using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinery.Models
{
    public abstract class Product
    {        
        public string? Name { get; set; }  // Fields
        public double Price { get; set; }
        public int Id { get; set; }
        public ProductTypeEnum Type { get; set; } // Enum
        public int Stock { get; set; }

        public Product(string? name, double price, int id, ProductTypeEnum type, int stock)   // Constructor
        {
            Name = name;
            Price = price;
            Id = id;
            Type = type;
            Stock = stock;
        }

        public virtual string Examine()
        {
            return $"-----{this.GetType().Name}----- \nName: {Name} \nPrice: {Price} \nId: {Id} \t {Type}";
        }

        public abstract string Use();

    }
}
