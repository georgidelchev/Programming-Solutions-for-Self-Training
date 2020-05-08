using System;

namespace VanessaVanHelsing
{
    class Program
    {
        static void Main(string[] args)
        {
            double vanHelsingsHealth = double.Parse(Console.ReadLine()); // Van Helsing's health.
            double vanHelsingsAttack = double.Parse(Console.ReadLine()); // Van Helsing's attack.

            double draculaHealth = double.Parse(Console.ReadLine()); // Dracula's health.
            double draculaAttack = double.Parse(Console.ReadLine()); // Dracula's attack.

            int roundsCounter = 0;

            string input = Console.ReadLine(); // Actions - Attack/Deffence , or Teleport.
            while (input != "Teleport") // While input is not equals to "Teleport" you will Attack or Deffence.
            {
                if (input == "Attack") // If input is Attack.
                {
                    draculaHealth -= vanHelsingsAttack; // Dracula takes Van Helsing's Damage.
                }
                else if (input == "Defence") // Else if input is Defence.
                {
                    vanHelsingsHealth -= (draculaAttack / 2); // Van Helsing takes 50% of the Dracula's Damage.
                }
                vanHelsingsHealth -= draculaAttack;

                roundsCounter++; // Increasing roundsCounter with 1.
                if (roundsCounter % 3 == 0) // Every third round Dracula takes double damage from Van Helsing.
                {
                    draculaHealth -= vanHelsingsAttack * 2; // Dracula's health - Van Helsing's damage * 2.
                }

                if (vanHelsingsHealth <= 0) // If Van Helsing's health is under or equals to 0 ,she is dead.
                {
                    vanHelsingsHealth = 0; // Set the health to zero in case is under zero.
                    Console.WriteLine($"You were defeated against Dracula. Dracula's remaining health: {draculaHealth}!"); // Message with the remaining health of Dracula.
                    break; // Breaks the while.
                }
                else if (draculaHealth <= 0) // else if Dracula's health is under or equals to 0 ,he is dead.
                {
                    draculaHealth = 0;// Set the health to zero in case is under zero.
                    Console.WriteLine($"Congo! You defeated the dark one! You have {vanHelsingsHealth} health remaining!"); // Message with the remaining health of Van Helsing.
                    break; // Breaks the while.
                }
                input = Console.ReadLine(); // Input again.
            }

            if (input == "Teleport") // If input is "Teleport".
            {
                Console.WriteLine("You decided to leave the battle with your teleportation skill!"); // Message.
                Console.WriteLine($"Dracula's remaining health: {draculaHealth}"); // Message with Draculs's remaining health.
                Console.WriteLine($"Vanessa Van Helsing's remaining health: {vanHelsingsHealth}"); // Message with Van Helsing's remaining health.
            }
        }
    }
}