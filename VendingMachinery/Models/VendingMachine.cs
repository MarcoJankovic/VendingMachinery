using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachinery.Data;

namespace VendingMachinery.Models
{
    public static class VendingMachine
    {
        public static List<Product> productList = new List<Product>
                {
                new Drink(33, "Cola", 10, 1, ProductTypeEnum.Drink, 5),
                new Drink(33, "Fanta", 10, 2, ProductTypeEnum.Drink, 10),
                new Drink(33, "Sprite", 10, 3, ProductTypeEnum.Drink, 10),
                new Drink(33, "Zingo", 15, 4, ProductTypeEnum.Drink, 8),
                new Food("2020-01-01", "Marabo", 25, 5, ProductTypeEnum.Food, 5),
                new Food("2020-04-03", "Nuts", 20, 6, ProductTypeEnum.Food, 7),
                new Food("2020-08-03", "Chips", 28, 7, ProductTypeEnum.Food, 2),
                new Toy(10,"Laser", 225, 8, ProductTypeEnum.Toy, 4),
                new Toy(8,"Granat", 100, 9, ProductTypeEnum.Toy, 10),
                new Toy(3,"Bomb", 2225, 10, ProductTypeEnum.Toy, 3),
             };
    }
}