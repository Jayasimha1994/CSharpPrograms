using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "jay");
            d.Add(2, "kavi");
            d.Add(3, "mani");
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine(kvp.Key + "--------" + kvp.Value);
            }
            Console.Read();
        }
    }
}
