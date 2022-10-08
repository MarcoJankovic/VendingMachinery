using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinery.Models
{
    public class Toy : Product
    {
        public Toy(int minAge, string? name, double price, int id, ProductTypeEnum type, int stock) : base(name, price, id, type, stock)
        {
            MinAge = minAge;
        }
        public int MinAge { get; set; }

        public override string Examine()
        {
            return base.Examine() + $"";
        }

        public override string Use()
        {
            return "You are playing with the toy in a happy state! Weeeeee!";
        }
    }
}
