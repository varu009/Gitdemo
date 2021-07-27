using System;
using System.Collections.Generic;
using System.Text;

namespace prjfirstapplication
{
    class Array_Static
    {
        static void Main()
        {
            Arrayeg arrayeg = new Arrayeg();
            arrayeg.Getfruits();

            Stringeg stringeg = new Stringeg();
            stringeg.StringFunctioneg();
        }
       
    class Arrayeg
    {
            //single dimention array
            //datatypr[] arrayname=new datatypr[size];
            string[] fruits = new string[3];
            int[] mark = { 89, 90, 78 };
            internal void Getfruits()
            {
                for (int i = 0; i < fruits.Length; i++)
                {
                    Console.WriteLine("enter the fruit name:");
                    fruits[i] = Console.ReadLine();
                }
                //foreach(string fu in fruits
                //implicity typed variable
                foreach (var fu in fruits)
                {
                    Console.WriteLine("fruit name :{0}", fu);
                }
            }
        }
        class Stringeg
        {
            internal void StringFunctioneg()
            {
                string Firstname = "sai";
                string Name = "Varad";
                Console.WriteLine("TO UPPER:{0}", Firstname.ToUpper());
                Console.WriteLine("TO lower:{0}", Firstname.ToLower());
                Console.WriteLine("Length:{0}", Name.Length);
                bool iscontains = Name.Contains("UP");
                Console.WriteLine("Contains UP:{0}", iscontains);
                Console.WriteLine("Substring:{0}", Name.Substring(3, 5));
            }
        }
    }

}
