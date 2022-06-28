using System;

namespace The_Hunting_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfTheAdv = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());


            double totalWater = daysOfTheAdv * numberOfPlayers * waterPerDay;
            double totalFood = daysOfTheAdv * numberOfPlayers * foodPerDay;

            double energyLeft = groupEnergy;

            int firstCounter = 0;
            int secondCounter = 0;
            
            double currentFood = totalFood;

            for (int i = 1; i <= daysOfTheAdv; i++)
            {
                firstCounter++;
                secondCounter++;

                double energyLossPerDay = double.Parse(Console.ReadLine());

                energyLeft -= energyLossPerDay;

                if (energyLeft <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {currentFood:f2} food and {totalWater:f2} water.");
                    return;
                }

                if (firstCounter % 2 == 0)
                {
                    firstCounter = 0;
                    energyLeft *= 1.05;
                    totalWater *= 0.7;
                }

                if (secondCounter % 3 == 0)
                {
                    secondCounter = 0;
                    currentFood -= currentFood / numberOfPlayers;
                    energyLeft *= 1.1;
                }              

            }

            if (energyLeft > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyLeft:f2} energy!");
            }
        }
    }
}
