using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachinery.Data;

namespace VendingMachinery.Models
{
    public interface IVending
    {
        public void Purchase(); // 1

        public void ShowAll(); // 2

        public void Details(); // 3

        public void InsertMoney(); // 4

        Dictionary<int, int> EndTransaction(); // 5
    }
}
