using System;

namespace example_1
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
            Console.Write("nhap so d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("nhap so e = ");
            int e = int.Parse(Console.ReadLine());

            int[] arr = new int[5];
            arr[0] = a; arr[1] = b; arr[2] = c;arr[3] = d;arr[4] = e;
            Array.Sort<int>(arr);
            Console.WriteLine(arr[3]);
            Console.ReadLine();
        }
    }
}
