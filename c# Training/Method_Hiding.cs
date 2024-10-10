using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Method_Hiding
    {
        public class Employee
        {
            public string f_name;
            public string l_name;
            public string Email;
            public  void PrintFullName()
            {
                Console.WriteLine("Full Name is:" + f_name + " " + l_name);
            }
            
        }
        public class FullTimeEmployee : Employee
        {
            public   new void PrintFullName()
            {
                base.PrintFullName();//first way to call parent class method.
                Console.WriteLine("Full Name is:" + f_name + " " + l_name+"-----");
            }

        }
        public class PartTimeEmployee : Employee
        {
            
        }
        static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.PrintFullName();
            ((Employee)fte).PrintFullName();//second way to call parent class method.
            Console.ReadLine();
        }
    }
}
