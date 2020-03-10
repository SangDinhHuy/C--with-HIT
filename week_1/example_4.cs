using System;

namespace example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n = ");
            int n = int.Parse(Console.ReadLine());
            int s1 = 0, s2 = 1, s3 = 0, i = 1;
            while (i < n + 1)
            {
                s1 += i;
                s2 *= i;
                s3 += (i - 1) * i;
                i++;
            }
            Console.WriteLine("s1 = {0}, s2 = {1}, s3 = {2} " , s1, s2, s3);
            Console.ReadLine();
        }
    }
}

