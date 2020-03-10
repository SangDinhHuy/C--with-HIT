using System;

namespace example_7
{
    class Program
    {
        static float solving(int x, float c)
        {
            float sum = 1, luythua = 1, giaithua = 1, i = 1;
            while(luythua/giaithua >= c)
            {
                sum += luythua / giaithua;
                luythua *= x;
                giaithua *= i;
                i++;
            }
            return sum += luythua/giaithua;
        }
        static void Main(string[] args)
        {
            Console.Write("nhap so x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("nhap so c = ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("e^ {0} = ", x);
            Console.WriteLine(solving(x, c));
            Console.ReadKey();
        }
    }
}
