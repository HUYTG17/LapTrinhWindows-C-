using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhepTinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
                float a;
                if (float.TryParse(Console.ReadLine(), out a))
                {
                //Console.WriteLine(a + 3);
                //Console.WriteLine(Math.Pow(a, 3));
                // Console.WriteLine(Math.Pow(a, 1.0 / 3.0)); // can nay ko xai sqrt(n) duoc phai xai a mu 1/n
                //Console.WriteLine(Math.Sqrt(a));
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le");
                }
                Console.ReadLine();
            }
        }
    }


