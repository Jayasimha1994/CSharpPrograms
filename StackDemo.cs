using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (object o in stk)
            {
                Console.WriteLine(o);
            }
            Console.Read();
        }
    }
}
