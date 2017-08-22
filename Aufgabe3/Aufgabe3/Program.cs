using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie etwas ein und bestätigen Sie mit Enter:");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Wie oft soll die Eingabe wiederholt werden?");
            int anzahlWiederholungen = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < anzahlWiederholungen; i++)
            {
                Console.WriteLine(eingabe);
            }
            Console.WriteLine("Verlassen Sie das Programm durch drücken einer beliebigen Taste.");
            Console.ReadKey();
        }
    }
}
