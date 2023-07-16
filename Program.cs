using System;

namespace LineComparisionComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, Welcome to Line Comparison Computation Program");
            LineComparison lineComparison = new LineComparison();
            lineComparison.CalculateLineLength();
        }
    }
}