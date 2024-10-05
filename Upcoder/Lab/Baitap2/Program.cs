/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> lst = new List<int>();
            int n = int.Parse(Console.ReadLine());
            Random rd = new Random();
            for(int i = 0; i < n; i++)
            {
                lst.Add(rd.Next(0, 100));
            }
            //for(int i = 0; i < n; i++) {
            //   Console.Write(Lst[i] + ' ');
            //}
            Console.WriteLine(string.Join(",", lst));
            Console.WriteLine("Tong = {0}", lst.Sum());
            Console.WriteLine("Min = {0}", lst.Min());
            Console.WriteLine("Max = {0}", lst.Max());
            //xuat ra so chan
            Console.WriteLine("So chan:{0}",
                string.Join(",", lst.Where(t => t % 2 == 0)));
            Console.ReadKey(); // dung man hinh*/
/*List<int> lst = new List<int>();
int n = int.Parse(Console.ReadLine());
Random rd = new Random();
for (int i = 0; i < n; i++)
{
    lst.Add(rd.Next(0, 100));
}*/
//for(int i = 0; i < n; i++) {
// Console.Write(lst[i] + ' ');
//}
/*Console.WriteLine(string.Join(",", lst));
Console.WriteLine("Tong = {0}", lst.Sum());
Console.WriteLine("Max = {0}", lst.Max());
Console.WriteLine("Min = {0}", lst.Min());

Console.WriteLine("So chan:{0}",
     string.Join(",", lst.Where(t => t % 2 == 0)));
Console.ReadKey();*/
/* int n = int.Parse(Console.ReadLine());
 List<int> lst = new List<int>();
 for (int i = 0; i < n; i++)
 {
     int x = int.Parse(Console.ReadLine());
     lst.Add(x);
 }
 Console.WriteLine(lst.Sum());
 Console.ReadKey();

}

}
}
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lst = new List<int>();
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            lst.Add(x);
        }
        //Console.WriteLine(string.Join(",", lst)); no tu chuyen thanh so da nhap vd 1,2,3,4,5
        Console.WriteLine(lst.Sum());
        Console.ReadKey();
    }
}
