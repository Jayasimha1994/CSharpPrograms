using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<int> al = new List<int>();
            al.Add(10);
            al.Add(20);
            foreach (int l in al) { Console.Write(l); Console.Write(","); }
            Console.WriteLine();
            int i = al.BinarySearch(10);
            Console.WriteLine("count Method :" + al.Count());
            Console.WriteLine("constains method :" + al.Contains(20));
            Console.WriteLine("Exists method :" + al.Exists(element => element < 20));
            Console.WriteLine("Find method :" + al.Find(element => element > 10));
            al.Insert(0, 50);
            foreach (int l in al) { Console.Write(l); Console.Write(","); }
            Console.WriteLine();
            Console.WriteLine(al.Max());
            Console.WriteLine(al.Min());
            foreach (int l in al) { Console.Write(l); Console.Write(","); }
            Console.WriteLine();
            al.RemoveAt(0);
            foreach (int l in al) { Console.Write(l); Console.Write(","); }
            Console.WriteLine();
            al.Reverse();
            foreach (int l in al) { Console.Write(l); Console.Write(","); }
            Console.Read();
        }
    }
}
