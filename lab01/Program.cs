using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******REGISTER*******");

            Console.Write("Please Enter your ID : ");
            var number = Console.ReadLine();

            Console.Write("Please Enter your Name : ");
            var name = Console.ReadLine();

            Console.Write("Register Complete:");
            Console.WriteLine(number + " " + name);

            Console.ReadLine();
        }
    }
}
