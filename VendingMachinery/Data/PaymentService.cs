using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using VendingMachinery.Models;

namespace VendingMachinery.Data
{
    public static class PaymentService
    {
        public static double moneyPool = 0;

        public static string message = "";

        public static bool isValid = true;

        public static double moneyInsert = 0;

        public static readonly double[] moneyDenominations = new double[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public static List<CartItem> cartList = new List<CartItem>();


        public static void ValidateAmount()
        {
            isValid = moneyDenominations.Contains(moneyInsert);
            if (isValid)
            {
                moneyPool += moneyInsert;
            }
            else
            {
                PaymentService.message = " Wrong input value!";
            }
        }

        public static void AddToCartList(int id)
        {
            if (PaymentService.moneyPool >= VendingMachine.productList[id - 1].Price)
            {
                int quantity = VendingMachine.productList[id - 1].Stock;

                if (quantity >= 1)
                {
                    var item = VendingMachine.productList.Select(i => i).Where(i => i.Id == id).FirstOrDefault();
                    if (item != null)
                    {

                        if (cartList.Any())
                        {
                            int index = cartList.FindIndex(i => i.Id == item.Id);
                            if (index >= 0)
                            {
                                cartList[index].Stock += 1;
                                cartList[index].Price *= cartList[index].Stock;
                            }
                            else
                            {
                                cartList.Add(new CartItem(item.Name, item.Price, item.Id, item.Type, 1));
                            }
                        }
                        else
                        {
                            cartList.Add(new CartItem(item.Name, item.Price, item.Id, item.Type, 1));
                        }

                        VendingMachine.productList[id - 1].Stock--;
                        PaymentService.moneyPool -= VendingMachine.productList[id - 1].Price;
                        PaymentService.isValid = true;

                    }
                }

                else
                {
                    PaymentService.message = " Sold Out!";
                    PaymentService.isValid = false;
                }
            }
            else
            {
                PaymentService.message = " You don't have enough money for this product!";
                PaymentService.isValid = false;
            }

        }

        public static double SumCart()
        {
            return cartList.Sum(i => i.Price);
        }
    }
}