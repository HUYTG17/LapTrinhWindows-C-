using System;

namespace Demo
{
    class Program
    {
        static void Xuat(float[] a, int n)
        {
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i]);
                    cnt++;
                    break;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine(1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float[] a = new float[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = float.Parse(Console.ReadLine());
            }
            Xuat(a, n);
            Console.ReadLine();
        }
    }
}