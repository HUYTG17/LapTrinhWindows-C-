using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int sum = a + b;
            Console.WriteLine("{0}+{1}={2}", a, b, sum);
            Console.ReadLine();
        }
    }
}