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

            //Console.Write("Please Enter your ID : ");
            //var number = Console.ReadLine();

            //Console.Write("Please Enter your Name : ");
            //var name = Console.ReadLine();

            //Console.Write("Register Complete:");
            //Console.WriteLine(number + " " + name);

            //Console.ReadLine();

            var reg1 = new Register("11316684","Gaitong Phansanit");
            var id = reg1.PrintId();
            var name = reg1.PrintName();

            Console.WriteLine("Your Id : " + id);
            Console.WriteLine("Your Name : " + name);
            reg1.ShowMessage();
        }
    }
}
