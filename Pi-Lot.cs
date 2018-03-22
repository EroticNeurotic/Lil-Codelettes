using System;

namespace Pi_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = new double();

            Console.WriteLine("Gregory-Leibniz");
            Console.WriteLine("Enter number of iterations (bigger number = bigger accuracy)");

            pi = GregoryLeibniz(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(pi);

            Console.ReadLine();
            Console.WriteLine("Abraham Sharp");
            Console.WriteLine("Iterations:");

            pi = AbrahamSharp(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(pi);

            Console.ReadKey();

        }

        static double GregoryLeibniz(int iterations)
        {
            double sum = 0;
            double divisor = new double();
            double topThing = -1;

            for(int Count = 1; Count <= iterations; Count ++)
            {
                divisor = 2 * Count - 1;
                topThing = Math.Pow(-1, Count + 1);

                sum += topThing / divisor;
            }
            return 4 * sum;
        }

        static double AbrahamSharp(int iterations)
        {
            double sum = 0;
            double OneOrMinusOne = new double();
            double ThreeToThe = new double();
            double Divisor = new double();

            for(int count = 0; count <= iterations; count ++)
            {
                OneOrMinusOne = Math.Pow(-1, count);
                ThreeToThe = Math.Pow(3, 0.5 - count);
                Divisor = 2 * count + 1;

                sum += 2 * OneOrMinusOne * ThreeToThe / Divisor;
            }
            return sum;
        }
    }
}
