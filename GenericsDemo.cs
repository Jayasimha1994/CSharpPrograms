using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vehicle<T>
    {
        private T t;
        public void set(T t)
        {
            this.t = t;
        }
        public T get()
        {
            return this.t;
        }
    }
    class GenericsDemo
    {
        static void Main(string[] args)
        {
            Vehicle<String> v = new Vehicle<string>();
            v.set("jay");
            Console.WriteLine("string type value :"+v.get());
            Vehicle<int> v1 = new Vehicle<int>();
            v1.set(10);
            Console.WriteLine("int type value :" + v1.get());
            Console.Read();
        }
    }
}
