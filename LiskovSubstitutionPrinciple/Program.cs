using System;

namespace LiskovSubstitutionPrinciple
{

    class Program
    {
        static void Main(string[] args)
        {
            var rb = new RectangleBefore(2, 3);
            Console.WriteLine($"{rb} has area {rb.Area()}");
            var sb = new SquareBefore();
            sb.Width = 2;
            Console.WriteLine($"{sb} has area {sb.Area()}");

            var ra = new RectangleAfter(2, 3);
            Console.WriteLine($"{rb} has area {rb.Area()}");
            var sa = new SquareAfter();
            sb.Width = 2;
            Console.WriteLine($"{sb} has area {sb.Area()}");

        }
    }
}
