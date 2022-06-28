using System;
using System.Collections.Generic;
using System.Linq;

namespace Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split("||").ToList();

            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());

            for (int i = 0; i < command.Count; i++)
            {
                string[] strings = command[i].Split(' ');
                string action = strings[0];

                switch (action)
                {
                    case "Travel":
                        int token = int.Parse(strings[1]);
                        fuel -= token;
                        if (fuel >= 0)
                        {
                            Console.WriteLine($"The spaceship travelled {token} light-years.");
                        }
                        break;

                    case "Enemy":
                        token = int.Parse(strings[1]);
                        if (ammo >= token)
                        {
                            ammo -= token;
                            Console.WriteLine($"An enemy with {token} armour is defeated.");
                        }
                        else
                        {
                            fuel -= token * 2;
                            if (fuel >= 0) // >=
                            {
                                Console.WriteLine($"An enemy with {token} armour is outmaneuvered.");
                            }
                        }
                        break;

                    case "Repair":
                        token = int.Parse(strings[1]);
                        fuel += token;
                        ammo += token * 2;

                        Console.WriteLine($"Ammunitions added: {token * 2}.");
                        Console.WriteLine($"Fuel added: {token}.");

                        break;

                    case "Titan":

                        Console.WriteLine($"You have reached Titan, all passengers are safe.");

                        return;

                }

                if (fuel < 0)
                {
                    Console.WriteLine("Mission failed.");
                    return;
                }
            }
        }
    }
}
