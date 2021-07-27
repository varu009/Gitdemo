using System;
using System.Collections.Generic;
using System.Text;

namespace Casestudy
{
    class Cricket
    {
        static void Main(string[] args)
        {

            int[][] c = new int[5][];
            c[0] = new int[6] { 0, 1, 2, 4, 6, 1 };
            c[1] = new int[6] { 1, 2, 4, 6, 0, 0 };
            c[2] = new int[6] { 0, 0, 0, 0, 1, 2 };
            c[3] = new int[6] { 1, 1, 1, 1, 1, 1 };
            c[4] = new int[6] { 4, 4, 4, 1, 1, 1 };
            int[] sum = new int[5];
            int result = 0;
            double rate;
            int m, n;
            for (m = 0; m < 5; m++)
                sum[m] = 0;
            for (m = 0; m < c.Length; m++)
            {
                for (n = 0; n < c[m].Length; n++)
                {
                    sum[m] = sum[m] + c[m][n];
                }
            }
            for (m = 0; m < 5; m++)
                result = result + sum[m];
            Console.WriteLine("The Total run:" + result);

            rate = (double)result / 30;
            Console.WriteLine("Strike rate:" + rate);

        }
    }
}
