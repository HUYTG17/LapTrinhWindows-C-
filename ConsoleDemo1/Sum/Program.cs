using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int a, b;
            if(parts.Length == 2 &&
                int.TryParse(parts[0], out a) &&
                int.TryParse(parts[1], out b))
            {
                //int sum = a + b;
                Console.Write(a + b);
            } else
            {
                Console.Write("Giá trị không hợp lệ hoặc số lương không đúng");
            }
            Console.ReadLine();
        }
    }
}
