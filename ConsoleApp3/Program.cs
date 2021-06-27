using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, m = 5;
            int[] array1 = new int[n];
            int[] array2 = new int[m];
            int[] array3 = new int[n + m];
            _Random(array1);
            _Random(array2);

            Print(array1);
            Console.Write($" + ");
            Print(array2);
            Console.Write($" = ");

            Array.Copy(array1, array3, n);
            ConCat(array3, array2);
            Print(array3);
        }

        static void _Random(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
        }

        static void Print(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write(i);
            }
        }

        static void ConCat(int[] array1, int[] array2)
        {
            for (int i = array1.Length - array2.Length; i < array1.Length; i++)
            {
                array1[i] = array2[i - (array1.Length - array2.Length)];
            }
        }
    }
}
