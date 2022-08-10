using System;

namespace GenericProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxIntNumbers maxintnum = new MaxIntNumbers();
            Console.WriteLine(maxintnum.NumberMax(10, 80, 10));
            Console.WriteLine("-------------------------");

            MaxFloatNumbers maxfloatnum = new MaxFloatNumbers();
            Console.WriteLine(maxfloatnum.FloatNumber(90.4f, 50.6f, 70.7f));
            Console.WriteLine("-------------------------");

            MaxString maxString = new MaxString();
            Console.WriteLine(maxString.largeString("Apple", "Peach", "Banana"));
        }
    }
}