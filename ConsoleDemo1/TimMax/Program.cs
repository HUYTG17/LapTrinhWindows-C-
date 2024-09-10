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
            //for (int i = 0; i < a.Length; i++)
            //{
                //if (max < a[i])
                //{
                //    max = a[i];
                //}
                
            //}
            foreach(int i in a) {
                if(max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}