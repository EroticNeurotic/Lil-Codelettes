using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int mynum = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            if(mynum <= 1)
            {
                Console.WriteLine("wrong");
                mynum = random.Next(2, 7230);
                Console.WriteLine("New number: " + mynum);
                Console.ReadKey();
            }

            int iterator = 0;

            do
            {
                if (mynum % 2 == 0)
                { mynum = mynum / 2; }
                else { mynum = mynum * 3 + 1; }
                iterator += 1;

                Console.WriteLine(mynum);

            } while (mynum != 1);

            Console.WriteLine("Number of steps: " + iterator);
            Console.ReadKey();

        }
    }
}
