using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie etwas ein und bestätigen Sie mit Enter:");
            Console.WriteLine(Console.ReadLine());
            // OR
            Console.WriteLine("Geben Sie etwas ein und bestätigen Sie mit Enter:");
            string eingabe = Console.ReadLine();
            Console.WriteLine(eingabe);
            Console.WriteLine("Drücken Sie eine beliebige Taste um das Programm zu beenden.");
            Console.ReadKey();
        }
    }
}
