using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VendingMachinery.Models;
using VendingMachinery.Data;

namespace VendingMachinery.Data
{
    public class VendingMachineServices : IVending
    {
        public void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tChoose one of the options: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\tMoney: {PaymentService.moneyPool}" + (PaymentService.isValid == true ? "" : PaymentService.message));
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

        public void PrintPurchaseMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tChoose one of the options: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\tMoney: {PaymentService.moneyPool}" + (PaymentService.isValid == true ? "" : PaymentService.message));
            Console.WriteLine("\n\t1 - Pick a product by id to add to cart.");
            Console.WriteLine("\tPress q to return.");
        }

        public void Purchase()
        {
            Console.Clear();
            ShowAll();
            PrintPurchaseMenu();
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    PaymentService.AddToCartList(Convert.ToInt32(input));
                    Purchase();
                    break;

                case "q":
                    Console.Clear();
                    break;

                default:
                    break;

            }
        }

        public void ShowAll()
        {
            Console.Clear();
            foreach (Product product in VendingMachine.productList)
            {
                Console.WriteLine($"\tId:{product.Id}\t {product.Name}\t Price:{product.Price}\t Quantity: {product.Stock}");
            }
        }

        public void ShowBuyList()
        {
            Console.Clear();
            foreach (Product product in PaymentService.cartList)
            {
                Console.WriteLine($"\tId:{product.Id}\t {product.Name}\t Price:{product.Price}\t Quantity: {product.Stock}");
            }
        }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney()
        {
            Console.Write("\n\tType the amount of money you want to insert: ");
            PaymentService.moneyInsert = Convert.ToInt32(Console.ReadLine());
            PaymentService.ValidateAmount();
            Console.WriteLine("\n\tPress Enter To Go Back");
            Console.Clear();
        }

        public Dictionary<int, int> EndTransaction()
        {
            throw new NotImplementedException();
        }

    }
}
