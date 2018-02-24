using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class car : IComparable
    {
        private class sortYearAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                car c1 = (car)a;
                car c2 = (car)b;
                if (c1.year > c2.year)
                    return 1;
                if (c1.year < c2.year)
                    return -1;
                else
                    return 0;
            }
        }
        private int year;
        private string make;
        public car(string Make, int Year) 
        {
            make = Make;
            year = Year;
        }
        public int Year
        {
            get { return year; }
            set { year=value; }
        }
        public string Make
        {
            get { return make; }
            set { Make = value; }
        }
        int IComparable.CompareTo(object obj)
        {
            car c = (car)obj;
            return String.Compare(this.make, c.make);
        }
        public static IComparer sortYearAscending()
        {
            return (IComparer)new sortYearAscendingHelper();
        }
        static void Main(string[] args)
        {
            car[] Arr = new car[6]
            {
            new car("Ford",1992),
            new car("Fiat",1988),
            new car("Buick",1932),
            new car("Ford",1932),
            new car("Dodge",1999),
            new car("Honda",1977)
            };
            Console.WriteLine("Array - Unsorted\n");
            foreach (car c in Arr)
                Console.WriteLine(c.Make + "\t\t" + c.Year);
            Array.Sort(Arr);
            Console.WriteLine("\nArray - Sorted by Make (Ascending - IComparable)\n");
            foreach (car c in Arr)
                Console.WriteLine(c.Make + "\t\t" + c.Year);
            Array.Sort(Arr, car.sortYearAscending());
            Console.WriteLine("\nArray - Sorted by Year (Ascending - IComparer)\n");
            foreach (car c in Arr)
                Console.WriteLine(c.Make + "\t\t" + c.Year);
            Console.ReadLine();
        }
    }
}
