using System;
using System.Collections.Generic;
using System.Text;

namespace Casestudy
{
    class Electricity
    {
        static void Main(string[] args)
        {
            double p, u;

            Console.WriteLine("Enter the numbers of units");
            u = Convert.ToInt32(Console.ReadLine());

            if (u < 100)
            {

                p = u * 1.20;
                Console.WriteLine("Standard price is:" + p);

            }
            else if (u <= 300)
            {
                p = (100 * 1.20) + ((u - 100) * 2);
                Console.WriteLine("Standard price is:" + p);

            }
            else
            {
                p = (100 * 1.20) + (200 * 2) + ((u - 300) * 3);
                Console.WriteLine("Standard price is:" + p);

            }
        }
    }
}
