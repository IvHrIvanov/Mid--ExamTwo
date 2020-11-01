using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            string[] comand = Console.ReadLine().Split(" ");
            int decreased = 2;
            int house = 0;
            while (comand[0] != "Love!")
            {
                int jump = int.Parse(comand[1]);

                for (int i = 0; i < jump; i++)
                {
                    house += 1;                   
                }

                if (house > neighborhood.Length-1)
                {
                    house = 0;
                }

                if (neighborhood[house] <= 0)
                {
                    Console.WriteLine($"Place {house} already had Valentine's day.");
                }
                else
                {
                    neighborhood[house] -= decreased;

                    if (neighborhood[house] <= 0)
                    {
                        Console.WriteLine($"Place {house} has Valentine's day.");
                    }
                }

                comand = Console.ReadLine().Split(" ");
            }
            int failedHouses = neighborhood.Count(x => x > 0);

            Console.WriteLine($"Cupid's last position was {house}.");

            if (failedHouses > 0)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}