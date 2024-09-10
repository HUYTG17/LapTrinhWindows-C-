using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            int c = a / 10 % 10;
            Console.WriteLine(b + c);
            Console.ReadLine();
        }
    }
}