using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Parent
    {
        internal int UserId = 101;
        internal string Password = "jay";
        public void Display()
        {
            Console.WriteLine("Parent Properties");
            Console.WriteLine(UserId);
            Console.WriteLine(Password);
        }
    }
    class InheritanceDemo:Parent
    {
        static void Main(string[] args)
        {
            InheritanceDemo inherit = new InheritanceDemo();
            inherit.Display();
            Console.Read();
        }
    }
}
