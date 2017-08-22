using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechteckMitEingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] rechteck = new char[4, 3];

            RechteckFuellen(rechteck);
            RechteckInhaltAendern(rechteck);
            RechteckAusgeben(rechteck);
            Console.ReadKey();
        }

        static void RechteckFuellen(char[,] rechteck)
        {
            for (int zeile = 0; zeile < rechteck.GetLength(0); zeile++)
            {
                for (int spalte = 0; spalte < rechteck.GetLength(1); spalte++)
                {
                    rechteck[zeile, spalte] = '+';
                }
            }
        }

        static void RechteckInhaltAendern(char[,] rechteck)
        {
            char[] eingabe;
            Console.WriteLine("Möchtest du Zeichen im Rechteck Ändern? (J/N)");
            String abfrage = Console.ReadLine().ToUpper();
            while (abfrage.Equals("J"))
            {
                Console.WriteLine("Welches Zeichen willst du ersetzen.\nGib Position und das Zeichen das du einfügen willst an.\n(01#)");
                abfrage = Console.ReadLine();
                eingabe = abfrage.ToCharArray();
                rechteck[(int)Char.GetNumericValue(eingabe[0]), (int)Char.GetNumericValue(eingabe[1])] = eingabe[2];
                Console.WriteLine("Möchtest du Zeichen im Rechteck Ändern? (J/N)");
                abfrage = Console.ReadLine().ToUpper();
            }
        }

        static void RechteckAusgeben(char[,] rechteck)
        {
            for (int zeile = 0; zeile < rechteck.GetLength(0); zeile++)
            {
                for (int spalte = 0; spalte < rechteck.GetLength(1); spalte++)
                {
                    Console.Write(rechteck[zeile, spalte]);
                }
                Console.WriteLine();
            }
        }
    }
}
