using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2,2,2] { { { 1, 2 }, { 2, 3 } }, { { 1, 2 }, { 2, 3 } } };
            int bound1 = arr.GetUpperBound(0);
            int bound2 = arr.GetUpperBound(1);
            int bound3 = arr.GetUpperBound(2);
            for(int i=0;i<=bound1;i++)
            {
                for(int j=0;j<=bound2;j++)
                {
                    for (int k = 0; k <= bound3; k++)
                    {
                        Console.WriteLine("array elements :" + arr[i, j, k]);
                    }
                }
            }
            Console.Read();
        }
    }
}
