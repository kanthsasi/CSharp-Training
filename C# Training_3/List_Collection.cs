using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class List_Collection
    {
        static void Main()
        {
            Employee e1 = new Employee() {id=101,name="A",salary=1 };
            Employee e2 = new Employee() {id=102,name="B",salary=2 };
            Employee e3 = new Employee() {id=103,name="C",salary=3 };
            List<Employee> employee = new List<Employee> { e1, e2, e3 };
            employee.Insert(0,e3);
            Console.WriteLine(employee.IndexOf(e3,2));
            Console.ReadLine();
            
        }
    }
}
