using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 3, 5, 1, 8, 7, 2, 6, 4 };
            var (min, max) = FindMinMax(array, 0, array.Length - 1);
            Console.WriteLine($"El mínimo es: {min}");
            Console.WriteLine($"El máximo es: {max}");
            Console.ReadLine(); // Mantiene la consola abierta hasta que se presione Enter
        }
        
            public static (int, int) FindMinMax(int[] array, int left, int right)
            {
                if (left == right)
                {
                    return (array[left], array[left]); // Un solo elemento
                }
                else if (left + 1 == right)
                {
                    // Dos elementos
                    if (array[left] < array[right])
                    {
                        return (array[left], array[right]);
                    }
                    else
                    {
                        return (array[right], array[left]);
                    }
                }

                int mid = (left + right) / 2;
                var (minLeft, maxLeft) = FindMinMax(array, left, mid);
                var (minRight, maxRight) = FindMinMax(array, mid + 1, right);

                return (Math.Min(minLeft, minRight), Math.Max(maxLeft, maxRight));
            }
        
    }
}
