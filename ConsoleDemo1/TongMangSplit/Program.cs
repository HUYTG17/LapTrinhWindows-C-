using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongMangSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                string input = Console.ReadLine();
                string[] divide = input.Split(' ');
                int[] a = Array.ConvertAll(divide, int.Parse);
                int sum = 0;
                foreach (int i in a)
                {
                    sum += i;
                }
                Console.WriteLine("Tong gia tri cua mang la: " + sum);
            }
            else
            {
                Console.WriteLine("Khong hop le");
            }
            Console.ReadLine();
        }
    }
}
