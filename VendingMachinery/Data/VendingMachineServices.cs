using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VendingMachinery.Models;

namespace VendingMachinery.Data
{
    public class VendingMachineServices : IVending
    {

        int[] moneyDenominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        int moneyInsert;
        int moneyPool = 0;

        VendingMachineServices vendingMachineServices = new VendingMachineServices();
        public void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tChoose one of the options: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\tMoney: {vendingMachineServices.InsertMoney}");
            Console.WriteLine("\n\t1 - Add a product to buy-list.");
            Console.WriteLine("\t2 - Show buy-list.");
            Console.WriteLine("\t3 - Calculate all goods.");
            Console.WriteLine("\t4 - Insert money.");
            Console.WriteLine("\t5 - Finalize.");
            Console.WriteLine("\t6 - Show inventory.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t7 - Quit.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Purchase()
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            throw new ArgumentNullException();
        }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney()
        {
            Console.Write("\n\tType the amount of money you want to insert: ");

            for (int i = 0; i < 100; i++)
            {
                moneyInsert = Convert.ToInt32(Console.ReadLine());
                moneyPool += moneyInsert;
                Console.WriteLine("\n\tPress Enter To Go Back");
            }

        }

        public Dictionary<int, int> EndTransaction()
        {
            throw new NotImplementedException();
        }

    }
}
