using System;

namespace Baomax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] a = Array.ConvertAll(parts, int.Parse);
            int index = 0;
            int min = a[0]; // phai dung n khhi da khai bao
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}