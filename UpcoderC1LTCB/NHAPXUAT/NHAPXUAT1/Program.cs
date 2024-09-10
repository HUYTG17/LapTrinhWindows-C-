using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a % 10);
            Console.WriteLine(a / 100);
            Console.Write(a / 10 % 10); // or (a % 100) / 10
            Console.ReadLine();
        }
    }
}