using System;

namespace First_Steps_In_Coding___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArhitects = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int individualProjectsTime = 3;
            int timeForAllProjects = numberOfProjects * individualProjectsTime;
            Console.WriteLine($"The architect {nameOfTheArhitects} will need {timeForAllProjects} hours to complete {numberOfProjects} project/s.");
        }
    }
}
