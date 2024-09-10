using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] a = Array.ConvertAll(parts, int.Parse);
            int max = a[0];
            int min = a[0];
            // foreach(int i in a) {
            //     if(i > max) {
            //         max = i;
            //     }
            // }
            // foreach(int i in a) {
            //     if(min > i) {
            //         min = i;
            //     }
            // }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("{0} {1}", max, min);
            Console.ReadLine();
        }
    }
}