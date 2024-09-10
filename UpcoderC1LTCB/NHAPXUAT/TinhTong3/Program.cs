using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a % 10 + b % 10;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}