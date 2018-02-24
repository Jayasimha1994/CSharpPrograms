using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EnumeratorDemo
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(10); l.Add(20); l.Add(30); l.Add(40); l.Add(50); l.Add(60); l.Add(70);
            IEnumerator<int> e = l.GetEnumerator();
            iterate(e);
            Console.Read();
        }
        static void iterate(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                Console.Write(e.Current.ToString() + ",");
                if (Convert.ToInt32(e.Current) > 30)
                {
                    Console.WriteLine();
                    iterate2(e);
                }
            }
        }
        static void iterate2(IEnumerator<int> e)
        {
            Console.WriteLine("from Iterator2");
            while (e.MoveNext())
            {
                Console.Write(e.Current.ToString() + ",");
            }
        }
    }
}
