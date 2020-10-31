using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int empoyesOne = int.Parse(Console.ReadLine());
            int empoyesTwo = int.Parse(Console.ReadLine());
            int empoyesThree = int.Parse(Console.ReadLine());

            int totalPeople = int.Parse(Console.ReadLine());


            int allAnswer = empoyesOne + empoyesTwo + empoyesThree;
            int timeNeedet = 0;

            while (totalPeople > 0)
            {
                timeNeedet++;
                totalPeople -= allAnswer;

                if (timeNeedet % 4 == 0)
                {
                    timeNeedet++;
                }

            }
            Console.WriteLine($"Time needed: {timeNeedet}h.");
        }
    }
}
