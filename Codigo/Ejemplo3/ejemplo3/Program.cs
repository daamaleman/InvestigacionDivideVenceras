using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long result = Power(2, 10);
            Console.WriteLine(result);

            // Evitar que la consola se cierre inmediatamente
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }

        public static long Power(long x, int n)
        {
            if (n == 0)
            {
                return 1; // Caso base
            }
            long half = Power(x, n / 2);

            if (n % 2 == 0)
            {
                return half * half; // Caso par
            }
            else
            {
                return x * half * half; // Caso impar
            }
        }

    }
}
