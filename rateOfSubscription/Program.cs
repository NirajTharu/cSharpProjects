﻿// 

using System;
namespace RateOfSubscription
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);
            if (daysUntilExpiration < 1)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration <= 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
                Console.WriteLine($"Renew now and save {discountPercentage} % !");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
                Console.WriteLine($"Renew now and save {discountPercentage} % !");
            }
            else
            {
                Console.WriteLine("Your subscription will expire soon.Renew now!");
            }
        }
    }
}