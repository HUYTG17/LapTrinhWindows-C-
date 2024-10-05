using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Moi ban nhap ten:");
             string hoten = Console.ReadLine();
             // nhap namsinh -> kem tinh tuoi
             int namsinh = Convert.ToInt32(Console.ReadLine());
             //int.Parse(Console.ReadLIne());
             int tuoi = DateTime.Now.Year - namsinh; // DateTime.Now.Year //DateTime.Now.Month //Date.Time.Day

             Console.WriteLine("Xin chao ban " + hoten  + " " + tuoi + " tuoi");
             Console.WriteLine("Xin chao ban {0} {1} tuoi", hoten, tuoi);
             Console.ReadKey();
        }
    }
}
