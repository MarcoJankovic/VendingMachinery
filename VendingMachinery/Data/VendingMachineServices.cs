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
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\tChoose one of the options: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\tMoney: {PaymentService.moneyPool}" + (PaymentService.isValid == true ? "" : PaymentService.message));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t1 - Purchase");
            Console.WriteLine("\t2 - Buy-list");
            Console.WriteLine("\t3 - Calculate.");
            Console.WriteLine("\t4 - Insert money.");
            Console.WriteLine("\t5 - Finalize Payment.");
            Console.WriteLine("\t6 - Show Vending Machine inventory.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t7 - Quit.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintPurchaseMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tChoose one of the options: ");
            Console.ResetColor();
            Console.WriteLine("\n\tPick a product by id to add to cart.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\tMoney: {PaymentService.moneyPool}" + (PaymentService.isValid == true ? "" : PaymentService.message));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\tPress q to return.");
            Console.ResetColor();
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
            Console.WriteLine("\n");
            foreach (Product product in VendingMachine.productList)
            {
                Console.WriteLine($"\tId:{product.Id}\t {product.Name}\t Price:{product.Price}\t Quantity: {product.Stock}");
            }
        }

        public void ShowBuyList()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t---- Buylist ----\n");
            foreach (Product product in PaymentService.cartList)
            {
                Console.WriteLine($"\t {product.Name}\t Price:{product.Price}\t Quantity:{product.Stock}");
            }
        }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\tYou can only insert 1, 5, 10, 20, 50, 100, 500, 1000: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\tType the amount of money you want to insert: ");
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
