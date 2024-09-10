using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var x = 113;
            Console.WriteLine("Kiểu dữ liệu của x là {0}", x.GetType().ToString());
            var y = "Toàn";
            Console.WriteLine("Kiểu dữ liệu của y là {0}", y.GetType().ToString());
            var z = 14.9;
            Console.WriteLine("Kiểu dữ liệu của z là {0}", z.GetType().ToString());
            Console.ReadLine();
        }
    }
}
