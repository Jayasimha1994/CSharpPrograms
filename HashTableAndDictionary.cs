using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HashTableAndDictionary
    {

        static void Main(string[] args)
        {
            Hashtable numbers = new Hashtable();
            numbers.Add(1, "one");
            numbers.Add(2, "two");
            numbers.Add(3, "three");
            numbers.Add(4, "four");
            numbers.Add(5, "five");
            foreach (DictionaryEntry num in numbers)
            {
                Console.WriteLine(num.Key + "   -   " + num.Value);
            }
            Console.WriteLine("Dictionary elements");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine(pair.Key + "   -   " + pair.Value);
            }
            Console.Read();
        }
    }
}
