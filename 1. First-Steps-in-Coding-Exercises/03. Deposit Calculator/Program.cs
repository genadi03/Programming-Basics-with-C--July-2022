using System;

namespace First_Steps_In_Coding___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine()); 
            double percent = double.Parse(Console.ReadLine());
            double interest = deposit * percent / 100;
            double interestPerMonth = interest / 12;
            double sum = deposit + months * interestPerMonth;
            Console.WriteLine(sum);

        }
    }
}
