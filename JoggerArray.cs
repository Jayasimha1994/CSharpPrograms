using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class JoggerArray
    {
        static void Main(string[] args)
        {
            int[][,] i = new int[2][,];
            Console.WriteLine("Jogger Array:");
            i[0] = new int[2, 2] { { 2, 3 }, { 2, 3 } };
            i[1] = new int[2, 3] { { 2, 5, 5 }, { 2, 3, 2 } };
            Console.WriteLine(i[0][0, 1]);
            Console.WriteLine(i[1][1,0]);
            Console.Read();
        }
    }
}
