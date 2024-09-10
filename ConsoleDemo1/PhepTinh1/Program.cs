using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhepTinh1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            float a, b;
            if (parts.Length == 2 &&
            float.TryParse(parts[0], out a) &&
            float.TryParse(parts[1], out b))
            {
                Console.WriteLine(Math.Pow(b, 1.0 / a)); // can a cua b
            }
            else
            {
                Console.WriteLine("Gia tri khong hop le");
            }
            Console.ReadLine();
        }
    }
}
