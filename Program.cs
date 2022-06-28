using System;
using System.Collections.Generic;
using System.Linq;

namespace Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                string action = command[0];

                if (action == "End")
                {
                    Console.WriteLine(string.Join(", ", phones));
                    return;
                }

                string model = command[2];

                switch (action)
                {
                    case "Add":
                        if (!phones.Contains(model))
                        {
                            phones.Add(model);
                        }
                        break;

                    case "Remove":
                        if (phones.Contains(model))
                        {
                            phones.Remove(model);
                        }
                        break;

                    case "Bonus":
                        List<string> bonus = command[3].Split(":").ToList();
                        string oldPhone = bonus[0];
                        string newPhone = bonus[1];

                        if (phones.Contains(oldPhone))
                        {

                            for (int i = 0; i < phones.Count; i++)
                            {
                                if (oldPhone == phones[i])
                                {
                                    phones.Insert(i + 1, newPhone);
                                }
                            }
                        }
                        break;

                    case "Last":
                        if (phones.Contains(model))
                        {
                            phones.Remove(model);
                            phones.Add(model);
                        }
                        break;
                }
            }
        }
    }
}
