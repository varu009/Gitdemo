using System;
using System.Collections.Generic;
using System.Text;

namespace Casestudy
{
    class Constandreadonly
    {
        int box = 20;
        const int square = 10;

        const int a = square + 20;
        readonly float pi = 3.14f;
        internal Constandreadonly()
        {
            pi = 3.00f;//read only are run time constant
           // square = 90;//constants are compile time constants

        }
        internal void Analyse()
        {
            box = 40;
            //constant variable
            //square = 70;//constant variable cant be changed
            //a = square + square; //erroe
        }
        //named parameter and optional parameter
        public static int Calculation(int a,int b=90)
        {
            return a + b;
        }
    }
    class Sample
    {
        static void Main()
        {
        Constandreadonly.Calculation(3);
        }
    }
}
