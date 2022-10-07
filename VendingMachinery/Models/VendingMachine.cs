using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachinery.Data;

namespace VendingMachinery.Models
{
    public class VendingMachine : Product
    {
        public VendingMachine(string? name, double price, int id, Type type) : base(name, price, id, type) { }

        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
