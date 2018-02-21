using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine("SampleMethod inside SampleNamespace");
        }
    }
    namespace NestedNamespace
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                System.Console.WriteLine("SampleMethod inside NestedNamespace");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass outer = new SampleClass();
            outer.SampleMethod();

            SampleNamespace.SampleClass outer2 = new SampleNamespace.SampleClass();
            outer2.SampleMethod();

            NestedNamespace.SampleClass inner = new NestedNamespace.SampleClass();
            inner.SampleMethod();
            Console.ReadKey();
        }
    }
}