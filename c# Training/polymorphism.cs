using System;
using System.Xml.Linq;


namespace c__Training
{
    internal class polymorphism
    {
        public class Employee
        {
            public string fname;
            public string lname;
            public  virtual void FullName()
            {
                Console.WriteLine("Full name:"+fname+" "+lname);
            }
        }
        public class FullTimeEmployee : Employee
        {
            public override void FullName()
            {
                Console.WriteLine("Full name:" + fname + " " + lname+"--Full Time Employee--");
            }
        }
        public class PartTimeEmployee : Employee
        {
            public override void FullName()
            {
                Console.WriteLine("Full name:" + fname + " " + lname+"--Part Time Employee--");
            }
        }
        public class TemporaryEmployee : Employee
        {
            public override void FullName()
            {
                Console.WriteLine("Full name:" + fname + " " + lname+"--Temp Employee");
            }
        }
        static void Main()
        {
            Employee[] t = new Employee[4];
            t[0] = new Employee()
            {
                fname="Sasi",
                lname="Kanth"
            };
            t[1] = new FullTimeEmployee();
            t[2] = new PartTimeEmployee();
            t[3] = new TemporaryEmployee();
            foreach (Employee e in t)
            {
                e.FullName();
                
            }
            Console.ReadLine();
        }
    }
}
