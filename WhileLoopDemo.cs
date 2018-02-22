using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class WhileLoopDemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("while loop");
            while (i < 5)
            {
                Console.WriteLine("while loop iteration: " + i);
                i++;
            }
            Console.WriteLine("do-while loop");
            do
            {
                Console.WriteLine("do-while iteration: " + i);
                i++;
            }
            while (i < 10);
            Console.Read();
        }
    }
}
