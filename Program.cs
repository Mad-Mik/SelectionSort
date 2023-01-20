using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 56, 1, 99, 67, 89, 6, 44, 12, 78, 34 };

            int n = 10;
            
            int temp, small;

            for (int i = 0; i < n - 1; i++)
            {
                small = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[small])
                    {
                        small = j;
                    }
                }
                temp = arr[small];
                arr[small] = arr[i];
                arr[i] = temp;
            }
            
            Console.Write("Sorted: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
