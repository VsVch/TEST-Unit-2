using System;

namespace CToF
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double cap = l * h * d;
            Double tl = cap * 0.001;
            double cp = p * .01;
            double lN = tl * (1-cp);
            Console.WriteLine("{0:f3}",lN);
        }
    }
}
