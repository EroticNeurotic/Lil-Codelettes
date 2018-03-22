using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Upper = new int();
            List<int> Primes = new List<int>();

            Upper = Convert.ToInt32(Console.ReadLine());
            Primes = IntsToList(Upper);
            Primes = Sieve(Primes);

            PrintList(Primes);

            Console.ReadKey();
        }

        static List<int> IntsToList(int Upper)
        {
            List<int> Integers = new List<int>();

            for(int Count = 2; Count <= Upper; Count ++)
            {
                Integers.Add(Count);
            }

            return Integers;
        }

        static List<int> Sieve(List<int> IntList)
        {
            List<int> NewList = new List<int>(IntList);
            int Max = IntList[IntList.Count - 1];

            foreach (int Item in IntList)
            {
                if (Item > Math.Sqrt(Max))
                {
                    return NewList;
                }

                foreach (int Element in IntList)

                {
                    if (Element > Item & Element % Item == 0)
                    {
                        NewList.Remove(Element);
                    }
                }
                
            }
            return NewList;
        }

        static void PrintList(List<int> MyList)
        {
            foreach (int element in MyList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
