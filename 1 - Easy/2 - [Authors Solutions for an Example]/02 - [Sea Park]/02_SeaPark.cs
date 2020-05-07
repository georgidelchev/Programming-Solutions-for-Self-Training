using System;

namespace SeaPark
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine(); // Working day of Weekend.
            double fishInTheStorage = double.Parse(Console.ReadLine()); // Total fish in the storage.

            int whalesCount = int.Parse(Console.ReadLine()); // Count of the whales.
            int dolphinsCount = int.Parse(Console.ReadLine()); // Count of the dolphins.
            int sealsCount = int.Parse(Console.ReadLine()); // Count of the seals.

            double fishForTheWhalesAtWorkday = 10;  // Fish that each whale eat at working day.
            double fishForTheDolphinsAtWorkday = 8; // Fish that each dolpin eat at working day.
            double fishForTheSealsAtWorkday = 4;    // Fish that each seal eat at working day.

            double fishForTheWhalesAtWeekend = 8;   // Fish that each whale eat at non working day.
            double fishForTheDolphinsAtWeekend = 5; // Fish that each dolpin eat at non working day.
            double fishForTheSealsAtWeekend = 2;    // Fish that each seal eat at non working day.

            double totalFish = 0; // Total fish sum.
            if (dayType == "Workday") // If the day is Workday.
            {
                totalFish += (fishForTheWhalesAtWorkday * whalesCount) + (fishForTheDolphinsAtWorkday * dolphinsCount) + (fishForTheSealsAtWorkday * sealsCount); // Total needed fish calculations.
            }
            else if (dayType == "Weekend") // If the day is non working day.
            {
                totalFish += (fishForTheWhalesAtWeekend * whalesCount) + (fishForTheDolphinsAtWeekend * dolphinsCount) + (fishForTheSealsAtWeekend * sealsCount); // Total needed fish calculations.
            }

            if (fishInTheStorage >= totalFish) // If fish is enough.
            {
                double leftFish = fishInTheStorage - totalFish; // Left fish calculations.
                Console.WriteLine($"Animals will eat! Left fish: {leftFish:f2} kilos."); // Message 
            }
            else // If fish is not enough.
            {
                double neededFish = totalFish - fishInTheStorage; // Needed fish calculations.
                Console.WriteLine($"Not enough fish... You have to buy more next time! Needed fish: {neededFish:f2} kilos."); // Message 
            }
        }
    }
}
