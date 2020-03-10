using System;

namespace example_6
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
            for (int i = 2; i * i <= n + 5; ++i)
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

        static void solving(int n)
        {
            for(int i=2; i<n+1; i++)
            {
                if (sangnguyento(i) == true)
                {
                    while(n%i == 0)
                    {
                        n /= i;
                        Console.Write(i+" ");
                    }
                  
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("nhap so n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(n + " = ");
            solving(n);
            Console.ReadKey();
        }
    }
}


