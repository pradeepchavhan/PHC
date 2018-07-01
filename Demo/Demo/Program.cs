using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is new change: ");
            Console.WriteLine("Please Enter First No: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second No: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Format("Additon of 2 no is:{0}",a+b));
            //Console.ReadLine();
        }
    }
}
