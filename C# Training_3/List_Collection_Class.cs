using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class List_Collection_Class
    {
        public class Customer
        {
            public int id;
            public string name;
            public int salary;
        }
        static void Main()
        {
            Customer c1 = new Customer() { id = 101, name = "Sasi", salary = 5000 };
            Customer c2 = new Customer() { id = 102, name = "Saro", salary = 7000 };
            Customer c3 = new Customer() { id = 103, name = "Sarogini", salary = 8000 };
            List<Customer> customer = new List<Customer>() { c1, c2, c3 };
            // if (customer.Contains(c3))
            if (customer.Exists(cus => cus.name.StartsWith("c")))
            {
                Console.WriteLine("iTEM is exists");
            }
            else
            {
                Console.WriteLine("iTEM does not exists");
            }
            Console.WriteLine("-------------------------------------------------");
            Customer cu = customer.Find(cus => cus.salary > 5500);
            Console.WriteLine("ID={0},Name={1},Salary={2}", cu.id, cu.name, cu.salary);
            Console.WriteLine("-------------------------------------------------");
            int index = customer.FindIndex(cust=>cust.salary>5000);
            Console.WriteLine("Index:" + index);
            Console.WriteLine("-------------------------------------------------");
            int indexs = customer.FindLastIndex(cust=>cust.salary>5000);
            Console.WriteLine("Index:"+indexs);
            Console.WriteLine("-------------------------------------------------");
            List<Customer> c = customer.FindAll(cus => cus.salary > 5000);
            foreach (Customer cust in c)
            { 
            Console.WriteLine("ID={0},Name={1},Salary={2}", cust.id, cust.name, cust.salary);
            }
            Console.ReadLine();
        }
    }
}
