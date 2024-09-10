using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhepTinh2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                double b = Math.Pow(a, 1.0 / 3.0);
                Console.WriteLine(Math.Round(b, 2)); // lam tron
            }
            else
            {
                Console.WriteLine("Gia tri khong hop le");
            }
            Console.ReadLine();
        }
    }
}
