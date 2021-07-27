using System;
using System.Collections.Generic;
using System.Text;

namespace prjfirstapplication
{
    class Organization
    {
        internal static string Orgname = "LTI";//static
        String City = "Chennai";//non static
        internal static void Getorgdetails()
        {
            int value = 90;
            Console.WriteLine(Orgname);
            //Console.WriteLine(city);
        }
    }

    class Employee
    {
        //property
        int Eid { get; set; }
        string? Empname { get; set; }
        string? Location { get; set; }
        int Salary { get; set; }

        int Did { get; }//read only property
        //constructor
        Employee()
        {
            Did = 101;
        }
        //constructor overloading
        Employee(int Eid,string Empname,string Location, int sal)
        {
            //this represents current class instance(employee) variable
            this.Eid = Eid;
            this.Empname = Empname;
            this.Location = Location;
            Salary = sal;
        }
        void DisplayEmployee(Employee emp)
        {
            Console.WriteLine("EID:{0} || EMPNAME:{1} || LOCATION:{2} || SALARY:{3} || DID:{4} || Orgname:{5} ",
               Eid, Empname, Location, Salary, emp.Did,Organization.Orgname);
        }
        static void Main()
        {
            int Empid, Esalary;
            string Elocation, Ename;
            Employee employee = new Employee();
            //PROPERTY
            /* employee.Eid = 1001;
             employee.Empname = "varad";
             employee.Location = "aurangabad";
             employee.Salary = 35000;
             //employee.did=101; //error it reads only
             Console.WriteLine("EID:{0} || EMPNAME:{1} || LOCATION:{2} || SALARY:{3} || DID:{4} ",
                employee.Eid, employee.Empname, employee.Location, employee.Salary, employee.Did);*/
            //constructor
            int n = 2;
            Employee[] employee1 = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Eid:");
                Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                Ename = Console.ReadLine();
                Console.WriteLine("Enter Location:");
                Elocation = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                Esalary = Convert.ToInt32(Console.ReadLine());
                employee1[i] = new Employee(Empid, Ename, Elocation, Esalary);
            }
            // Employee employee1 = new Employee(Empid,Ename,Elocation,Esalary);
            //employee1.DisplayEmployee(employee);
            for (int i = 0; i < n; i++)
            {
                employee1[i].DisplayEmployee(employee);
            }
            //calling static method
            Organization.Getorgdetails();
        }
    }
}
