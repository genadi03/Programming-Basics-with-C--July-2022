﻿using System;

namespace First_Steps_In_Coding___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double priceWithoutDiscount = size * 7.61;
            double discount = priceWithoutDiscount * 0.18;
            Console.WriteLine($"The final price is: {priceWithoutDiscount - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
