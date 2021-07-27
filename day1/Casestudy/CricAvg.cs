using System;
using System.Collections.Generic;
using System.Text;

namespace Casestudy
{
    class CricAvg
    {
        static void Main(string[] args)
        {
            int[][] c = new int[25][];
            c[0] = new int[6] { 0, 1, 2, 4, 6, 1 };
            c[1] = new int[6] { 1, 2, 4, 6, 0, 0 };
            c[2] = new int[6] { 0, 0, 0, 0, 1, 2 };
            c[3] = new int[6] { 1, 1, 1, 1, 1, 1 };
            c[4] = new int[6] { 4, 4, 4, 1, 1, 1 };
            c[5] = new int[6] { 0, 1, 2, 4, 6, 1 };
            c[6] = new int[6] { 1, 2, 4, 6, 0, 0 };
            c[7] = new int[6] { 0, 0, 0, 0, 1, 2 };
            c[8] = new int[6] { 1, 1, 1, 1, 1, 1 };
            c[9] = new int[6] { 4, 4, 4, 1, 1, 1 };
            c[10] = new int[6] { 0, 1, 2, 4, 6, 1 };
            c[11] = new int[6] { 1, 2, 4, 6, 0, 0 };
            c[12] = new int[6] { 0, 0, 0, 0, 1, 2 };
            c[13] = new int[6] { 1, 1, 1, 1, 1, 1 };
            c[14] = new int[6] { 4, 4, 4, 1, 1, 1 };
            c[15] = new int[6] { 0, 1, 2, 4, 6, 1 };
            c[16] = new int[6] { 1, 2, 4, 6, 0, 0 };
            c[17] = new int[6] { 0, 0, 0, 0, 1, 2 };
            c[18] = new int[6] { 1, 1, 1, 1, 1, 1 };
            c[19] = new int[6] { 4, 4, 4, 1, 1, 1 };
            c[20] = new int[6] { 0, 1, 2, 4, 6, 1 };
            c[21] = new int[6] { 1, 2, 4, 6, 0, 0 };
            c[22] = new int[6] { 0, 0, 0, 0, 1, 2 };
            c[23] = new int[6] { 1, 1, 1, 1, 1, 1 };
            c[24] = new int[6] { 4, 4, 4, 1, 1, 1 };


            int[] sum = new int[25];
            int result = 0;
            double rate;
            double avg;
            int m, n;
            for (m = 0; m < 25; m++)
                sum[m] = 0;
            for (m = 0; m < c.Length; m++)
            {
                for (n = 0; n < c[m].Length; n++)
                {
                    sum[m] = sum[m] + c[m][n];
                }
            }
            for (m = 0; m < 25; m++)
                result = result + sum[m];
            Console.WriteLine("The Total runs:" + result);

            rate = (double)result / 150;
            Console.WriteLine("Strike rate:" + rate);

            avg = (double)result / 5;
            Console.WriteLine("Average score of last 5 matches:" + avg);


        }

    }
}
