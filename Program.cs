using System;

namespace LineComparisionComputation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello User - Welcome to Line Comparision Computation");


            Console.WriteLine("Please enter X-Coordinate of First EndPoint: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter Y-Coordinate of First EndPoint: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter X-Coordinate of Second EndPoint: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter Y-Coordinate of Second EndPoint: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double coordinatex = x2 - x1;
            double coordinatey = y2 - y1;

            double length = Math.Sqrt((coordinatex * coordinatex) + (coordinatey * coordinatey));
            Console.WriteLine("The Length Of Line Is: " + length);
        }
    }
}