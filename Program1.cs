using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parent
    {
        public int i = 10;
        public void Job()
        {
            Console.Write("teacher");
        }
    }
    class Child:Parent
    {
        public int i = 20;
        public void Job()
        {
            Console.Write("software");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine("enter the child value");
            child.i = Convert.ToInt32(Console.Read());
            Console.WriteLine(child.i);
            child.Job();
            Console.ReadKey();
        }
    }
}
