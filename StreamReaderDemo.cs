using System;
using System.IO;

namespace ConsoleApp1
{
    class StreamReaderDemo
    {
        public static void Main()
        {
            string path = @"F:\abc.txt";
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.Read();
        }
    }
}
