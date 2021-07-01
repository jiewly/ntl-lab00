using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    public class Register
    {
        //property
        private string Id = "";
        private string Name = "";

        //contrucor
        public Register(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //method return string
        public string PrintId()
        {
            return this.Id;
        }

        public string PrintName()
        {
            return this.Name;
        }

        //method
        public void ShowMessage()
        {
            Console.WriteLine("register Success : "+Id + " "+Name);
        }
    }
}
