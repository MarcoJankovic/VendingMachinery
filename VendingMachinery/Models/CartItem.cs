using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinery.Models
{
    public class CartItem : Product
    {
        public CartItem(string? name, double price, int id, ProductTypeEnum type, int stock) : base(name, price, id, type, stock)
        {
        }
        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
