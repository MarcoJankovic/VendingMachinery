using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinery.Models
{
    public class Food : Product
    {
        public Food(string? expirationDate, string? name, double price, int id, ProductTypeEnum type, int stock) : base(name, price, id, type, stock)
        {
            ExpirationDate = expirationDate;
        }
        public string? ExpirationDate { get; set; }

        public override string Examine()
        {
            return base.Examine() + $"";
        }
        public override string Use()
        {
            return "You eat the food, it taste delicious!   mmmhhhh!";
        }
    }
}
