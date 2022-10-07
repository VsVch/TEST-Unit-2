using System;

namespace Cyrcle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Double area = a*b/2;
            Console.WriteLine("{0:f2}", area);
           
           
        }
    }
}
