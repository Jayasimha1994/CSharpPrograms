using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("biz");
            al.Add(42);
            foreach (object l in al)
            {
                Console.WriteLine(l);
            }
            Console.Read();
        }
    }
}
