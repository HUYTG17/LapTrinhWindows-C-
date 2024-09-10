using System;

namespace Demo
{
    class Program
    {
        static void Xuat(int[] a, int n)
        {
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                    cnt++;
                    break;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine(-1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Xuat(a, n);
            Console.ReadLine();
        }
    }
}