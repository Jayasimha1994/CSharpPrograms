using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EnumerableDemo
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(10); l.Add(20); l.Add(30); l.Add(40); l.Add(50); l.Add(60); l.Add(70);
            Console.WriteLine("IEnumerable");
            IEnumerable<int> e = (IEnumerable<int>)l;
            iterate(e);
            Console.Read();
        }
        static void iterate(IEnumerable<int> e)
        {
            foreach (int n in e)
            {
                Console.Write(n + ",");
                if (n > 30)
                {
                    iterate2(e);
                    break;
                }
            }
        }
        static void iterate2(IEnumerable<int> e)
        {
            Console.WriteLine("from Iterator2");
            foreach (int n in e)
            {
                Console.Write(n + ",");
            }
        }
    }
}
