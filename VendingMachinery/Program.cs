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
                    Console.Clear();
                    Console.WriteLine("\n\t----Vending Machine----\n");
                    vendingMachineServices.PrintMenu();
                    string? input = Console.ReadLine();

                    switch (input)
                    {

                        case "1":
                            Console.Clear();
                            vendingMachineServices.Purchase();
                            break;

                        case "2":
                            Console.Clear();
                            vendingMachineServices.ShowAll();
                            break;

                        case "3":
                            Console.Clear();
                            vendingMachineServices.Details();
                            break;

                        case "4":
                            Console.Clear();
                            vendingMachineServices.InsertMoney();
                            break;

                        case "5":
                            Console.Clear();
                            vendingMachineServices.EndTransaction();
                            break;

                        case "6":
                            Console.Clear();
                            run = false;
                            break;

                        default:
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