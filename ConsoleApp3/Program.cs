using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++) Console.Write(i);

                    Console.WriteLine();
                }
            }
        }
    }
}