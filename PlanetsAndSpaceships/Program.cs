using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");


            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            var rockyPlanets = planetList.GetRange(0,4);

            Console.WriteLine("These are the planets in our solar system that have rocky terrains :");

            foreach (var rock in rockyPlanets)
            {
                Console.WriteLine(rock);
            }

            Console.WriteLine("oh some jerk thought that Pluto wasn't important enough to be a real planet. Its not a dward planet. Lets take it out i guess..");

            planetList.Remove("Pluto");

            Console.WriteLine("Here is our updated list of planets in our Solar System");

            foreach (var updatedPlanet in planetList)
            {
                Console.WriteLine(updatedPlanet);
            }

            var probe = new Dictionary<string, List<string>>
            {
                {
                    "Viking",
                    new List<string> {"Earth", "Mars", "Venus"}
                },
                {
                    "Opportunity",
                    new List<string> {"Earth", "Jupiter", "Venus"}
                },
                {
                    "Curiosity",
                    new List<string> { "Earth", "Saturn", "Uranus" }
                },
                {
                    "Mariner",
                    new List<string> {"Earth", "Mars", "Mercury"}
                },
                {
                    "Messenger",
                    new List<string> {"Earth", "Jupiter", "Neptune"}
                },
                {
                    "Venera",
                    new List<string> {"Earth", "Jupiter", "Neptune"}
                },
                {
                    "Maven",
                    new List<string> {"Earth", "Venus", "Saturn"}
                },
                {
                    "Pioneer",
                    new List<string> {"Earth", "Saturn", "Jupiter"}
                },
                {
                    "Juno",
                    new List<string> {"Eath", "Mars", "Neptune"}
                }
            };

            foreach (var planet in planetList)
            {
                var spaceProbes = probe
                    .Where(probe => probe.Value.Contains(planet))
                    .Select(probe => probe.Key);

                Console.WriteLine($"{planet}: {String.Join(", ", spaceProbes)}");
            }

        }
    }
}
