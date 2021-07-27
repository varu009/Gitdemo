using System;
using System.Collections.Generic;
using System.Text;

namespace prjfirstapplication
{
    class Datatypes
    {
        void Types()
        {
            String name;
            int age;
            float salary = 67900.89f;
            Console.WriteLine("Enter the Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name:{0} && Age :{1} && Salary:{2}", name, age, salary);
        }

        void Typeconversion()
        {
            //implicit type conversion
            int num = 100;
            float petrol = num;
            double diesel = petrol;
            Console.WriteLine("implicit type conversion:{0}", diesel);
            //explicit type conversion
            int num1 = (int)diesel;
            Console.WriteLine("Exlicit type conversion:{0}",num1);
        }
        void Boxingandunboxing()
        {
            // converting value type to reference type
            //converting reference typr to value type
            int salary = 20000;//value type
            Object obj = salary;//converting int to object
            int number = (int) obj;//reference type to value type//unboxing
            Console.WriteLine("Boxing and Unboxing:{0}", number);
        }
        void NullableTypes()
        {
            //value nullable type
            //int age1 = null;
            int? age = null;

            Console.WriteLine(age??0);
            //reference nullable type
            string? city = null;
            Console.WriteLine();

        }
        static void Main()
        {
            Datatypes datatypes = new Datatypes();
            datatypes.Types();
            Console.WriteLine("-------------------");
            datatypes.Typeconversion();
            Console.WriteLine("-------------------");
            datatypes.Boxingandunboxing();
            Console.WriteLine("-------------------");
            datatypes.NullableTypes();
        }
    }
}
