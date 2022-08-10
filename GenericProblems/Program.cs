namespace GenericProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxIntNumbers maxintnum = new MaxIntNumbers();
            Console.WriteLine(maxintnum.NumberMax(10, 80, 10));
        }
    }
}