using System;

namespace AnniversaryGift
{
    class Program
    {
        static void Main(string[] args)
        {
            double dressPrice = double.Parse(Console.ReadLine()); // The price of the dress.
            int monthsCount = int.Parse(Console.ReadLine()); // Months count.
            double electricityPrice = double.Parse(Console.ReadLine()); // Price of the electricity.
            double netPrice = double.Parse(Console.ReadLine()); // Price of the net.

            double totalCollectedSum = 0; // Total collected money counter.
            for (int i = 1; i <= monthsCount; i++) // For loop from 1 month to the months count.
            {
                double salary = double.Parse(Console.ReadLine()); // Your salary.
                if (i % 2 == 0) // every second month you have been rewarded with 100$.
                {
                    salary += 100; // 100$+ to the salary
                }
                totalCollectedSum += salary - electricityPrice - netPrice; // Total sum calculations
                // There is a chance Total collected money to be negative number , dont worry , continue your calculations.
            }

            if (dressPrice >= totalCollectedSum) // If dress i cheaper than your collected money.
            {
                double neededMoney = dressPrice - totalCollectedSum; // Needed money calculations.
                Console.WriteLine($"You have to buy something cheaper to your wife! Needed money: {neededMoney:f2}$"); // Message.
            }
            else // If you have enough money for the dress
            {
                double leftMoney = totalCollectedSum - dressPrice; // Left money calculations.
                Console.WriteLine($"You bought that dress. Your wife will be happy! Left money: {leftMoney:f2}$"); // Message.
            }
        }
    }
}
