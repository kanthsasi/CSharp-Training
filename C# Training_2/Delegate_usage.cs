using System;
using System.Collections.Generic;


namespace C__Training_2
{
    internal class Delegate_usage
    {
        public delegate bool IsPromotable(Employee empl);
       
        public class Employee
        {
            public int id { get; set; }
            public string Name { get; set; }
            public int Experience { get; set; }
            public int Mark { set; get; }
            public void PromoteEmployee(List<Employee> EmployeeList, IsPromotable IsPromotetohike)
            {
                foreach (Employee Employees in EmployeeList)
                {
                    if (IsPromotetohike(Employees))
                    {
                        Console.WriteLine(Employees.Name + "Promoted");
                    }
                }
            }
        }
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { id = 1, Name = "Sasi", Experience = 6 });
            emplist.Add(new Employee() { id = 2, Name = "Sanjiv", Experience = 4 });
            emplist.Add(new Employee() { id = 3, Name = "Manoj", Experience = 3 });
            Employee pe = new Employee();
         
            pe.PromoteEmployee(emplist,emp=>emp.Experience>3);//Use Lamda expression
            Console.ReadLine();
        }
    }
}
