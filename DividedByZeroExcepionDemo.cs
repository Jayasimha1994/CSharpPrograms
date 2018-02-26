using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DividedByZeroExcepionDemo:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "user defined exception";
            }
        }
        static void Main(string[] args)
        {
            throw new DividedByZeroExcepionDemo();
            Console.ReadKey();
        }
    }
}
