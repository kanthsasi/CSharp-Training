using System;
using System.Runtime.Remoting.Messaging;

namespace c__Training
{
    internal class Inheritance
    {
        public class Employee
        {
            public string f_name;
            public string l_name;
            public string Email;
            public void PrintFullName()
            {
                Console.WriteLine("Full Name is:" + f_name + " " + l_name);
            }
        }
            public class FullTimeEmployee : Employee
            {
                public float YearlySalary;
             public void Salary(float YearlySalary)
            {
                Console.WriteLine(YearlySalary);
            }
                            
            }
            public class PartTimeEmployee : Employee
            {
                public float HourlySalary;
            public void Salary(float HourlySalary)
            {
                Console.WriteLine(HourlySalary);
            }
            }
        
        static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.f_name = "Sasi";
            fte.l_name = "Kanth";
            fte.Email = "Kanthsai2003@gmail.com";
            fte.PrintFullName();
            //fte.YearlySalary = 100000.0F;
            fte.Salary(100000.00F);

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.f_name = "Sasi";
            pte.l_name = "Kanth";
            pte.Email = "Kanthsai2003@gmail.com";
            pte.PrintFullName();
            //fte.YearlySalary = 100000.0F;
            pte.Salary(1000.00F);

            Console.ReadLine();
        }
    }
}
