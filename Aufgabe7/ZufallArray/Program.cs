using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufallArray
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            ZeichneRechteck(3, 4);
            Console.ReadKey();
        }

        static void ZeichneRechteck(int breite, int hoehe)
        {
            for (int y = 0; y < hoehe; y++)
            {
                for(int x = 0; x < breite; x++)
                {
                    Console.Write(WaehleZeichen());                    
                }
                Console.WriteLine();
            }
        }

        static char WaehleZeichen()
        {
            Char[] zeichen = { '+', 'x', '*', '0', 'o', '#', '@' };
            int index = GeneriereZufallszahlZwischen(0, zeichen.Length);

            return zeichen[index];
        }

        static int GeneriereZufallszahlZwischen(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
