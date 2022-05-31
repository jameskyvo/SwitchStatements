using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();
            switch (favSubject)
            {
                case "English":
                Console.WriteLine("English is great, I love to read!");
                break;

                case "Math":
                    Console.WriteLine("Yikes, well at least that's one of us.");
                    break;

                case "Science":
                    Console.WriteLine("Oh cool! I watch youtube videos on science sometimes.");
                    break;

                case "History":
                    Console.WriteLine("Did you know Anders Hejlsberg created C#?");
                    break;

                case "Lunch":
                    Console.WriteLine("My favorite subject!");
                    break;

                default:
                    Console.WriteLine($"{favSubject}? Never heard of that one!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
