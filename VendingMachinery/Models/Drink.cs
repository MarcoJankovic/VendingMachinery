using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinery.Models
{
    public class Drink : Product
    {
        public Drink(int canSize, string? name, double price, int id, ProductTypeEnum type, int stock) : base(name, price, id, type, stock)
        {
            CanSize = canSize;
        }

        public int CanSize { get; set; }

        public override string Examine()
        {
            return base.Examine() + $"The {CanSize} is 33cl and cold enough to drink!";
        }

        public override string Use()
        {
            return "You slurp the cold drink, it taste delicious!  ahhhhhh!";
        }
    }
}
