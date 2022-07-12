using System;

namespace First_Steps_In_Coding___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yearPaiment = double.Parse(Console.ReadLine());
            double priceForSneakers = yearPaiment * 0.6;
            double priceForOutfit = priceForSneakers - (priceForSneakers * 0.2); // priceForSneakers * 0.8
            double priceForBall = priceForOutfit / 4; // priceForOutfith * 0.25;
            double priceForAccessories = priceForBall / 5; // priceForBall * 0.2;
            double finalPrice = yearPaiment + priceForSneakers + priceForOutfit + priceForBall + priceForAccessories;
            Console.WriteLine(finalPrice);
        }
    }
}
