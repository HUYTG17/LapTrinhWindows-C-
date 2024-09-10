using System;

namespace Demo
{
    class Program
    {
        static void LietKe(int[] a, int n)
        {
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.Write(-1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] a = Array.ConvertAll(parts, int.Parse);
            LietKe(a, n);
            Console.ReadLine();
        }
    }
}