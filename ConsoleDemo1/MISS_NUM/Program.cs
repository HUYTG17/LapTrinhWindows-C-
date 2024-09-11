using System;

namespace Demo
{
    class Program
    {
        static void Miss_Num(int[] a, int n)
        {
            int total = n * (n + 1) / 2;
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            int missNum = total - sum;
            Console.WriteLine(missNum);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] a = Array.ConvertAll(parts, int.Parse);
            Miss_Num(a, n);
            Console.ReadLine();
        }
    }
}