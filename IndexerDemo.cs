using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        private string[] data = new string[5];
        public string this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
    class IndexerDemo
    {
        public static void Main()
        {
            MyClass mc = new MyClass();
            mc[0] = "Jayasimha";
            mc[1] = "Kr puram";
            mc[2] = "bangalore";
            mc[3] = "KA";
            mc[4] = "560036";
            Console.WriteLine("{0},{1},{2},{3},{4}", mc[0], mc[1], mc[2], mc[3], mc[4]);
            Console.Read();
        }
    }
}
