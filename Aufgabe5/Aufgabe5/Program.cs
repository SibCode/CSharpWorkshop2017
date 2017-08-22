using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Char symbolAussen = 'X';
            Char symbolInnen = '0';
            Console.WriteLine("Dieses Programm gibt ein Rechteck mit " + symbolInnen + "-Zeichen innen und "+symbolAussen+"-Zeichen aussen aus.");
            Console.WriteLine("Bitte geben Sie die gewünschte Höhe in Zeilen an und bestätigen Sie mit Enter:");
            int hoehe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die gewünschte Länge in Zeichen an und bestätigen Sie mit Enter:");
            int breite = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < hoehe; x++)
            {
                for (int y = 0; y < breite; y++)
                {
                    if ((y == 0 || y == (breite - 1)) || (x == 0 || x == (hoehe -1)))
                    {
                        Console.Write(symbolAussen);
                    } else
                    {
                        Console.Write(symbolInnen);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Verlassen Sie das Programm durch drücken einer beliebigen Taste.");
            Console.ReadKey();
        }
    }
}
