using System;

namespace First_Steps_In_Coding___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine());
            int catFoodCount = int.Parse(Console.ReadLine());
            double sigleDogFoodPrice = 2.5;
            double sigleCatFoodPrice = 4;
            double totalPriceForDogFood = dogFoodCount * sigleDogFoodPrice;
            double totalPriceForCatFood = catFoodCount * sigleCatFoodPrice;
            double totalPrice = totalPriceForDogFood + totalPriceForCatFood;
            Console.WriteLine($"{totalPrice} lv.");
            ;


        }
    }
}
