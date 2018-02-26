using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class BinaryWriterDemo
    {
        static void Main(string[] args)
        {
            BinaryWriter b = new BinaryWriter(File.Open("F:\\abc.txt", FileMode.OpenOrCreate));
            b.Write("biz");
            b.Write("@");
            b.Write("123");
            b.Write(".com");
            b.Flush();
            b.Close();
            Console.Read();
        }
    }
}
