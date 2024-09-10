using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen = Console.ReadLine();
            float diemToan = float.Parse(Console.ReadLine());
            float diemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Học sinh tên {0} có điểm toán là {1} có điểm văn là {2}", hoTen, diemToan, diemVan);
            Console.ReadLine();
        }
    }
}
