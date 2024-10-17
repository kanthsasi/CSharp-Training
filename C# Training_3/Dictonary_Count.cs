using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Customer
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Dictonary_Count
    {
        static void Main()
        {
            Customer c1 = new Customer() { id = 101, name = "Sanjiv Durai", salary = 40000 };
            Customer c2 = new Customer() { id = 102, name = "Manoj", salary = 35000 };
            Customer c3 = new Customer() { id = 103, name = "Venkat", salary = 38000 };
            Dictionary<int, Customer> dictonary = new Dictionary<int, Customer>();
            dictonary.Add(c1.id,c1);
            dictonary.Add(c2.id,c2);
            dictonary.Add(c3.id,c3);
            Console.WriteLine("Total Item:"+dictonary.Count(kvp=>kvp.Value.salary > 35000));
            Console.ReadLine();
        }
    }
}
