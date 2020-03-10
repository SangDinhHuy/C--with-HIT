using System;

namespace example_5
{
    class Program
    { 
        static bool sangnguyento(int n)
        {
            bool[] isprime = new bool[n + 5];
            for (int i = 0; i < n + 5; i++)
            { 
            isprime[i] = true;
            }
            isprime[0] = false;
            isprime[1] = false;
            for (int i = 2; i* i <= n + 5; ++i)
            {
                if (isprime[i] == true)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isprime[j] = false; 
                    }
                }
            }
            return isprime[n] == true ? true : false;
        } 
        static void Main(string[] args)
        {
            Console.Write("nhap so n = ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine(sangnguyento(n) == true ? n + " la so nguyen to" : n + " khong la so nguyen to");
            Console.ReadKey();
        }
    }
}
