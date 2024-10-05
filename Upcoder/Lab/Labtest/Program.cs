using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region BTLAB
            BTLAB();
            // #endregion

        }

        private static void BTLAB()
        {
            int demsai = 3;
            double a = 0;
        input_a:
            Console.Write("Nhap tham so a:");
            if(!double.TryParse(Console.ReadLine(), out a))
            {
                demsai--;
                Console.WriteLine("Nhap sai du lieu");
                if (demsai == 0) return;
                goto input_a;
            }
            //Console.Write("Nhap vao tham so c:");
            //double c = double.Parse(Console.ReadLine());
            int demsai1 = 4;
            double b = 0;
            do
            {
                
                Console.Write("Nhap tham so b:");
                demsai1--;
                Console.WriteLine("Nhap sai du lieu:");
                if (demsai1 == 0) return;
            

            } while (!double.TryParse(Console.ReadLine(), out b));
            //Console.Write("Nhap vao tham so b:");
            //double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)

                    Console.WriteLine("Phuong trinh vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double x = (-b / a);
                Console.WriteLine("Phuong trinh co nghiem x= " + x);
                Console.WriteLine("Phuong trinh co nghiem x=" + x.ToString());
                Console.WriteLine("Phuong trinh co nghiem x= {0:0.00}", x);
            }
            Console.ReadKey();
        }
    }
}
