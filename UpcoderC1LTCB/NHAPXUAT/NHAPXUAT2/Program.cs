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
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("{0} {1}", a, b);
            Console.ReadLine();
        }
    }
}