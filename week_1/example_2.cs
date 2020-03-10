using System;

namespace example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("nhap so c = ");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.Write("day la tam giac ");
                if(a == b && a == c)
                {
                    Console.WriteLine("tam giac deu");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Can");
                    if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    {
                        Console.WriteLine(" va vuong");
                    }
                }
               else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine(" vuong");
                }
                else Console.WriteLine("tam giac thuong");
            }
            else
            {
                Console.WriteLine("khong phai tam giac");
            }
            Console.ReadLine();
        }
    }
}
