using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] rechteck = new char[4, 3];

            RechteckFuellen(rechteck);
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
