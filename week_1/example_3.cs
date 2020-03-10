using System;

namespace example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("uoc cua " + n + " la : ");
            for(int i=1; i<n+1; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
