using System;

namespace Demo
{
    class Program
    {
        static void Xuat(int[] a, int n)
        {
            int min = 99999;
            int pos = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0 && min > a[i])
                {
                    min = a[i];
                    pos = i;
                }
            }
            Console.WriteLine(pos);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] a = Array.ConvertAll(parts, int.Parse);
            Xuat(a, n);
            Console.ReadLine();
        }
    }
}