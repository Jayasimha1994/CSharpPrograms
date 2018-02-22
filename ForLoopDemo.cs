using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ForLoopDemo
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40 };
            Console.WriteLine("for loop");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("For Loop Iteration number: " + i);
            }
            Console.WriteLine("forEach loop");
            foreach(int i in arr)
            {
                Console.WriteLine("ForEach Iteration value: " + i);
            }
            Console.Read();
        }
    }
}
