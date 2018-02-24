using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ComparerDemo
    {
        int id;
        string name;
        ComparerDemo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        class Mycom : IComparer
        {
            int IComparer.Compare(object obj, object obj1)
            {
                ComparerDemo p = (ComparerDemo)obj;
                ComparerDemo p1 = (ComparerDemo)obj1;
                return String.Compare(p.name, p1.name);
            }
        }
        //public static IComparer CallCompare()
        //{
        //    return (IComparer)new Mycom();
        //}
        static void Main(string[] args)
        {
            ComparerDemo[] p = { new ComparerDemo(1, "seshu"),
            new ComparerDemo(2, "kavi"),
            new ComparerDemo(3, "jay") };
            Console.WriteLine("before sorting");
            foreach (ComparerDemo p1 in p)
            {
                Console.WriteLine(p1.id + "--" + p1.name);
            }
            Array.Sort(p, new Mycom());
            Console.WriteLine("after sorting");
            foreach (ComparerDemo p1 in p)
            {
                Console.WriteLine(p1.id + "--" + p1.name);
            }
            Console.Read();
        }
    }
}
