using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachinery.Models;
using VendingMachinery.Data;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;

namespace VendingMachinery
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachineServices vendingMachineServices = new VendingMachineServices();

            bool run = true;
            while (run)
            {
                try
                {
                    Console.WriteLine("\n\t----Vending Machine----\n");
                    vendingMachineServices.PrintMenu();
                    string? input = Console.ReadLine();

                    switch (input)
                    {

                        case "1":
                            vendingMachineServices.Purchase();
                            vendingMachineServices.ShowAll();
                            Console.Clear();
                            break;

                        case "2":
                            Console.Clear();
                            vendingMachineServices.ShowBuyList();
                            break;

                        case "3":
                            Console.Clear();
                            vendingMachineServices.ShowBuyList();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(string.Format("\n\n\n\tThe total amount to pay: {0} ", PaymentService.SumCart()));
                            Console.ResetColor();
                            break;

                        case "4":
                            Console.Clear();
                            vendingMachineServices.InsertMoney();
                            break;

                        case "5":
                            Console.Clear();
                            vendingMachineServices.Animation();
                            Console.ForegroundColor = ConsoleColor.Green;                           
                            Console.WriteLine(string.Format("\n\n\n\tThe total amount you get back is: {0} ", PaymentService.EndTransaction()));
                            PaymentService.moneyPool = 0;
                            Console.ResetColor();
                            break;

                        case "6":
                            Console.Clear();
                            vendingMachineServices.ShowAll();
                            break;

                        case "7":
                            run = false;                            
                            break;

                        default:
                            vendingMachineServices.PrintMenu();
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}