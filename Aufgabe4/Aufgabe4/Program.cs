using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Char symbol = 'X';
            Console.WriteLine("Dieses Programm gibt ein Rechteck mit "+symbol+"-Zeichen aus.");
            Console.WriteLine("Bitte geben Sie die gewünschte Höhe in Zeilen an und bestätigen Sie mit Enter:");
            int hoehe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die gewünschte Länge in Zeichen an und bestätigen Sie mit Enter:");
            int breite = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < hoehe; x++)
            {
                for (int y = 0; y < breite; y++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Verlassen Sie das Programm durch drücken einer beliebigen Taste.");
            Console.ReadKey();
        }
    }
}
