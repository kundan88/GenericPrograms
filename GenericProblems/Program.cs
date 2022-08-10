namespace GenericProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxFloatNumbers maxintnum = new MaxFloatNumbers();
            Console.WriteLine(maxintnum.FloatNumber(10.5f, 80.6f, 10.5f));
        }
    }
}