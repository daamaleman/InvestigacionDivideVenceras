using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 8, 4, 2 };
            Console.WriteLine("Array original: " + string.Join(", ", array));

            BubbleSort(array);

            Console.WriteLine("Array ordenado: " + string.Join(", ", array));

            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadLine();
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;

            // Recorrer el array
            for (int i = 0; i < n - 1; i++)
            {
                // Comparar y ordenar elementos
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Intercambiar si están en el orden incorrecto
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


    }
}
