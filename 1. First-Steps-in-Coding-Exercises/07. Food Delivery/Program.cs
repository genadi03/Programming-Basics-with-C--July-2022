using System;

namespace First_Steps_In_Coding___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countChicken = int.Parse(Console.ReadLine());
            int countFish = int.Parse(Console.ReadLine());  
            int countVegan = int.Parse(Console.ReadLine());

            double priceChiken = countChicken * 10.35;
            double priceFish = countFish * 12.40;
            double priceVegan = countVegan * 8.15;
            double priceMenus = priceChiken + priceFish + priceVegan;
            double dessertPrice = 0.2 * priceMenus;
            double totalPrice = priceMenus + dessertPrice + 2.5;
            Console.WriteLine(totalPrice);
        }
    }
}
