using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
        {
            "Borderlands",
            "Assassin's Creed",
            "Spyro",
            "Halo",
            "Call of Duty",
            "Kingdom Hearts",
            "World of Warcraft",
            "The Elder Scrolls",
            "Donkey Kong"
        };

            var orderedList = videoGames.OrderBy(x => x.Length).ToList();

            for (int i=0; i < orderedList.Count; i++)
            {
                Console.WriteLine($"{orderedList[i]}");
            }
            Console.ReadLine();
        }
    }
}

