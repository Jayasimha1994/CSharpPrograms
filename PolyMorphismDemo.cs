using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Parent1
    {
        public void Profession()
        {
            Console.WriteLine("Teacher");
        }
    }
    class Child:Parent1
    {
        public void Profession()
        {
            Console.WriteLine("Software");
        }
        public void Profession(String jobName)
        {
            Console.WriteLine("Testing");
        }
    }
    class PolyMorphismDemo
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Profession();
            child.Profession("parttime");
            Console.Read();
        }
    }
}