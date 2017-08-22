using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie etwas ein und bestätigen es mit Enter:");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Bitte bestätigen Sie die Ausgabe mit 'ja' und Enter:");
            if (Console.ReadLine().Equals("ja"))
            {
                Console.WriteLine("Deine Eingabe war:");
                Console.WriteLine(eingabe);
            } else
            {
                Console.WriteLine("Fehler: Ausgabe wurde nicht mit 'ja' bestätigt.");
            }
            Console.WriteLine("Drücken Sie eine beliebige Taste um das Programm zu verlassen.");
            Console.ReadKey();
        }
    }
}
