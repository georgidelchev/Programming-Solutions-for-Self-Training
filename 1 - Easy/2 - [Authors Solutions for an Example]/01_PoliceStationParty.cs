using System;

namespace PoliceStationParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine()); // input for total peopleCount
            double cakePrice = double.Parse(Console.ReadLine()); // the price for the cake

            double policemansCount = Math.Floor(peopleCount * 0.60); // policemans are 60% from everyone
            double inspectorsCount = Math.Floor(peopleCount * 0.20); // inspectors are 20% from everyone
            double commissarsCount = Math.Floor(peopleCount * 0.20); // commisars are 20% from everyone

            int policemansCut = 20;  // policeman cut for the party.
            int inspectorsCut = 15;  // inspector cut for the party.
            int commissarsCut = 12;  // commisar cut for the party.

            double moneyForTheParty = (policemansCount * policemansCut) + (inspectorsCount * inspectorsCut) + (commissarsCount * commissarsCut); // needed money for the party

            double beerPrice = cakePrice * 0.60; // 60% from cakePrice.
            double decorationPrice = cakePrice * 0.20; // 20% from cakePrice.
            double foodPrice = beerPrice * 0.50; // 50% from beerPrice.

            double totalSumForTheParty = cakePrice + beerPrice + decorationPrice + foodPrice; // the sum they need

            if (moneyForTheParty >= totalSumForTheParty) // if sum is enough 
            {
                double leftMoney = moneyForTheParty - totalSumForTheParty; // leftMoney
                Console.WriteLine($"Let's go to the party! Money left: {leftMoney:f2}$!"); // output
            }
            else // if sum is not enough
            {
                double neededMoney = totalSumForTheParty - moneyForTheParty; // neededMoney
                Console.WriteLine($"You need {neededMoney:f2}$ for the party!"); // output
            }
        }
    }
}
