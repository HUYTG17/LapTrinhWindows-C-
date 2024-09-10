using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a > 0)
            {
                sum = sum * 10 + a % 10;
                a /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}