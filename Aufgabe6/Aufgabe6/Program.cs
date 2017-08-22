using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm zeichnet von Ihnen definierte Rechtecke.");
            bool nichtBeendet = true;
            do
            {
                Console.Write("Bitte geben Sie das äussere Zeichen an, mit welchem gezeichnet wird: ");
                Char symbolAussen = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Bitte geben Sie das innere Zeichen an, mit welchem gezeichnet wird: ");
                Char symbolInnen =  Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine("Dieses Programm gibt ein Rechteck mit " + symbolInnen + "-Zeichen innen und " + symbolAussen + "-Zeichen aussen aus.");
                Console.WriteLine("Bitte geben Sie die gewünschte Höhe in Zeilen an und bestätigen Sie mit Enter:");
                int hoehe = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die gewünschte Länge in Zeichen an und bestätigen Sie mit Enter:");
                int breite = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ihr Rechteck aus "+symbolAussen+"- und "+symbolInnen+"-Zeichen mit Höhe "+hoehe+" und Breite "+breite+":");
                Console.WriteLine();
                for (int x = 0; x < hoehe; x++)
                {
                    for (int y = 0; y < breite; y++)
                    {
                        if ((y == 0 || y == (breite - 1)) || (x == 0 || x == (hoehe - 1)))
                        {
                            Console.Write(symbolAussen);
                        }
                        else
                        {
                            Console.Write(symbolInnen);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Beenden durch Eingabe von 'exit' und Bestätigung mit Enter: ");
                nichtBeendet = !Console.ReadLine().Equals("exit");
            } while (nichtBeendet);
        }
    }
}
