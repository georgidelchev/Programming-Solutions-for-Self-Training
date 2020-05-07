using System;

namespace PoliceStationParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine()); // Input for total people count.
            double cakePrice = double.Parse(Console.ReadLine()); // The price for the cake.

            double policemansCount = Math.Floor(peopleCount * 0.60); // Policemans are 60% from everyone.
            double inspectorsCount = Math.Floor(peopleCount * 0.20); // Inspectors are 20% from everyone.
            double commissarsCount = Math.Floor(peopleCount * 0.20); // Commisars are 20% from everyone.

            int policemansCut = 20;  // Policeman cut for the party.
            int inspectorsCut = 15;  // Inspector cut for the party.
            int commissarsCut = 12;  // Commisar cut for the party.

            double moneyForTheParty = (policemansCount * policemansCut) + (inspectorsCount * inspectorsCut) + (commissarsCount * commissarsCut); 
            // Collected money for the party.

            double beerPrice = cakePrice * 0.60; // The price of the beer is 60% from the cake price.
            double decorationPrice = cakePrice * 0.20; // The price of the decorations are 20% from the cake price.
            double foodPrice = beerPrice * 0.50; // The price for the food is 50% from price of the beer.

            double totalSumForTheParty = cakePrice + beerPrice + decorationPrice + foodPrice; // The sum they need.

            if (moneyForTheParty >= totalSumForTheParty) // If sum is enough.
            {
                double leftMoney = moneyForTheParty - totalSumForTheParty; // Calculate left money.
                Console.WriteLine($"Let's go to the party! Money left: {leftMoney:f2}$!"); // Message with the left money.
            }
            else // If sum is not enough.
            {
                double neededMoney = totalSumForTheParty - moneyForTheParty; // Calculate needed money.
                Console.WriteLine($"You need {neededMoney:f2}$ for the party!"); // Message with the needed money.
            }
        }
    }
}
