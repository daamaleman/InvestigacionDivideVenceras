using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 11 };
            int target = 7;

            int result = BinarySearch(array, target);
            if (result != -1)
            {
                Console.WriteLine($"Elemento encontrado en el índice: {result}");
            }
            else
            {
                Console.WriteLine("Elemento no encontrado.");
            }

            // Espera a que el usuario presione Enter antes de cerrar la consola
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                {
                    return mid; // Elemento encontrado
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; // Buscar en la mitad derecha
                }
                else
                {
                    right = mid - 1; // Buscar en la mitad izquierda
                }
            }

            return -1; // Elemento no encontrado
        }
    }
}
